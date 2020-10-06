namespace Travel_Experts_CS
{
  partial class frmPackage
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
      System.Windows.Forms.Label pkgDescLabel1;
      System.Windows.Forms.Label packageIdLabel;
      System.Windows.Forms.Label pkgAgencyCommissionLabel;
      System.Windows.Forms.Label pkgBasePriceLabel;
      System.Windows.Forms.Label pkgEndDateLabel;
      System.Windows.Forms.Label pkgNameLabel;
      System.Windows.Forms.Label pkgStartDateLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackage));
      this.txtPackageDesc = new System.Windows.Forms.Label();
      this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.packageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
      this.packageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.txtPackageID = new System.Windows.Forms.TextBox();
      this.txtPackageComm = new System.Windows.Forms.TextBox();
      this.txtPackagePrice = new System.Windows.Forms.TextBox();
      this.txtPackageEnd = new System.Windows.Forms.TextBox();
      this.txtPackageName = new System.Windows.Forms.TextBox();
      this.txtPackageStart = new System.Windows.Forms.TextBox();
      this.boxPPS = new System.Windows.Forms.GroupBox();
      this.btnAddPPS = new System.Windows.Forms.Button();
      this.PPSDataGridView = new System.Windows.Forms.DataGridView();
      this.btnDeletePPS = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      pkgDescLabel1 = new System.Windows.Forms.Label();
      packageIdLabel = new System.Windows.Forms.Label();
      pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
      pkgBasePriceLabel = new System.Windows.Forms.Label();
      pkgEndDateLabel = new System.Windows.Forms.Label();
      pkgNameLabel = new System.Windows.Forms.Label();
      pkgStartDateLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.packageBindingNavigator)).BeginInit();
      this.packageBindingNavigator.SuspendLayout();
      this.boxPPS.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PPSDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // pkgDescLabel1
      // 
      pkgDescLabel1.AutoSize = true;
      pkgDescLabel1.Location = new System.Drawing.Point(10, 127);
      pkgDescLabel1.Name = "pkgDescLabel1";
      pkgDescLabel1.Size = new System.Drawing.Size(70, 16);
      pkgDescLabel1.TabIndex = 39;
      pkgDescLabel1.Text = "Pkg Desc:";
      // 
      // packageIdLabel
      // 
      packageIdLabel.AutoSize = true;
      packageIdLabel.Location = new System.Drawing.Point(10, 61);
      packageIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      packageIdLabel.Name = "packageIdLabel";
      packageIdLabel.Size = new System.Drawing.Size(80, 16);
      packageIdLabel.TabIndex = 26;
      packageIdLabel.Text = "Package Id:";
      // 
      // pkgAgencyCommissionLabel
      // 
      pkgAgencyCommissionLabel.AutoSize = true;
      pkgAgencyCommissionLabel.Location = new System.Drawing.Point(10, 272);
      pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
      pkgAgencyCommissionLabel.Size = new System.Drawing.Size(161, 16);
      pkgAgencyCommissionLabel.TabIndex = 28;
      pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
      // 
      // pkgBasePriceLabel
      // 
      pkgBasePriceLabel.AutoSize = true;
      pkgBasePriceLabel.Location = new System.Drawing.Point(10, 221);
      pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      pkgBasePriceLabel.Name = "pkgBasePriceLabel";
      pkgBasePriceLabel.Size = new System.Drawing.Size(104, 16);
      pkgBasePriceLabel.TabIndex = 31;
      pkgBasePriceLabel.Text = "Pkg Base Price:";
      // 
      // pkgEndDateLabel
      // 
      pkgEndDateLabel.AutoSize = true;
      pkgEndDateLabel.Location = new System.Drawing.Point(10, 362);
      pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      pkgEndDateLabel.Name = "pkgEndDateLabel";
      pkgEndDateLabel.Size = new System.Drawing.Size(94, 16);
      pkgEndDateLabel.TabIndex = 33;
      pkgEndDateLabel.Text = "Pkg End Date:";
      // 
      // pkgNameLabel
      // 
      pkgNameLabel.AutoSize = true;
      pkgNameLabel.Location = new System.Drawing.Point(10, 92);
      pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      pkgNameLabel.Name = "pkgNameLabel";
      pkgNameLabel.Size = new System.Drawing.Size(75, 16);
      pkgNameLabel.TabIndex = 35;
      pkgNameLabel.Text = "Pkg Name:";
      // 
      // pkgStartDateLabel
      // 
      pkgStartDateLabel.AutoSize = true;
      pkgStartDateLabel.Location = new System.Drawing.Point(10, 322);
      pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      pkgStartDateLabel.Name = "pkgStartDateLabel";
      pkgStartDateLabel.Size = new System.Drawing.Size(97, 16);
      pkgStartDateLabel.TabIndex = 37;
      pkgStartDateLabel.Text = "Pkg Start Date:";
      // 
      // txtPackageDesc
      // 
      this.txtPackageDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPackageDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
      this.txtPackageDesc.Enabled = false;
      this.txtPackageDesc.Location = new System.Drawing.Point(109, 126);
      this.txtPackageDesc.Name = "txtPackageDesc";
      this.txtPackageDesc.Size = new System.Drawing.Size(241, 67);
      this.txtPackageDesc.TabIndex = 40;
      // 
      // packageBindingSource
      // 
      this.packageBindingSource.DataSource = typeof(Travel_Experts_CS.Package);
      // 
      // packageBindingNavigator
      // 
      this.packageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.packageBindingNavigator.BindingSource = this.packageBindingSource;
      this.packageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.packageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.packageBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
      this.packageBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.packageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.packageBindingNavigatorSaveItem});
      this.packageBindingNavigator.Location = new System.Drawing.Point(3, 9);
      this.packageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.packageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.packageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.packageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.packageBindingNavigator.Name = "packageBindingNavigator";
      this.packageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.packageBindingNavigator.Size = new System.Drawing.Size(303, 30);
      this.packageBindingNavigator.TabIndex = 30;
      this.packageBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 27);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 27);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 27);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 27);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 27);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(62, 30);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 27);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 27);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
      // 
      // packageBindingNavigatorSaveItem
      // 
      this.packageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.packageBindingNavigatorSaveItem.Enabled = false;
      this.packageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("packageBindingNavigatorSaveItem.Image")));
      this.packageBindingNavigatorSaveItem.Name = "packageBindingNavigatorSaveItem";
      this.packageBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 27);
      this.packageBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // txtPackageID
      // 
      this.txtPackageID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
      this.txtPackageID.Enabled = false;
      this.txtPackageID.Location = new System.Drawing.Point(224, 54);
      this.txtPackageID.Margin = new System.Windows.Forms.Padding(4);
      this.txtPackageID.Name = "txtPackageID";
      this.txtPackageID.Size = new System.Drawing.Size(124, 22);
      this.txtPackageID.TabIndex = 27;
      this.txtPackageID.TextChanged += new System.EventHandler(this.txtPackageID_TextChanged);
      // 
      // txtPackageComm
      // 
      this.txtPackageComm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
      this.txtPackageComm.Enabled = false;
      this.txtPackageComm.Location = new System.Drawing.Point(226, 269);
      this.txtPackageComm.Margin = new System.Windows.Forms.Padding(4);
      this.txtPackageComm.Name = "txtPackageComm";
      this.txtPackageComm.Size = new System.Drawing.Size(124, 22);
      this.txtPackageComm.TabIndex = 29;
      // 
      // txtPackagePrice
      // 
      this.txtPackagePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
      this.txtPackagePrice.Enabled = false;
      this.txtPackagePrice.Location = new System.Drawing.Point(226, 214);
      this.txtPackagePrice.Margin = new System.Windows.Forms.Padding(4);
      this.txtPackagePrice.Name = "txtPackagePrice";
      this.txtPackagePrice.Size = new System.Drawing.Size(124, 22);
      this.txtPackagePrice.TabIndex = 32;
      // 
      // txtPackageEnd
      // 
      this.txtPackageEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgEndDate", true));
      this.txtPackageEnd.Enabled = false;
      this.txtPackageEnd.Location = new System.Drawing.Point(226, 359);
      this.txtPackageEnd.Margin = new System.Windows.Forms.Padding(4);
      this.txtPackageEnd.Name = "txtPackageEnd";
      this.txtPackageEnd.Size = new System.Drawing.Size(229, 22);
      this.txtPackageEnd.TabIndex = 34;
      // 
      // txtPackageName
      // 
      this.txtPackageName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
      this.txtPackageName.Enabled = false;
      this.txtPackageName.Location = new System.Drawing.Point(109, 88);
      this.txtPackageName.Margin = new System.Windows.Forms.Padding(4);
      this.txtPackageName.Name = "txtPackageName";
      this.txtPackageName.Size = new System.Drawing.Size(239, 22);
      this.txtPackageName.TabIndex = 36;
      // 
      // txtPackageStart
      // 
      this.txtPackageStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgStartDate", true));
      this.txtPackageStart.Enabled = false;
      this.txtPackageStart.Location = new System.Drawing.Point(226, 319);
      this.txtPackageStart.Margin = new System.Windows.Forms.Padding(4);
      this.txtPackageStart.Name = "txtPackageStart";
      this.txtPackageStart.Size = new System.Drawing.Size(229, 22);
      this.txtPackageStart.TabIndex = 38;
      // 
      // boxPPS
      // 
      this.boxPPS.Controls.Add(this.btnAddPPS);
      this.boxPPS.Controls.Add(this.PPSDataGridView);
      this.boxPPS.Controls.Add(this.btnDeletePPS);
      this.boxPPS.Location = new System.Drawing.Point(26, 393);
      this.boxPPS.Name = "boxPPS";
      this.boxPPS.Size = new System.Drawing.Size(464, 378);
      this.boxPPS.TabIndex = 41;
      this.boxPPS.TabStop = false;
      // 
      // btnAddPPS
      // 
      this.btnAddPPS.Location = new System.Drawing.Point(78, 305);
      this.btnAddPPS.Name = "btnAddPPS";
      this.btnAddPPS.Size = new System.Drawing.Size(129, 61);
      this.btnAddPPS.TabIndex = 22;
      this.btnAddPPS.Text = "ADD PRODUCT";
      this.btnAddPPS.UseVisualStyleBackColor = true;
      this.btnAddPPS.Click += new System.EventHandler(this.btnAddPPS_Click);
      // 
      // PPSDataGridView
      // 
      this.PPSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.PPSDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.PPSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.PPSDataGridView.Location = new System.Drawing.Point(6, 16);
      this.PPSDataGridView.Name = "PPSDataGridView";
      this.PPSDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
      this.PPSDataGridView.RowTemplate.Height = 24;
      this.PPSDataGridView.Size = new System.Drawing.Size(446, 283);
      this.PPSDataGridView.TabIndex = 17;
      // 
      // btnDeletePPS
      // 
      this.btnDeletePPS.Location = new System.Drawing.Point(249, 305);
      this.btnDeletePPS.Name = "btnDeletePPS";
      this.btnDeletePPS.Size = new System.Drawing.Size(129, 61);
      this.btnDeletePPS.TabIndex = 25;
      this.btnDeletePPS.Text = "DELETE PRODUCT";
      this.btnDeletePPS.UseVisualStyleBackColor = true;
      this.btnDeletePPS.Click += new System.EventHandler(this.btnDeletePPS_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(380, 41);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(133, 61);
      this.btnAdd.TabIndex = 42;
      this.btnAdd.Text = "ADD";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(380, 126);
      this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(133, 61);
      this.btnEdit.TabIndex = 43;
      this.btnEdit.Text = "EDIT";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(380, 214);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(133, 61);
      this.btnDelete.TabIndex = 44;
      this.btnDelete.Text = "DELETE";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // frmPackage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 783);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(pkgDescLabel1);
      this.Controls.Add(this.txtPackageDesc);
      this.Controls.Add(this.packageBindingNavigator);
      this.Controls.Add(packageIdLabel);
      this.Controls.Add(this.txtPackageID);
      this.Controls.Add(pkgAgencyCommissionLabel);
      this.Controls.Add(this.txtPackageComm);
      this.Controls.Add(pkgBasePriceLabel);
      this.Controls.Add(this.txtPackagePrice);
      this.Controls.Add(pkgEndDateLabel);
      this.Controls.Add(this.txtPackageEnd);
      this.Controls.Add(pkgNameLabel);
      this.Controls.Add(this.txtPackageName);
      this.Controls.Add(pkgStartDateLabel);
      this.Controls.Add(this.txtPackageStart);
      this.Controls.Add(this.boxPPS);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmPackage";
      this.Text = "frmPackage";
      this.Activated += new System.EventHandler(this.frmPackage_Activated);
      this.Load += new System.EventHandler(this.frmPackage_Load);
      ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.packageBindingNavigator)).EndInit();
      this.packageBindingNavigator.ResumeLayout(false);
      this.packageBindingNavigator.PerformLayout();
      this.boxPPS.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PPSDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label txtPackageDesc;
    private System.Windows.Forms.BindingNavigator packageBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton packageBindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox txtPackageID;
    private System.Windows.Forms.TextBox txtPackageComm;
    private System.Windows.Forms.TextBox txtPackagePrice;
    private System.Windows.Forms.TextBox txtPackageEnd;
    private System.Windows.Forms.TextBox txtPackageName;
    private System.Windows.Forms.TextBox txtPackageStart;
    private System.Windows.Forms.GroupBox boxPPS;
    private System.Windows.Forms.Button btnAddPPS;
    private System.Windows.Forms.Button btnDeletePPS;
    private System.Windows.Forms.DataGridView PPSDataGridView;
    private System.Windows.Forms.BindingSource packageBindingSource;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
  }
}