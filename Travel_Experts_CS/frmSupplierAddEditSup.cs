using System;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Experts_CS
{
  public partial class frmSupplierAddEditSup : Form
  {
    public bool isNewSupplier = false;  // False -> Edit, True -> Add; variable set in frmSupplier button click
    public Supplier currentSupplier;    // keep track of current supplier

    public frmSupplierAddEditSup()
    {
      InitializeComponent();
    }

    private void frmSupplierAddEditSup_Load(object sender, EventArgs e)
    {
      if (isNewSupplier) // user clicked on Add button
      {
        this.Text = "Add a new supplier";
        //txtSupplierId.Text = "-1";     // (-1 for adding new)
      }
      else // user clicked on Edit button
      {
        this.Text = "Edit existing supplier";
        txtSupplierId.Text = currentSupplier.SupplierId.ToString();
        txtSupplierName.Text = currentSupplier.SupName;
      }
    }

    /************************/
    /* Opperational Buttons */
    /************************/
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      // supplier name field is not empty
      // PREVENT A NAME WITH SPACE ONLY
      // SupplierName must be UpperCased
      if (txtSupplierName.Text == "")
      {
        MessageBox.Show("The Supplier Name is required!", "Name is missing");
        return;
      }

      //  confirm with user before writing data to the database
      String strConfirmation = isNewSupplier ? "Add a new Supplier called: " : "Update Supplier Name to: ";
      strConfirmation += txtSupplierName.Text.ToUpper() + "?";
      if (MessageBox.Show(strConfirmation, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
        return;
      //  write data to the database
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          Supplier supplier = null;
          if (isNewSupplier) // add a new supplier
          {
            supplier = new Supplier
            {
              SupName = txtSupplierName.Text.ToUpper()
            };
            dbContext.Suppliers.InsertOnSubmit(supplier);
          }
          else // edit existing supplier
          {
            supplier = dbContext.Suppliers.Single(sup => sup.SupplierId ==
                                                    Convert.ToInt32(txtSupplierId.Text));
            supplier.SupName = txtSupplierName.Text.ToUpper();
          }
          dbContext.SubmitChanges();  //  save the changes to database
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Some error occurred while writing data:\n" + ex.Message, ex.GetType().ToString());
      }
      DialogResult = DialogResult.OK;
    }

  } // end of class
} // end of namespace
