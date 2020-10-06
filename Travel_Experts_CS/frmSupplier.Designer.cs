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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
      this.supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).BeginInit();
      this.supplierBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProdOfSupplier)).BeginInit();
      this.SuspendLayout();
      // 
      // supplierBindingNavigator
      // 
      this.supplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.supplierBindingNavigator.BindingSource = this.supplierBindingSource;
      this.supplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.supplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.supplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.supplierBindingNavigatorSaveItem});
      this.supplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.supplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.supplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.supplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.supplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.supplierBindingNavigator.Name = "supplierBindingNavigator";
      this.supplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.supplierBindingNavigator.Size = new System.Drawing.Size(898, 25);
      this.supplierBindingNavigator.TabIndex = 0;
      this.supplierBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // supplierBindingSource
      // 
      this.supplierBindingSource.DataSource = typeof(Travel_Experts_CS.Supplier);
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // supplierBindingNavigatorSaveItem
      // 
      this.supplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.supplierBindingNavigatorSaveItem.Enabled = false;
      this.supplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierBindingNavigatorSaveItem.Image")));
      this.supplierBindingNavigatorSaveItem.Name = "supplierBindingNavigatorSaveItem";
      this.supplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.supplierBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // dgvSupplier
      // 
      this.dgvSupplier.AutoGenerateColumns = false;
      this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dgvSupplier.DataSource = this.supplierBindingSource;
      this.dgvSupplier.Location = new System.Drawing.Point(12, 28);
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
      this.btnAddSupplier.Location = new System.Drawing.Point(537, 28);
      this.btnAddSupplier.Name = "btnAddSupplier";
      this.btnAddSupplier.Size = new System.Drawing.Size(147, 46);
      this.btnAddSupplier.TabIndex = 2;
      this.btnAddSupplier.Text = "Add Supplier";
      this.btnAddSupplier.UseVisualStyleBackColor = true;
      this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
      // 
      // btnEditSupplier
      // 
      this.btnEditSupplier.Location = new System.Drawing.Point(537, 104);
      this.btnEditSupplier.Name = "btnEditSupplier";
      this.btnEditSupplier.Size = new System.Drawing.Size(147, 46);
      this.btnEditSupplier.TabIndex = 3;
      this.btnEditSupplier.Text = "Edit Supplier";
      this.btnEditSupplier.UseVisualStyleBackColor = true;
      this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
      // 
      // btnDeleteSupplier
      // 
      this.btnDeleteSupplier.Location = new System.Drawing.Point(537, 180);
      this.btnDeleteSupplier.Name = "btnDeleteSupplier";
      this.btnDeleteSupplier.Size = new System.Drawing.Size(147, 46);
      this.btnDeleteSupplier.TabIndex = 4;
      this.btnDeleteSupplier.Text = "Delete Supplier";
      this.btnDeleteSupplier.UseVisualStyleBackColor = true;
      this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
      // 
      // dgvProdOfSupplier
      // 
      this.dgvProdOfSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProdOfSupplier.Location = new System.Drawing.Point(12, 446);
      this.dgvProdOfSupplier.Name = "dgvProdOfSupplier";
      this.dgvProdOfSupplier.Size = new System.Drawing.Size(489, 107);
      this.dgvProdOfSupplier.TabIndex = 5;
      // 
      // btnAddProd
      // 
      this.btnAddProd.Location = new System.Drawing.Point(537, 446);
      this.btnAddProd.Name = "btnAddProd";
      this.btnAddProd.Size = new System.Drawing.Size(147, 46);
      this.btnAddProd.TabIndex = 6;
      this.btnAddProd.Text = "Add Product";
      this.btnAddProd.UseVisualStyleBackColor = true;
      // 
      // btnDeleteProd
      // 
      this.btnDeleteProd.Location = new System.Drawing.Point(537, 507);
      this.btnDeleteProd.Name = "btnDeleteProd";
      this.btnDeleteProd.Size = new System.Drawing.Size(147, 46);
      this.btnDeleteProd.TabIndex = 8;
      this.btnDeleteProd.Text = "Delete Product";
      this.btnDeleteProd.UseVisualStyleBackColor = true;
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(537, 360);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(147, 46);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "&Exit Window";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // lblSupplierProdList
      // 
      this.lblSupplierProdList.AutoSize = true;
      this.lblSupplierProdList.Location = new System.Drawing.Point(12, 418);
      this.lblSupplierProdList.Name = "lblSupplierProdList";
      this.lblSupplierProdList.Size = new System.Drawing.Size(0, 16);
      this.lblSupplierProdList.TabIndex = 31;
      // 
      // frmSupplier
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(898, 565);
      this.Controls.Add(this.lblSupplierProdList);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnDeleteProd);
      this.Controls.Add(this.btnAddProd);
      this.Controls.Add(this.dgvProdOfSupplier);
      this.Controls.Add(this.btnDeleteSupplier);
      this.Controls.Add(this.btnEditSupplier);
      this.Controls.Add(this.btnAddSupplier);
      this.Controls.Add(this.dgvSupplier);
      this.Controls.Add(this.supplierBindingNavigator);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmSupplier";
      this.Text = "frmSupplier";
      this.Load += new System.EventHandler(this.frmSupplier_Load);
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).EndInit();
      this.supplierBindingNavigator.ResumeLayout(false);
      this.supplierBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProdOfSupplier)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource supplierBindingSource;
    private System.Windows.Forms.BindingNavigator supplierBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton supplierBindingNavigatorSaveItem;
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
  }
}