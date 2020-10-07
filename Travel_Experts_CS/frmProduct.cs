using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts_CS
{
  /// <summary>
  /// Purpose: Source code for the form Product
  /// Author: Pengfei (Patrick) Chen
  /// Date: October, 2020
  /// </summary>
  public partial class frmProduct : Form
  {
    //  database context used in this form
    private TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext();
    private int nProductID = 0;   //  Product ID
    private int nProdSuppID = 0;  //  Product_Supplier ID
    private int nSupplierID = 0;  //  Supplier ID
    public frmProduct()
    {
      InitializeComponent();
    }

    private void frmProduct_Load(object sender, EventArgs e)
    {
      DisplayProducts();
    }

    private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      ChangeProduct();
    }

    /// <summary>
    /// Purpose: display and refresh the two supplier lists
    /// author: Pengfei (Patrick) Chen
    /// Date: October 2020
    /// </summary>
    /// <param name="nProductID">The current product ID for the form</param>
    private void DisplaySupplierOnProduct(int nProductID)
    {
      //  set the data source for the two supplier lists
      try
      {
        SupplierInGridView.DataSource = (from pro_sup in dbContext.Products_Suppliers
                                join supp in dbContext.Suppliers
                                  on pro_sup.SupplierId equals supp.SupplierId
                                where pro_sup.ProductId == nProductID
                                orderby supp.SupName
                                select new
                                {
                                  ID = pro_sup.ProductSupplierId,
                                  Name = supp.SupName
                                }).ToList();

        SupplierOutGridView.DataSource = (from Supplier in dbContext.Suppliers
                                          where !(from prod_sup in dbContext.Products_Suppliers
                                                  where prod_sup.ProductId == nProductID
                                                  select prod_sup.SupplierId).Contains(Supplier.SupplierId)
                                          orderby Supplier.SupName
                                          select new
                                          {
                                            ID = Supplier.SupplierId,
                                            Name = Supplier.SupName
                                          }).ToList();
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message, exception.GetType().ToString());
      }

      //  set the width for the 2 data grid views
      SupplierInGridView.Columns[0].Width = 50;
      SupplierInGridView.Columns[1].Width = 180;
      SupplierOutGridView.Columns[0].Width = 50;
      SupplierOutGridView.Columns[1].Width = 180;

      //  reset the 2 IDs to force users to select the item from the list to set IDs,
      //  which can avoid accidentally delete / add data in the database
      nProdSuppID = 0;
      nSupplierID = 0;
    }

    //  Update the Product_Supplier ID based on the selection of the grid view
    private void SupplierInGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowNum = Convert.ToInt32(SupplierInGridView.CurrentCell.RowIndex);
      nProdSuppID = Convert.ToInt32(SupplierInGridView["ID", rowNum].Value);
    }

    //  Update the Supplier ID based on the selection of the grid view
    private void SupplierOutGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowNum = Convert.ToInt32(SupplierOutGridView.CurrentCell.RowIndex);
      nSupplierID = Convert.ToInt32(SupplierOutGridView["ID", rowNum].Value);
    }

    //  Delete a Product_Supplier relation in the database
    private void btnDelete_Click(object sender, EventArgs e)
    {
      //  no supplier selected, give the user a warning message and return
      if(nProdSuppID == 0)
      {
        MessageBox.Show("Please select a Supplier from the List on the left-hand side please!");
        return;
      }

      //  get the current product Name and supplier Name for warning messages below
      int nRowNum = Convert.ToInt32(productDataGridView.CurrentCell.RowIndex);
      string strProductName = productDataGridView["Product", nRowNum].Value.ToString();
      nRowNum = Convert.ToInt32(SupplierInGridView.CurrentCell.RowIndex);
      string strSupplierName = SupplierInGridView["Name", nRowNum].Value.ToString();

      //  Check if the product-supplier ID was attached to some packages.
      var objPackages = (from pkg in dbContext.Packages
                         join pps in dbContext.Packages_Products_Suppliers
                         on pkg.PackageId equals pps.PackageId
                         where pps.ProductSupplierId == nProdSuppID
                         select pkg.PkgName).ToList();

      //  if the product-supplier ID was attached to some packages, give warning message and return
      if (objPackages.Count > 0)
      {
        string strPackageList = String.Empty;
        foreach(string pkg in objPackages)
          strPackageList += pkg + "\n";
        MessageBox.Show("The following packages have " +
          strProductName + " service provided by "+ strSupplierName +":\n" +
          strPackageList + "Please change the packages first.");
        return;
      }

      //  confirmation with user, return if user choose "No"
      if (MessageBox.Show("Are you sure the company " +
        strSupplierName + " does not provide the " + strProductName + " service any more?",
        "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
        return;

      //  Delete the record from database
      try
      {
        var objToBeDeleted = (from prod_supp in dbContext.Products_Suppliers
                              where prod_supp.ProductSupplierId == nProdSuppID
                              select prod_supp).FirstOrDefault();
        if (objToBeDeleted != null)
        {
          dbContext.Products_Suppliers.DeleteOnSubmit(objToBeDeleted);
          dbContext.SubmitChanges();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Some error happened: " + ex.Message, ex.GetType().ToString());
      }

      //  refresh the 2 supplier lists
      DisplaySupplierOnProduct(nProductID);

    }

    //  add a new Product_supplier relation to the database
    private void btnAdd_Click(object sender, EventArgs e)
    {
      //  if the current product ID is zero, give warning message and return
      if (nProductID == 0)
      {
        MessageBox.Show("Please select a product from the list first!");
        return;
      }

      //  if the current supplier ID is zero, give warning message and return
      if (nSupplierID == 0)
      {
        MessageBox.Show("Please select a supplier from the right-hand side list first!");
        return;
      }

      //  check if the record in the database already
      var objCheckDup = (from ps in dbContext.Products_Suppliers
                         where ps.ProductId == nProductID && ps.SupplierId == nSupplierID
                         select ps).FirstOrDefault();
      //  if the record in the database already, refresh the 2 supplier list and return
      if (objCheckDup != null)
      {
        MessageBox.Show("Someone has added this supplier already, please check it again!");
        DisplaySupplierOnProduct(nProductID);
        return;
      }

      //  insert the new record to the database
      Products_Supplier objProdSupp = new Products_Supplier
      {
        ProductId = nProductID,
        SupplierId = nSupplierID
      };
      dbContext.Products_Suppliers.InsertOnSubmit(objProdSupp);
      dbContext.SubmitChanges();

      //  refresh the 2 supplier list
      DisplaySupplierOnProduct(nProductID);
    }

    //  close the Product form
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    //  Click the New Product button to add a new product
    private void btnNewProduct_Click(object sender, EventArgs e)
    {
      frmAddEditProduct secondForm = new frmAddEditProduct();
      secondForm.bIsNewProduct = true;

      DialogResult result = secondForm.ShowDialog();

      //  if the new product was added into the database, refresh the product list
      if (result == DialogResult.OK)
        DisplayProducts();
    }

    //  display and refresh the product list
    private void DisplayProducts()
    {
      //  Set the data source for the product data grid view
      try
      {
        productDataGridView.DataSource = (from prod in dbContext.Products
                                          orderby prod.ProdName
                                          select new
                                          {
                                            ID = prod.ProductId,
                                            Product = prod.ProdName
                                          }).ToList();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }

      //  set the column width for the product data grid view
      productDataGridView.Columns[0].Width = 50;
      productDataGridView.Columns[1].Width = 200;

      //  set the first row as the default product
      nProductID = Convert.ToInt32(productDataGridView["ID", 0].Value);
      string strProductName = productDataGridView["Product", 0].Value.ToString();

      //  display the grid title for the two supplier lists
      lblSupplierIn.Text = "Suppliers provide the\n" + strProductName + " services:";
      lblSupplierOut.Text = "Suppliers do NOT provide the\n" + strProductName + " services:";

      //  display the data for the two supplier lists
      DisplaySupplierOnProduct(nProductID);
    }

    //  Click the Edit Product button to edit the current product
    private void btnEdit_Click(object sender, EventArgs e)
    {
      //  if no product was selected, give warning message and return
      if (nProductID == 0)
      {
        MessageBox.Show("Please select a product first!");
        return;
      }

      //  get the current product from the database
      Product objCurrentProduct = null;
      using (TravelExpertDataDataContext dbContext1 = new TravelExpertDataDataContext())
      {
        objCurrentProduct = (from prod in dbContext1.Products
                                     where prod.ProductId == nProductID
                                     select prod).SingleOrDefault();
      }

      //  if the current product does not exist, refresh the product list and return
      if (objCurrentProduct == null)
      {
        MessageBox.Show("The product does not exist any more, please check again!");
        DisplayProducts();
        return;
      }

      //  open the new form to edit the product
      frmAddEditProduct secondFrm = new frmAddEditProduct();
      secondFrm.bIsNewProduct = false;
      secondFrm.objCurrentProduct = objCurrentProduct;
      DialogResult result = secondFrm.ShowDialog();

      //  if the product was successfully edited, refresh the product list
      if (result == DialogResult.OK)
        DisplayProducts();
    }

    private void btnDeleteProduct_Click(object sender, EventArgs e)
    {
      //  if no product was selected, give warning message and return
      if (nProductID == 0)
      {
        MessageBox.Show("Please select a product first!");
        return;
      }

      //  get the current product Name for the warning messages below
      int nRowNum = Convert.ToInt32(productDataGridView.CurrentCell.RowIndex);
      string strProductName = productDataGridView["Product", nRowNum].Value.ToString();

      //  confirmation with user, return if user choose "No"
      if (MessageBox.Show("Are you sure to delete the product: " + strProductName + " ?",
        "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
        return;

      //  Check if some suppliers providing this services.
      var objSuppliers = (from ps in dbContext.Products_Suppliers
                           join s in dbContext.Suppliers
                           on ps.SupplierId equals s.SupplierId
                           where ps.ProductId == nProductID
                           select s.SupName).ToList();

      //  if some suppliers are providing the current product, give a warning message and return
      if (objSuppliers.Count > 0)
      {
        string strSupplierList = String.Empty;
        foreach (string s in objSuppliers)
          strSupplierList += s + "\n";
        MessageBox.Show("The following suppliers are providing the " +
          strProductName + " service:\n" + strSupplierList + "Please change them first.");
        return;
      }

      //  Delete the product from database
      try
      {
        var objToBeDeleted = (from p in dbContext.Products
                              where p.ProductId == nProductID
                              select p).FirstOrDefault();
        if (objToBeDeleted != null)
        {
          dbContext.Products.DeleteOnSubmit(objToBeDeleted);
          dbContext.SubmitChanges();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Some error happened: " + ex.Message, ex.GetType().ToString());
      }

      //  refresh product list
      DisplayProducts();
    }

    private void productDataGridView_SelectionChanged(object sender, EventArgs e)
    {
      ChangeProduct();
    }

    private void ChangeProduct()
    {
      //  set the product ID based on the selected row from the grid view
      int rowNum = Convert.ToInt32(productDataGridView.CurrentCell.RowIndex);
      nProductID = Convert.ToInt32(productDataGridView["ID", rowNum].Value);

      //  display the grid title for the two supplier lists
      string strProductName = productDataGridView["Product", rowNum].Value.ToString();
      lblSupplierIn.Text = "Suppliers provide the\n" + strProductName + " services:";
      lblSupplierOut.Text = "Suppliers do NOT provide the\n" + strProductName + " services:";

      //  display the data for the two supplier lists
      DisplaySupplierOnProduct(nProductID);
    }
  } //  end of class
} //  end of namespace
