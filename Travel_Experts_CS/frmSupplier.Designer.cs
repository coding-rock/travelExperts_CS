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
      this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.supplierDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).BeginInit();
      this.supplierBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // supplierBindingSource
      // 
      this.supplierBindingSource.DataSource = typeof(Travel_Experts_CS.Supplier);
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
      this.supplierBindingNavigator.Size = new System.Drawing.Size(456, 25);
      this.supplierBindingNavigator.TabIndex = 0;
      this.supplierBindingNavigator.Text = "bindingNavigator1";
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
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
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
      // supplierDataGridView
      // 
      this.supplierDataGridView.AutoGenerateColumns = false;
      this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.supplierDataGridView.DataSource = this.supplierBindingSource;
      this.supplierDataGridView.Location = new System.Drawing.Point(12, 28);
      this.supplierDataGridView.Name = "supplierDataGridView";
      this.supplierDataGridView.Size = new System.Drawing.Size(300, 220);
      this.supplierDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierId";
      this.dataGridViewTextBoxColumn1.HeaderText = "SupplierId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "SupName";
      this.dataGridViewTextBoxColumn2.HeaderText = "SupName";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // frmSupplier
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(456, 337);
      this.Controls.Add(this.supplierDataGridView);
      this.Controls.Add(this.supplierBindingNavigator);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmSupplier";
      this.Text = "frmSupplier";
      this.Load += new System.EventHandler(this.frmSupplier_Load);
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).EndInit();
      this.supplierBindingNavigator.ResumeLayout(false);
      this.supplierBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
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
    private System.Windows.Forms.DataGridView supplierDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
  }
}