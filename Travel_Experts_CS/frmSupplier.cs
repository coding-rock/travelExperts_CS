using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Experts_CS
{
  /// <summary>
  /// Author: Stevyn Shen
  /// Date: September 2020
  /// Purpose: To perform CRUD activity for Suppliers table
  /// To-Do: 1. obtain combobox object value
  /// </summary>
  public partial class frmSupplier : Form
  {
    // database context used in this form
    // private TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext();

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
      RefreshPordOfSuppAndLists(supplierID);
    }

    /**************************/
    /* Events / Accessibility */
    /**************************/
    // Appears to cause errors when DELETING will see if I can use this event over CellClick
    private void dgvSupplier_SelectionChanged(object sender, EventArgs e)
    {
      //int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      //int currentSupID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      //RefreshPordOfSuppAndLists(currentSupID);
    }

    private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      int currentSupID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      RefreshPordOfSuppAndLists(currentSupID);
    }

    private void cbDeleteProd_SelectedIndexChanged(object sender, EventArgs e)
    {
      // obtain selected product ID from combo box
      //Object selectedItem = cbDeleteProd.SelectedItem;
      //MessageBox.Show("Selected Item Text: " + selectedItem.ToString() );
    }

    /***********************/
    /* Methods / Functions */
    /***********************/
    private void RefreshPordOfSuppAndLists(int suppId)
    {
      DisplayProductsOfSupplier(suppId);
      DisplayAddProductList(suppId);
      DisplayDeleteProductList(suppId);
    }

    private void DisplaySuppliers()
    {
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          dgvSupplier.DataSource = (from supp in dbContext.Suppliers
                                    orderby supp.SupName
                                    select supp).ToList();
          //dgvSupplier.DataSource = (from supp in dbContext.Suppliers
          //                          orderby supp.SupName
          //                          select new
          //                          {
          //                            Supplier_ID = supp.SupplierId,
          //                            Supplier_Name = supp.SupName
          //                          }).ToList();
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
        lblSupplierProdList.Text = "Products offered by: " + strSupName;
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
                         Product_ID = pro_sup.ProductId,
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

    private void DisplayAddProductList(int suppID)
    {
      try
      {
        List<Product> addProdList = new List<Product>();
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          addProdList = (from prod in dbContext.Products
                         where !(from prod_sup in dbContext.Products_Suppliers
                                 where prod_sup.SupplierId == suppID
                                 select prod_sup.ProductId).Contains(prod.ProductId)
                         orderby prod.ProdName
                         select prod).ToList();

          productBindingSource.DataSource = addProdList;
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message, exception.GetType().ToString());
      }
    }

    private void DisplayDeleteProductList(int suppID)
    {
      try
      {
        List<Product> deleteProdList = new List<Product>();
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          deleteProdList = (from prod in dbContext.Products
                            join pro_sup in dbContext.Products_Suppliers
                              on prod.ProductId equals pro_sup.ProductId
                            where pro_sup.SupplierId == suppID
                            orderby prod.ProdName
                            select prod).ToList();
          productBindingSource1.DataSource = deleteProdList;
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
      //DialogResult result = DialogResult.Cancel;
      int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      int supplierID = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);

      DialogResult delete = MessageBox.Show("Are you sure about DELETING this supplier?", 
                                            "Delete Supplier", MessageBoxButtons.YesNo);
      if (delete == DialogResult.Yes)
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
            MessageBox.Show(ex.Message, ex.GetType().ToString());
          }
        }
      }
      if (delete == DialogResult.Yes)
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
    private void btnAddProd_Click(object sender, EventArgs e)
    {
      // get the current product ID, Name and supplier ID, Name 
      int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      int currentSupId = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      string currentSupName = (dgvSupplier["dataGridViewTextBoxColumn2", rowNum].Value).ToString();

      // Need to obtain current product ID form comboBox

      rowNum = Convert.ToInt32(dgvProdOfSupplier.CurrentCell.RowIndex);
      int currentProdId = Convert.ToInt32(dgvProdOfSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      string currentProdName = dgvProdOfSupplier[2, rowNum].Value.ToString();

      // check if the current supplier already has current product in products_suppliers table
      using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
      {
        var CheckIfExists = (from ps in dbContext.Products_Suppliers
                             where ps.ProductId == currentProdId && ps.SupplierId == currentSupId
                             select ps).FirstOrDefault();

        //  if the record in the database already, refresh the 2 supplier list and return
        if (CheckIfExists != null)
        {
          MessageBox.Show("The Supplier has this product already, please check it again!");
          RefreshPordOfSuppAndLists(currentSupId);
          return;
        }
      }

      //  insert the new record to the database
      try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          Products_Supplier newProdSupp = new Products_Supplier
          {
            ProductId = currentProdId,
            SupplierId = currentSupId
          };
          dbContext.Products_Suppliers.InsertOnSubmit(newProdSupp);
          dbContext.SubmitChanges();

          //  refresh the product of supplier dataGridView and the two comboBoxes
          RefreshPordOfSuppAndLists(currentSupId);
        }
      }
      catch (Exception ex)
      { 
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void btnDeleteProd_Click(object sender, EventArgs e)
    {
      //  get the current product Name and supplier Name 
      int rowNum = Convert.ToInt32(dgvSupplier.CurrentCell.RowIndex);
      int currentSupId = Convert.ToInt32(dgvSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      string currentSupName = (dgvSupplier["dataGridViewTextBoxColumn2", rowNum].Value).ToString();
      
      // Need to obtain current product ID form comboBox


      rowNum = Convert.ToInt32(dgvProdOfSupplier.CurrentCell.RowIndex);
      int currentProdId = Convert.ToInt32(dgvProdOfSupplier["dataGridViewTextBoxColumn1", rowNum].Value);
      string currentProdName = dgvProdOfSupplier[1, rowNum].Value.ToString();

      //  confirmation with user, return if user choose "No"
      if (MessageBox.Show("Are you sure the vendor " +
        currentSupName + " does not provide the " + currentProdName + " service any more?",
        "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
        return;

      var ProdSuppID = 0;
      // get the current product supplier ID
      using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
      {
        ProdSuppID = (from prod_supp in dbContext.Products_Suppliers
                          where prod_supp.ProductId == currentProdId && 
                                prod_supp.SupplierId == currentSupId
                          select prod_supp.ProductSupplierId).FirstOrDefault();
      }
        //  Delete the record from database
        try
      {
        using (TravelExpertDataDataContext dbContext = new TravelExpertDataDataContext())
        {
          var prodToBeDeleted = (from prod_supp in dbContext.Products_Suppliers
                                 where prod_supp.ProductSupplierId == ProdSuppID
                                 select prod_supp).FirstOrDefault();
          if (prodToBeDeleted != null)
          {
            dbContext.Products_Suppliers.DeleteOnSubmit(prodToBeDeleted);
            dbContext.SubmitChanges();
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error occurred, " + "please check if the deletion is in conflict " +
          "with another table (Packages, Packages_Products_Supplier, etc.): " 
          + ex.Message, ex.GetType().ToString());
      }
      //  refresh the product of supplier dataGridView and the two comboBoxes
      RefreshPordOfSuppAndLists(currentSupId);
    }

  } // end of class
} // end of namespace
