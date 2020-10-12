using System;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Experts_CS
{
  /// <summary>
  /// Purpose: form to add/edit product
  /// Author: Pengfei (Patrick) Chen
  /// Date: October, 2020
  /// </summary>
  public partial class frmAddEditProduct : Form
  {
    public bool bIsNewProduct = false;  //  False means Edit, true means Add
    public Product objCurrentProduct;   //  Current product
    public frmAddEditProduct()
    {
      InitializeComponent();
    }

    private void frmAddEditProduct_Load(object sender, EventArgs e)
    {
      //  set the form text and product ID (-1 for add new) and for add a new product
      if (bIsNewProduct)
      {
        this.Text = "Add a new product";
        productIdTextBox.Text = "";
      }
      //  set the form text and also product ID and name
      else
      {
        this.Text = "Edit an existing product";
        productIdTextBox.Text = objCurrentProduct.ProductId.ToString();
        prodNameTextBox.Text = objCurrentProduct.ProdName;
      }
    }

    // user can click "Cancel" button to close the form
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    // user can click the "Save" button to save the data to the database
    private void btnSave_Click(object sender, EventArgs e)
    {
      //  if the product name is empty, give user a warning message and return
      if (prodNameTextBox.TextLength <= 0)
      {
        MessageBox.Show("The Product Name is required!", "Name is missing");
        return;
      }

      //  confirm with user before write data to the database
      String strConfirmation = bIsNewProduct ? "Do you want to add a new product: " : "Do you want to change the product to ";
      strConfirmation += prodNameTextBox.Text + "?";
      if (MessageBox.Show(strConfirmation, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
        return;

      //  write data to the database
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          Product objProduct = null;
          if (bIsNewProduct)// add a new product
          {
            objProduct = new Product
            {
              ProdName = prodNameTextBox.Text
            };
            dbContext.Products.InsertOnSubmit(objProduct);
          }

          else      //  edit the existing product
          {
            objProduct = dbContext.Products.Single(prod => prod.ProductId ==
                                                    Convert.ToInt32(productIdTextBox.Text));
            objProduct.ProdName = prodNameTextBox.Text;


          }

          dbContext.SubmitChanges();  //  save the changes to database
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Some error happened: " + ex.Message, ex.GetType().ToString());
      }

      DialogResult = DialogResult.OK;
    }
  } //  end of class
} //  end of namespace
