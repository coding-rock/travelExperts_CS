namespace Travel_Experts_CS
{
  partial class frmProduct
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.productDataGridView = new System.Windows.Forms.DataGridView();
      this.btnNewProduct = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnEdit = new System.Windows.Forms.Button();
      this.SupplierInGridView = new System.Windows.Forms.DataGridView();
      this.SupplierOutGridView = new System.Windows.Forms.DataGridView();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblSupplierIn = new System.Windows.Forms.Label();
      this.lblSupplierOut = new System.Windows.Forms.Label();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SupplierInGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SupplierOutGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // productDataGridView
      // 
      this.productDataGridView.AllowUserToAddRows = false;
      this.productDataGridView.AllowUserToDeleteRows = false;
      this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.productDataGridView.Location = new System.Drawing.Point(26, 32);
      this.productDataGridView.Name = "productDataGridView";
      this.productDataGridView.ReadOnly = true;
      this.productDataGridView.RowHeadersVisible = false;
      this.productDataGridView.Size = new System.Drawing.Size(295, 200);
      this.productDataGridView.TabIndex = 1;
      this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
      // 
      // btnNewProduct
      // 
      this.btnNewProduct.Location = new System.Drawing.Point(372, 69);
      this.btnNewProduct.Name = "btnNewProduct";
      this.btnNewProduct.Size = new System.Drawing.Size(121, 23);
      this.btnNewProduct.TabIndex = 2;
      this.btnNewProduct.Text = "&New  Product";
      this.btnNewProduct.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 16);
      this.label1.TabIndex = 3;
      this.label1.Text = "Product List";
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(372, 129);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(121, 23);
      this.btnEdit.TabIndex = 4;
      this.btnEdit.Text = "&Edit  Product";
      this.btnEdit.UseVisualStyleBackColor = true;
      // 
      // SupplierInGridView
      // 
      this.SupplierInGridView.AllowUserToAddRows = false;
      this.SupplierInGridView.AllowUserToDeleteRows = false;
      this.SupplierInGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SupplierInGridView.Location = new System.Drawing.Point(26, 286);
      this.SupplierInGridView.Name = "SupplierInGridView";
      this.SupplierInGridView.ReadOnly = true;
      this.SupplierInGridView.RowHeadersVisible = false;
      this.SupplierInGridView.Size = new System.Drawing.Size(256, 201);
      this.SupplierInGridView.TabIndex = 5;
      this.SupplierInGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierInGridView_CellClick);
      // 
      // SupplierOutGridView
      // 
      this.SupplierOutGridView.AllowUserToAddRows = false;
      this.SupplierOutGridView.AllowUserToDeleteRows = false;
      this.SupplierOutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SupplierOutGridView.Location = new System.Drawing.Point(372, 286);
      this.SupplierOutGridView.Name = "SupplierOutGridView";
      this.SupplierOutGridView.ReadOnly = true;
      this.SupplierOutGridView.RowHeadersVisible = false;
      this.SupplierOutGridView.Size = new System.Drawing.Size(256, 201);
      this.SupplierOutGridView.TabIndex = 6;
      this.SupplierOutGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierOutGridView_CellClick);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(553, 129);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblSupplierIn
      // 
      this.lblSupplierIn.Location = new System.Drawing.Point(26, 249);
      this.lblSupplierIn.Name = "lblSupplierIn";
      this.lblSupplierIn.Size = new System.Drawing.Size(256, 36);
      this.lblSupplierIn.TabIndex = 8;
      // 
      // lblSupplierOut
      // 
      this.lblSupplierOut.Location = new System.Drawing.Point(369, 249);
      this.lblSupplierOut.Name = "lblSupplierOut";
      this.lblSupplierOut.Size = new System.Drawing.Size(259, 36);
      this.lblSupplierOut.TabIndex = 9;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(288, 346);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 10;
      this.btnDelete.Text = ">>>";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(288, 406);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 11;
      this.btnAdd.Text = "<<<";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // frmProduct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(661, 505);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.lblSupplierOut);
      this.Controls.Add(this.lblSupplierIn);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.SupplierOutGridView);
      this.Controls.Add(this.SupplierInGridView);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnNewProduct);
      this.Controls.Add(this.productDataGridView);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmProduct";
      this.Text = "Products";
      this.Load += new System.EventHandler(this.frmProduct_Load);
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SupplierInGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SupplierOutGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView productDataGridView;
    private System.Windows.Forms.Button btnNewProduct;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.DataGridView SupplierInGridView;
    private System.Windows.Forms.DataGridView SupplierOutGridView;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblSupplierIn;
    private System.Windows.Forms.Label lblSupplierOut;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnAdd;
  }
}