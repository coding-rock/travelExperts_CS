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
  public partial class frmSupplier : Form
  {
    public frmSupplier()
    {
      InitializeComponent();
    }

    private void frmSupplier_Load(object sender, EventArgs e)
    {
      TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext();
      supplierDataGridView.DataSource = (from supp in dbContext.Suppliers
                                        orderby supp.SupName
                                        select supp).ToList();
    }
  }
}
