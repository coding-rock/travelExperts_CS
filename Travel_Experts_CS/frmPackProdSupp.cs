using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts_CS
{
  public partial class frmPackProdSupp : Form
  {
    public bool isAddPPS; // used for PPS editing form
    public int packageID;
    public int oldPSID; // used to hold PSID for modification
    public int oldProdID; // holds old prod ID for potential modification
    public string packageName;
    public string productName;
    public string supplierName;

    public frmPackProdSupp()
    {
      InitializeComponent();
    }

    private void frmPackProdSupp_Load(object sender, EventArgs e)
    {
      DisplayProductList();
      txtPackageID.Text = packageID.ToString();
      txtPackageName.Text = packageName;
      if (!isAddPPS) // if modify, fill with old product and supplier
      {
        cbProducts.SelectedText = productName;
        DisplaySuppliersList(oldProdID);
        cbSuppliers.SelectedText = supplierName;
      } 
      else // else set combo box choice to index 0.
      {
        cbProducts.SelectedIndex = 0;
        DisplaySuppliersList(Convert.ToInt32(cbProducts.SelectedValue));
        cbSuppliers.SelectedIndex = 0;
      }
      cbProducts.Focus();

    }

    private void DisplayProductList()
    {
      List<Product> products = new List<Product>();

      using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
      {
        products = (from prod in dbContext.Products
                    select prod).ToList();

        productBindingSource.DataSource = products;
      }
    }

    private void DisplaySuppliersList(int prodID)
    {
      List<Supplier> suppliers = new List<Supplier>(); // variable to contain supplier list
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          // query for suppliers that offer the listed product
          suppliers = (from p in dbContext.Products
                       join ps in dbContext.Products_Suppliers
                          on p.ProductId equals ps.ProductId
                       join s in dbContext.Suppliers
                          on ps.SupplierId equals s.SupplierId
                       where p.ProductId == prodID
                       select s).ToList();

          supplierBindingSource.DataSource = suppliers;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
      DisplaySuppliersList(Convert.ToInt32(cbProducts.SelectedValue));
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      int productID = Convert.ToInt32(cbProducts.SelectedValue);
      int supplierID = Convert.ToInt32(cbSuppliers.SelectedValue);
      int prodSuppID = GetPSID(productID, supplierID);


      if (isAddPPS) // if new PPS combo, then we add it to the list with a new ID.
      {
        if (Validator.IsSelectedCB(cbProducts) &&
            Validator.IsSelectedCB(cbSuppliers) &&
            Validator.IsValidID(prodSuppID)
            ) // check if both combo boxes have values
        {
          try
          {
            using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
            {
              Packages_Products_Supplier newPPS = new Packages_Products_Supplier
              {
                PackageId = packageID,
                ProductSupplierId = prodSuppID
              };

              if (newPPS != null)
              {
                dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPPS);
                dbContext.SubmitChanges();
              } 
              else
              {
                MessageBox.Show("This Product/Supplier combo already exists.", "Entry Error");
                DialogResult = DialogResult.Retry;
              }
              
            }
            DialogResult = DialogResult.OK;
          }
          catch (ChangeConflictException)
          {
            MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
            DialogResult = DialogResult.Retry;
          }
          catch (Exception ex)
          {
            MessageBox.Show("Product/Supplier combo already exists or an SQL error occured:\n\n" 
                            + ex.Message, ex.GetType().ToString());
          }
        }
      }
      else // Modify. retrieve an already existing product supplier, and link it to a package
      {
        if (Validator.IsSelectedCB(cbProducts) &&
            Validator.IsSelectedCB(cbSuppliers) &&
            Validator.IsValidID(prodSuppID)
            ) // check if both combo boxes have values
        {
          try
          {
            using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
            {
              // get the pps row to be modified. It gets back a row that matches the package ID and old PSID.
              //Packages_Products_Supplier pps = dbContext.Packages_Products_Suppliers.Single(p => p.ProductSupplierId == oldPSID && p.PackageId == packageID);

              //Packages_Products_Supplier pps = dbContext.Packages_Products_Suppliers.Single

              // issue here
              //Packages_Products_Supplier pps = (from p in dbContext.Packages_Products_Suppliers
              //           where p.ProductSupplierId == prodSuppID
              //           && p.PackageId == Convert.ToInt32(txtPackageID.Text)
              //           select p).Single();

              var pps = (from p in dbContext.Packages_Products_Suppliers
                         where p.ProductSupplierId == oldPSID
                         && p.PackageId == packageID
                         select p).Single();

              pps.ProductSupplierId = prodSuppID;
              dbContext.SubmitChanges();
              MessageBox.Show("Product/Supplier combo updated successfully.", "Success!");
              DialogResult = DialogResult.OK;

              //if (pps != null) // if the product/supplier combo exist already, show error.
              //{
              //  MessageBox.Show("This record already exists.", "Concurrency Exception");
              //  DialogResult = DialogResult.Cancel;
              //}
              //else // change the product supplier ID
              //{
              //  pps.ProductSupplierId = prodSuppID; // reassign the prodSuppID;
              //  dbContext.SubmitChanges();
              //  DialogResult = DialogResult.OK; // close form
              //}
            }
          }
          catch (ChangeConflictException)
          {
            MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
            DialogResult = DialogResult.Retry;
          }
          catch (Exception ex)
          {
            MessageBox.Show("Product/Supplier combo already exists or an SQL error occured:\n\n" 
                            + ex.Message, ex.GetType().ToString());
          }
        }
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

    // gets the Product supplier combo ID
    private int GetPSID(int prodID, int suppID)
    {
      int psID = -1;
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          // get values for supplier and product IDs to find the matching PSID.
          int productID = Convert.ToInt32(cbProducts.SelectedValue);
          int supplierID = Convert.ToInt32(cbSuppliers.SelectedValue);

          // find the correct PS ID to add into the PPS table.
          Products_Supplier psIDQuery = (from ps in dbContext.Products_Suppliers
                                         where (ps.ProductId == productID &&
                                                ps.SupplierId == supplierID)
                                         select ps
                                          ).Single();
          psID = psIDQuery.ProductSupplierId;
          return psID;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
        return psID;
      }
    }


  }
}
