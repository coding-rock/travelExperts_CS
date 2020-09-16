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
  public partial class frmHome : Form
  {
    public frmHome()
    {
      InitializeComponent();
    }

    private void btnPackages_Click(object sender, EventArgs e)
    {
      frmPackage pkgForm = new frmPackage();
      pkgForm.ShowDialog();
    }

    private void btnProduct_Click(object sender, EventArgs e)
    {
      frmProduct prodForm = new frmProduct();
      prodForm.ShowDialog();
    }

    private void frmSupplier_Click(object sender, EventArgs e)
    {
      frmSupplier supplierForm = new frmSupplier();
      supplierForm.ShowDialog();
    }

    private void bunExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
