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
  /// <summary>
  /// Author: Stevyn Shen
  /// Date: September 2020
  /// Purpose: To perform CRUD activity for Suppliers table
  /// To-Do: 1. Add Supplier Name validation for IsPresent, Min Max length
  ///        2. Upper all Added SupplierName
  ///        3. SupplierID PK auto
  ///        4. SelectionChange vs CellClick
  /// </summary>
  public partial class frmSupplier : Form
  {
    public frmSupplier()
    {
      InitializeComponent();
    }

    /*************/
    /* Form Load */
    /*************/
    private void frmSupplier_Load(object sender, EventArgs e)
    {
      DisplaySuppliers();
      int supplierID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", 0].Value);
      // '0' initiallizes dataGridView with first supplier on database
      DisplayProductsOfSupplier(supplierID);
    }

    /**************************/
    /* Events / Accessibility */
    /**************************/
    // Appears to cause errors when DELETING will see if I can use this event over CellClick
    private void dgvSupplier_SelectionChanged(object sender, EventArgs e)
    {
        //int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
        //int currentSupID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
        //DisplayProductsOfSupplier(currentSupID);          
    } 

    private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      int currentSupID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      DisplayProductsOfSupplier(currentSupID);
    }



    /***********************/
    /* Methods / Functions */
    /***********************/
    private void DisplaySuppliers()
    {
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          dgvSupplier.DataSource = (from supp in dbContext.Suppliers
                                    orderby supp.SupName
                                    select supp).ToList();
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message, exception.GetType().ToString());
      }
    }
      
    // returns supplier name of a supplier id
    private string GetSupplierName(int id)
    {
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          var query = (from s in dbContext.Suppliers
                       where s.SupplierId == id
                       select s).SingleOrDefault();
          return query.SupName;
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message, exception.GetType().ToString());
        return "";
      }
    }

    // display the product(s) a supplier offers.
    private void DisplayProductsOfSupplier(int supID)
    {
      String strSupName = GetSupplierName(supID);
      if (strSupName.Length > 0)
        lblSupplierProdList.Text = "Products offered by Supplier: " + strSupName;
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          var query = (from pro_sup in dbContext.Products_Suppliers
                       join prod in dbContext.Products
                         on pro_sup.ProductId equals prod.ProductId
                       where pro_sup.SupplierId == supID
                       orderby prod.ProdName
                       select new
                       {
                         Prod_Supp_ID = pro_sup.ProductSupplierId,
                         Product_Name = prod.ProdName
                       }).ToList();

          dgvProdOfSupplier.DataSource = query;
          dgvProdOfSupplier.Columns[0].Width = 110;
          dgvProdOfSupplier.Columns[1].Width = 140;
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message, exception.GetType().ToString());
      }
    }

    /*************************/
    /* Supplier CRUD Buttons */
    /*************************/
    // ADD
    private void btnAddSupplier_Click(object sender, EventArgs e)
    {
      DialogResult result = DialogResult.Cancel;

      frmSupplierAddEditSup frmAddSup = new frmSupplierAddEditSup();
      frmAddSup.isNewSupplier = true;
      result = frmAddSup.ShowDialog();

      if (result == DialogResult.OK)
        DisplaySuppliers();
    }

    // EDIT
    private void btnEditSupplier_Click(object sender, EventArgs e)
    {
      DialogResult result = DialogResult.Cancel;

      frmSupplierAddEditSup frmEditSup = new frmSupplierAddEditSup();
      frmEditSup.isNewSupplier = false;
      int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      int suppID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
      {
        frmEditSup.currentSupplier = (from supp in dbContext.Suppliers
                                      where supp.SupplierId == suppID
                                      select supp).Single();
      }
      result = frmEditSup.ShowDialog();

      if (result == DialogResult.OK)
        DisplaySuppliers();
    }

    // DELETE
    private void btnDeleteSupplier_Click(object sender, EventArgs e)
    {
      DialogResult result = DialogResult.Cancel;

      int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      int supplierID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);

      DialogResult answer = MessageBox.Show("Are you sure about DELETING?", "Confirm", MessageBoxButtons.OKCancel);
      if (answer == DialogResult.OK)
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          try
          {
            Supplier currentSupplier = (from s in dbContext.Suppliers
                                        where s.SupplierId == supplierID
                                        select s).Single();
            dbContext.Suppliers.DeleteOnSubmit(currentSupplier);
            dbContext.SubmitChanges();
            DisplaySuppliers();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
          }
        }
      }

      if (result == DialogResult.OK)
        DisplaySuppliers();
    }

    // EXIT WINDOW
    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    /***************************************/
    /* Product(s) of Supplier CRUD Buttons */
    /***************************************/





  } // end of class
} // end of namespace
