namespace Travel_Experts_CS
{
  partial class frmPackProdSupp
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
      this.txtPackageName = new System.Windows.Forms.TextBox();
      this.txtPackageID = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cbSuppliers = new System.Windows.Forms.ComboBox();
      this.cbProducts = new System.Windows.Forms.ComboBox();
      this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // txtPackageName
      // 
      this.txtPackageName.Enabled = false;
      this.txtPackageName.Location = new System.Drawing.Point(154, 52);
      this.txtPackageName.Name = "txtPackageName";
      this.txtPackageName.Size = new System.Drawing.Size(194, 22);
      this.txtPackageName.TabIndex = 41;
      // 
      // txtPackageID
      // 
      this.txtPackageID.Enabled = false;
      this.txtPackageID.Location = new System.Drawing.Point(24, 52);
      this.txtPackageID.Name = "txtPackageID";
      this.txtPackageID.Size = new System.Drawing.Size(100, 22);
      this.txtPackageID.TabIndex = 40;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(150, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 17);
      this.label1.TabIndex = 39;
      this.label1.Text = "Package Name";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(20, 18);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(80, 17);
      this.label7.TabIndex = 38;
      this.label7.Text = "Package ID";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(20, 104);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(64, 17);
      this.label6.TabIndex = 37;
      this.label6.Text = "Products";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(20, 165);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(67, 17);
      this.label5.TabIndex = 36;
      this.label5.Text = "Suppliers";
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(219, 240);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(129, 61);
      this.btnCancel.TabIndex = 35;
      this.btnCancel.Text = "CANCEL";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(59, 240);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(129, 61);
      this.btnSave.TabIndex = 34;
      this.btnSave.Text = "SAVE";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(20, 165);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 17);
      this.label4.TabIndex = 33;
      this.label4.Text = "Suppliers";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(20, 104);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 17);
      this.label3.TabIndex = 32;
      this.label3.Text = "Products";
      // 
      // cbSuppliers
      // 
      this.cbSuppliers.DataSource = this.supplierBindingSource;
      this.cbSuppliers.DisplayMember = "SupName";
      this.cbSuppliers.FormattingEnabled = true;
      this.cbSuppliers.Location = new System.Drawing.Point(23, 189);
      this.cbSuppliers.Margin = new System.Windows.Forms.Padding(4);
      this.cbSuppliers.Name = "cbSuppliers";
      this.cbSuppliers.Size = new System.Drawing.Size(274, 24);
      this.cbSuppliers.TabIndex = 31;
      this.cbSuppliers.Tag = "Suppliers";
      this.cbSuppliers.ValueMember = "SupplierId";
      // 
      // cbProducts
      // 
      this.cbProducts.DataSource = this.productBindingSource;
      this.cbProducts.DisplayMember = "ProdName";
      this.cbProducts.FormattingEnabled = true;
      this.cbProducts.Location = new System.Drawing.Point(23, 128);
      this.cbProducts.Margin = new System.Windows.Forms.Padding(4);
      this.cbProducts.Name = "cbProducts";
      this.cbProducts.Size = new System.Drawing.Size(274, 24);
      this.cbProducts.TabIndex = 30;
      this.cbProducts.Tag = "Products";
      this.cbProducts.ValueMember = "ProductId";
      this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
      // 
      // productBindingSource
      // 
      this.productBindingSource.DataSource = typeof(Travel_Experts_CS.Product);
      // 
      // supplierBindingSource
      // 
      this.supplierBindingSource.DataSource = typeof(Travel_Experts_CS.Supplier);
      // 
      // frmPackProdSupp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(454, 357);
      this.Controls.Add(this.txtPackageName);
      this.Controls.Add(this.txtPackageID);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cbSuppliers);
      this.Controls.Add(this.cbProducts);
      this.Name = "frmPackProdSupp";
      this.Text = "frmPackProdSupp";
      this.Load += new System.EventHandler(this.frmPackProdSupp_Load);
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPackageName;
    private System.Windows.Forms.TextBox txtPackageID;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbSuppliers;
    private System.Windows.Forms.ComboBox cbProducts;
    private System.Windows.Forms.BindingSource productBindingSource;
    private System.Windows.Forms.BindingSource supplierBindingSource;
  }
}