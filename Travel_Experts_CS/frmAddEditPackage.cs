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
  public partial class frmAddEditPackage : Form
  {
    public bool isAdd; // assigned from home form
    public int packageID;

    public frmAddEditPackage()
    {
      InitializeComponent();
    }

    private void frmAddEditPackage_Load(object sender, EventArgs e)
    {
      if (isAdd)
      {
        // txtPackageID.Enabled = true;
        txtPackageID.Focus();
      }
      else // is modify
      {
        // DisplayCurrentPackage();
        txtPackageID.Text = "-1";
        // txtPackageID.Enabled = false;
        txtPkgName.Focus();
      }
    }
  }
}
