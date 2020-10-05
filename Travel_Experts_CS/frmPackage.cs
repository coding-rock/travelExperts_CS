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
  public partial class frmPackage : Form
  {
    public frmPackage()
    {
      InitializeComponent();
    }


    private void frmPackage_Load(object sender, EventArgs e)
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
          int id = getPackageID();
          using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
          {
            var query = (from a in dbContext.Packages_Products_Suppliers
                         join b in dbContext.Products_Suppliers
                            on a.ProductSupplierId equals b.ProductSupplierId
                         join prod in dbContext.Products
                            on b.ProductId equals prod.ProductId
                         join supp in dbContext.Suppliers
                            on b.SupplierId equals supp.SupplierId
                         where a.PackageId == id
                         select new
                         {
                           ProductName = prod.ProdName,
                           SupplierName = supp.SupName,
                           prod.ProductId,
                           a.ProductSupplierId
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
      //frmPackProdSupp ppsForm = new frmPackProdSupp();
      //ppsForm.isAddPPS = true;
      //ppsForm.packageID = Convert.ToInt32(txtPackageID.Text);
      //ppsForm.packageName = txtPackageName.Text;
      //DialogResult result = ppsForm.ShowDialog();
    }

    private void btnModifyPPS_Click(object sender, EventArgs e)
    {
      //frmPackProdSupp ppsForm = new frmPackProdSupp();
      //ppsForm.isAddPPS = false;
      //ppsForm.packageID = Convert.ToInt32(txtPackageID.Text);
      //ppsForm.packageName = txtPackageName.Text;
      //ppsForm.productName = PPSDataGridView[0, PPSDataGridView.CurrentCell.RowIndex].Value.ToString();
      //ppsForm.oldProdID = (int)PPSDataGridView[2, PPSDataGridView.CurrentCell.RowIndex].Value;
      //ppsForm.oldPSID = (int)PPSDataGridView[3, PPSDataGridView.CurrentCell.RowIndex].Value;
      //DialogResult result = ppsForm.ShowDialog();
    }

    private void txtPackageID_TextChanged(object sender, EventArgs e)
    {
      DisplayPackageDetails();
    }
  }
}
