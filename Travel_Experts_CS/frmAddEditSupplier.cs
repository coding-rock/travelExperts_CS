using System;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Experts_CS
{
  public partial class frmAddEditSupplier : Form
  {
    public bool isNewSupplier = false;  // False -> Edit, True -> Add; variable set in frmSupplier button click
    public Supplier currentSupplier;    // keep track of current supplier

    public frmAddEditSupplier()
    {
      InitializeComponent();
    }

    private void frmSupplierAddEditSup_Load(object sender, EventArgs e)
    {
      if (isNewSupplier) // user clicked on Add button
      {
        this.Text = "Add a new Supplier";
        //txtSupplierId.Text = "-1";     // (-1 for adding new)
      }
      else // user clicked on Edit button
      {
        this.Text = "Edit an existing Supplier";
        txtSupplierId.Enabled = false;
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
      if (
          Validator.IsPresent(txtSupplierId) &&
          Validator.IsInt32(txtSupplierId) &&
          Validator.IsMinLength(txtSupplierId, 2) &&
          Validator.IsCorrectLength(txtSupplierId, 5) &&
          Validator.IsPresent(txtSupplierName) &&
          Validator.IsMaxLength(txtSupplierName, 200)
         )
      {
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
              string addSuppName = txtSupplierName.Text.ToUpper();
              txtSupplierId.Enabled = true;
              // check for duplicate
              var checkForDuplicate = dbContext.Suppliers.SingleOrDefault
                                      (sup => sup.SupName == addSuppName);
              if (checkForDuplicate != null) // tempSuppName already exist in DB
              {
                MessageBox.Show(addSuppName + " already exists in database", "Duplicated Data");
                return;
              }
              else
              {
                supplier = new Supplier
                {
                  SupplierId = Convert.ToInt32(txtSupplierId.Text),
                  SupName = txtSupplierName.Text.ToUpper()
                };
                dbContext.Suppliers.InsertOnSubmit(supplier);
              }
            }
            else // edit supplier (isNewSupplier = false)
            {
              supplier = dbContext.Suppliers.Single(sup => sup.SupplierId ==
                                                      Convert.ToInt32(txtSupplierId.Text));
              txtSupplierId.Enabled = false;
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
    }

  } // end of class
} // end of namespace
