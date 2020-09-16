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
  public partial class frmProduct : Form
  {
    public frmProduct()
    {
      InitializeComponent();
    }

    private void frmProduct_Load(object sender, EventArgs e)
    {
      TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext();
      productDataGridView.DataSource = (from prod in dbContext.Products
                                        orderby prod.ProdName
                                        select prod).ToList();
    }
  }
}
