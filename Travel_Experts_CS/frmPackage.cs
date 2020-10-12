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
  /// <summary>
  /// Designed by Tarek Alatrach
  /// 2020 October
  /// </summary>
  public partial class frmPackage : Form
  {
    public frmPackage()
    {
      InitializeComponent();
    }

    private void frmPackage_Load(object sender, EventArgs e)
    {
      RefreshDisplay();
    }

    private void frmPackage_Activated(object sender, EventArgs e)
    {
      RefreshDisplay();
    }

    private void RefreshDisplay()
    {
      DisplayPackages();
      DisplayPackageDetails();
    }

    // queries for packages list and binds it to datasource.
    private void DisplayPackages()
    {
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          var allPackages = (from pack in dbContext.Packages select pack);
          this.packageBindingSource.DataSource = allPackages;
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message, exception.GetType().ToString());
      }
    }

    // queries for Package Product Suppliers and displays useful names in grid view
    private void DisplayPackageDetails()
    {
      if (txtPackageID.Text != "")
      {
        try
        {
          int packId = getPackageID();
          using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
          {
            // Join PPS with products and suppliers to fetch their names
            var query = (from pps in dbContext.Packages_Products_Suppliers
                         join ps in dbContext.Products_Suppliers
                            on pps.ProductSupplierId equals ps.ProductSupplierId
                         join prod in dbContext.Products
                            on ps.ProductId equals prod.ProductId
                         join supp in dbContext.Suppliers
                            on ps.SupplierId equals supp.SupplierId
                         where pps.PackageId == packId
                         select new
                         {
                           ProductName = prod.ProdName,
                           SupplierName = supp.SupName,
                           prod.ProductId,
                           pps.ProductSupplierId
                         }).ToList();
            PPSDataGridView.DataSource = query;
            PPSDataGridView.Columns[2].Visible = false; // hide prodid column
            PPSDataGridView.Columns[3].Visible = false; // hide PSID column
          }
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message, exception.GetType().ToString());
        }
      }
    }

    private int getPackageID()
    {
      return Convert.ToInt32(txtPackageID.Text);
    }

    private void btnAddPPS_Click(object sender, EventArgs e)
    {
      frmPackProdSupp ppsForm = new frmPackProdSupp();
      ppsForm.isAddPPS = true;
      ppsForm.packageID = Convert.ToInt32(txtPackageID.Text);
      ppsForm.packageName = txtPackageName.Text;
      DialogResult result = ppsForm.ShowDialog();
    }

    private void txtPackageID_TextChanged(object sender, EventArgs e)
    {
      DisplayPackageDetails();
    }

    // Delete a prod/supp combo
    private void btnDeletePPS_Click(object sender, EventArgs e)
    {
      // prompt user to confirm deletion
      DialogResult delete = MessageBox.Show("Are you sure you want to delete this Product/Supplier Combo?", "Delete Product/Supplier Combo", MessageBoxButtons.YesNo);
      if (delete == DialogResult.Yes)
      {
        int packageId = Convert.ToInt32(txtPackageID.Text);
        int psId = (int)PPSDataGridView[3, PPSDataGridView.CurrentCell.RowIndex].Value;
        try
        {
          using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
          {
            // get prod/supplier combo
            var pps = (from p in dbContext.Packages_Products_Suppliers
                       where p.ProductSupplierId == psId
                       && p.PackageId == packageId
                       select p).Single();

            // delete and submit
            dbContext.Packages_Products_Suppliers.DeleteOnSubmit(pps);
            dbContext.SubmitChanges();
            DisplayPackageDetails();
          }
        }
        catch (ChangeConflictException)
        {
          MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
          DialogResult = DialogResult.Retry;
        }
        catch (Exception ex)
        {
          MessageBox.Show("An SQL error occured:\n\n"
                          + ex.Message, ex.GetType().ToString());
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      // open new empty add package form
      frmAddEditPackage secondForm = new frmAddEditPackage();
      secondForm.isAdd = true;
      DialogResult result = secondForm.ShowDialog();
      if (result == DialogResult.OK)
        RefreshDisplay();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      // open new empty add package form with modify option
      frmAddEditPackage secondForm = new frmAddEditPackage();
      secondForm.isAdd = false;
      secondForm.packageID = Convert.ToInt32(txtPackageID.Text); // send prod ID to second form
      DialogResult result = secondForm.ShowDialog();
      if (result == DialogResult.OK)
        RefreshDisplay();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      // prompt user to confirm option
      DialogResult delete = MessageBox.Show("Are you sure you want to delete this package? " +
                                            "\n\n This will delete all attached product/supplier combos in this package.",
                                            "Delete Package", MessageBoxButtons.YesNo);
      if (delete == DialogResult.Yes)
      {
        try
        {
          using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
          {
            int packId = Convert.ToInt32(txtPackageID.Text);

            // query for package
            var package = (from pack in dbContext.Packages
                           where pack.PackageId == packId
                           select pack).Single();

            // query for all prodsuppliers in that package
            var prodSupp = (from ps in dbContext.Packages_Products_Suppliers
                            where ps.PackageId == packId
                            select ps).ToList();



            // delete all prod/supp combos for this package
            foreach (var ps in prodSupp)
              dbContext.Packages_Products_Suppliers.DeleteOnSubmit(ps);
            dbContext.Packages.DeleteOnSubmit(package); // delete the package and submit changes
            dbContext.SubmitChanges();
            RefreshDisplay();
          } 
        }
        catch (Exception ex)
        {
        MessageBox.Show("An SQL error occured:\n\n"
                        + ex.Message, ex.GetType().ToString());
        }
      }
    }
  }
}
