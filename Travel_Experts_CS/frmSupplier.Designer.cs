namespace Travel_Experts_CS
{
  partial class frmSupplier
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
      this.components = new System.ComponentModel.Container();
      this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dgvSupplier = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnAddSupplier = new System.Windows.Forms.Button();
      this.btnEditSupplier = new System.Windows.Forms.Button();
      this.btnDeleteSupplier = new System.Windows.Forms.Button();
      this.dgvProdOfSupplier = new System.Windows.Forms.DataGridView();
      this.btnAddProd = new System.Windows.Forms.Button();
      this.btnDeleteProd = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.lblSupplierProdList = new System.Windows.Forms.Label();
      this.cbAddProd = new System.Windows.Forms.ComboBox();
      this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cbDeleteProd = new System.Windows.Forms.ComboBox();
      this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProdOfSupplier)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // supplierBindingSource
      // 
      this.supplierBindingSource.DataSource = typeof(Travel_Experts_CS.Supplier);
      // 
      // dgvSupplier
      // 
      this.dgvSupplier.AutoGenerateColumns = false;
      this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dgvSupplier.DataSource = this.supplierBindingSource;
      this.dgvSupplier.Location = new System.Drawing.Point(12, 12);
      this.dgvSupplier.Name = "dgvSupplier";
      this.dgvSupplier.Size = new System.Drawing.Size(489, 378);
      this.dgvSupplier.TabIndex = 1;
      this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
      this.dgvSupplier.SelectionChanged += new System.EventHandler(this.dgvSupplier_SelectionChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierId";
      this.dataGridViewTextBoxColumn1.FillWeight = 80F;
      this.dataGridViewTextBoxColumn1.HeaderText = "Supplier ID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "SupName";
      this.dataGridViewTextBoxColumn2.HeaderText = "Supplier Name";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 250;
      // 
      // btnAddSupplier
      // 
      this.btnAddSupplier.Location = new System.Drawing.Point(512, 12);
      this.btnAddSupplier.Name = "btnAddSupplier";
      this.btnAddSupplier.Size = new System.Drawing.Size(121, 46);
      this.btnAddSupplier.TabIndex = 2;
      this.btnAddSupplier.Text = "&New Supplier";
      this.btnAddSupplier.UseVisualStyleBackColor = true;
      this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
      // 
      // btnEditSupplier
      // 
      this.btnEditSupplier.Location = new System.Drawing.Point(510, 86);
      this.btnEditSupplier.Name = "btnEditSupplier";
      this.btnEditSupplier.Size = new System.Drawing.Size(123, 46);
      this.btnEditSupplier.TabIndex = 3;
      this.btnEditSupplier.Text = "Edit Supplier";
      this.btnEditSupplier.UseVisualStyleBackColor = true;
      this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
      // 
      // btnDeleteSupplier
      // 
      this.btnDeleteSupplier.Location = new System.Drawing.Point(510, 161);
      this.btnDeleteSupplier.Name = "btnDeleteSupplier";
      this.btnDeleteSupplier.Size = new System.Drawing.Size(123, 46);
      this.btnDeleteSupplier.TabIndex = 4;
      this.btnDeleteSupplier.Text = "Delete Supplier";
      this.btnDeleteSupplier.UseVisualStyleBackColor = true;
      this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
      // 
      // dgvProdOfSupplier
      // 
      this.dgvProdOfSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProdOfSupplier.Location = new System.Drawing.Point(12, 415);
      this.dgvProdOfSupplier.Name = "dgvProdOfSupplier";
      this.dgvProdOfSupplier.Size = new System.Drawing.Size(314, 121);
      this.dgvProdOfSupplier.TabIndex = 5;
      // 
      // btnAddProd
      // 
      this.btnAddProd.Location = new System.Drawing.Point(381, 399);
      this.btnAddProd.Name = "btnAddProd";
      this.btnAddProd.Size = new System.Drawing.Size(120, 32);
      this.btnAddProd.TabIndex = 6;
      this.btnAddProd.Text = "Add Product";
      this.btnAddProd.UseVisualStyleBackColor = true;
      this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
      // 
      // btnDeleteProd
      // 
      this.btnDeleteProd.Location = new System.Drawing.Point(512, 396);
      this.btnDeleteProd.Name = "btnDeleteProd";
      this.btnDeleteProd.Size = new System.Drawing.Size(123, 32);
      this.btnDeleteProd.TabIndex = 8;
      this.btnDeleteProd.Text = "Delete Product";
      this.btnDeleteProd.UseVisualStyleBackColor = true;
      this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(512, 344);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(123, 46);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "E&xit Window";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // lblSupplierProdList
      // 
      this.lblSupplierProdList.AutoSize = true;
      this.lblSupplierProdList.Location = new System.Drawing.Point(12, 396);
      this.lblSupplierProdList.Name = "lblSupplierProdList";
      this.lblSupplierProdList.Size = new System.Drawing.Size(0, 16);
      this.lblSupplierProdList.TabIndex = 31;
      // 
      // cbAddProd
      // 
      this.cbAddProd.DataSource = this.productBindingSource;
      this.cbAddProd.DisplayMember = "ProdName";
      this.cbAddProd.FormattingEnabled = true;
      this.cbAddProd.Location = new System.Drawing.Point(381, 437);
      this.cbAddProd.Name = "cbAddProd";
      this.cbAddProd.Size = new System.Drawing.Size(121, 24);
      this.cbAddProd.TabIndex = 32;
      this.cbAddProd.Tag = "Products";
      this.cbAddProd.ValueMember = "ProductId";
      this.cbAddProd.SelectedIndexChanged += new System.EventHandler(this.cbAddProd_SelectedIndexChanged);
      // 
      // productBindingSource
      // 
      this.productBindingSource.DataSource = typeof(Travel_Experts_CS.Product);
      // 
      // cbDeleteProd
      // 
      this.cbDeleteProd.DataSource = this.productBindingSource1;
      this.cbDeleteProd.DisplayMember = "ProdName";
      this.cbDeleteProd.FormattingEnabled = true;
      this.cbDeleteProd.Location = new System.Drawing.Point(512, 437);
      this.cbDeleteProd.Name = "cbDeleteProd";
      this.cbDeleteProd.Size = new System.Drawing.Size(121, 24);
      this.cbDeleteProd.TabIndex = 33;
      this.cbDeleteProd.Tag = "Products";
      this.cbDeleteProd.ValueMember = "ProductId";
      this.cbDeleteProd.SelectedIndexChanged += new System.EventHandler(this.cbDeleteProd_SelectedIndexChanged);
      // 
      // productBindingSource1
      // 
      this.productBindingSource1.DataSource = typeof(Travel_Experts_CS.Product);
      // 
      // frmSupplier
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(644, 565);
      this.Controls.Add(this.cbDeleteProd);
      this.Controls.Add(this.cbAddProd);
      this.Controls.Add(this.lblSupplierProdList);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnDeleteProd);
      this.Controls.Add(this.btnAddProd);
      this.Controls.Add(this.dgvProdOfSupplier);
      this.Controls.Add(this.btnDeleteSupplier);
      this.Controls.Add(this.btnEditSupplier);
      this.Controls.Add(this.btnAddSupplier);
      this.Controls.Add(this.dgvSupplier);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmSupplier";
      this.Text = "frmSupplier";
      this.Load += new System.EventHandler(this.frmSupplier_Load);
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProdOfSupplier)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource supplierBindingSource;
    private System.Windows.Forms.DataGridView dgvSupplier;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.Button btnAddSupplier;
    private System.Windows.Forms.Button btnEditSupplier;
    private System.Windows.Forms.Button btnDeleteSupplier;
    private System.Windows.Forms.DataGridView dgvProdOfSupplier;
    private System.Windows.Forms.Button btnAddProd;
    private System.Windows.Forms.Button btnDeleteProd;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label lblSupplierProdList;
    private System.Windows.Forms.ComboBox cbAddProd;
    private System.Windows.Forms.ComboBox cbDeleteProd;
    private System.Windows.Forms.BindingSource productBindingSource;
    private System.Windows.Forms.BindingSource productBindingSource1;
  }
}