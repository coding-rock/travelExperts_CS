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

/// <summary>
/// Designed by Tarek Alatrach
/// 2020 October
/// </summary>
namespace Travel_Experts_CS
{
  public partial class frmAddEditPackage : Form
  {
    // assigned from home form
    public bool isAdd; 
    public int packageID;

    public frmAddEditPackage()
    {
      InitializeComponent();
    }

    private void frmAddEditPackage_Load(object sender, EventArgs e)
    {
      if (!isAdd) // if modifying
        DisplayCurrentPackage();
      txtPkgName.Focus();
    }

  // populate fields and grid with data based on package ID.
  private void DisplayCurrentPackage()
    {
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          // fetch package based on id passed from package form.
          Package package = dbContext.Packages.Single(pack => pack.PackageId == packageID);

          // fill in text boxes
          txtPackageID.Text = package.PackageId.ToString();
          txtPkgDesc.Text = package.PkgDesc;
          txtPkgName.Text = package.PkgName;
          txtPkgCom.Text = Convert.ToDecimal(package.PkgAgencyCommission).ToString();
          txtPkgBasePrice.Text = package.PkgBasePrice.ToString();
          dtpStart.Value = (DateTime)package.PkgStartDate;
          dtpEnd.Value = (DateTime)package.PkgEndDate;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (isAdd)
      {
        // All fields provided, ID unique. Dates younger than today and end > start
        if (Validator.IsPresent(txtPkgName) &&
            Validator.IsPresent(txtPkgDesc) &&
            Validator.IsMaxLength(txtPkgDesc, 50) &&
            Validator.IsMinLength(txtPkgDesc, 10) &&
            Validator.IsPresent(txtPkgBasePrice) &&
            Validator.IsNonNegativeDecimal(txtPkgBasePrice) &&
            Validator.IsPresent(txtPkgCom) &&
            Validator.IsNonNegativeDecimal(txtPkgCom) &&
            IsValidCommPrice(txtPkgCom) &&
            IsValidEndDate(dtpEnd)
            )
        {
          Package newPackage = new Package
          {
            PkgName = txtPkgName.Text,
            PkgDesc = txtPkgDesc.Text,
            PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text),
            PkgAgencyCommission = Convert.ToDecimal(txtPkgCom.Text),
            PkgStartDate = Convert.ToDateTime(dtpStart.Value),
            PkgEndDate = Convert.ToDateTime(dtpEnd.Value)
          };
          try
          {
            using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
            {
              // insert newpackage into the DB
              dbContext.Packages.InsertOnSubmit(newPackage);
              dbContext.SubmitChanges();
            }
            DialogResult = DialogResult.OK;
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
          }
        }
      }
      else // if modify
      {
        if (Validator.IsPresent(txtPkgName) &&
            Validator.IsPresent(txtPkgDesc) &&
            Validator.IsMaxLength(txtPkgDesc, 50) &&
            Validator.IsMinLength(txtPkgDesc, 10) &&
            Validator.IsPresent(txtPkgBasePrice) &&
            Validator.IsNonNegativeDecimal(txtPkgBasePrice) &&
            Validator.IsPresent(txtPkgCom) &&
            Validator.IsNonNegativeDecimal(txtPkgCom) &&
            IsValidCommPrice(txtPkgCom) &&
            IsValidEndDate(dtpEnd)
            )
        {
          try
          {
            using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
            {
              Package pack = dbContext.Packages.Single(p => p.PackageId == GetPackageID());

              // Check to see if package still exists, if it does, reassign values
              if (pack != null)
              {
                pack.PackageId = Convert.ToInt32(txtPackageID.Text);
                pack.PkgName = txtPkgName.Text;
                pack.PkgDesc = txtPkgDesc.Text;
                pack.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                pack.PkgAgencyCommission = Convert.ToDecimal(txtPkgCom.Text);
                pack.PkgStartDate = Convert.ToDateTime(dtpStart.Value);
                pack.PkgEndDate = Convert.ToDateTime(dtpEnd.Value);
                dbContext.SubmitChanges();
                DialogResult = DialogResult.OK;
              }
              else
              {
                MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                DialogResult = DialogResult.Cancel;
              }
            }
          }
          catch (ChangeConflictException)
          {
            MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
            DialogResult = DialogResult.Retry;
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
          }
        }
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

    private int GetPackageID()
    {
      return Convert.ToInt32(txtPackageID.Text);
    }

    // rejects date if end date is younger than start date
    private bool IsValidEndDate(DateTimePicker endDate)
    {
      if (endDate.Value < dtpStart.Value)
      {
        MessageBox.Show("End Date must be on or after the Start Date", "Entry Error");
        endDate.Focus();
        return false;
      }
      return true;
    }

    // rejects commissions greater than package price
    private bool IsValidCommPrice(TextBox textBox)
    {
      {
        if (Convert.ToDecimal(textBox.Text) >= Convert.ToDecimal(txtPkgBasePrice.Text))
        {
          MessageBox.Show("Agency Commission must be less than the Package Price", "Entry Error");
          textBox.Focus();
          return false;
        }
        return true;
      }
    }
  }
}
