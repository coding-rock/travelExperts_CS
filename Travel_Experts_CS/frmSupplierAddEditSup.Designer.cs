namespace Travel_Experts_CS
{
  partial class frmSupplierAddEditSup
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
      this.lblSupplierId = new System.Windows.Forms.Label();
      this.lblSupplierName = new System.Windows.Forms.Label();
      this.txtSupplierId = new System.Windows.Forms.TextBox();
      this.txtSupplierName = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblSupplierId
      // 
      this.lblSupplierId.AutoSize = true;
      this.lblSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSupplierId.Location = new System.Drawing.Point(38, 40);
      this.lblSupplierId.Name = "lblSupplierId";
      this.lblSupplierId.Size = new System.Drawing.Size(75, 16);
      this.lblSupplierId.TabIndex = 5;
      this.lblSupplierId.Text = "Supplier Id:";
      // 
      // lblSupplierName
      // 
      this.lblSupplierName.AutoSize = true;
      this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSupplierName.Location = new System.Drawing.Point(12, 78);
      this.lblSupplierName.Name = "lblSupplierName";
      this.lblSupplierName.Size = new System.Drawing.Size(101, 16);
      this.lblSupplierName.TabIndex = 6;
      this.lblSupplierName.Text = "Supplier Name:";
      // 
      // txtSupplierId
      // 
      this.txtSupplierId.Enabled = false;
      this.txtSupplierId.Location = new System.Drawing.Point(132, 39);
      this.txtSupplierId.Name = "txtSupplierId";
      this.txtSupplierId.ReadOnly = true;
      this.txtSupplierId.Size = new System.Drawing.Size(185, 20);
      this.txtSupplierId.TabIndex = 8;
      // 
      // txtSupplierName
      // 
      this.txtSupplierName.Location = new System.Drawing.Point(132, 77);
      this.txtSupplierName.Name = "txtSupplierName";
      this.txtSupplierName.Size = new System.Drawing.Size(185, 20);
      this.txtSupplierName.TabIndex = 9;
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(41, 119);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(95, 49);
      this.btnSave.TabIndex = 10;
      this.btnSave.Text = "&SAVE";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(190, 119);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(95, 49);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "&CANCEL";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 16);
      this.label1.TabIndex = 12;
      this.label1.Text = "Add / Edit Supplier";
      // 
      // frmSupplierAddEditSup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(329, 180);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtSupplierName);
      this.Controls.Add(this.txtSupplierId);
      this.Controls.Add(this.lblSupplierName);
      this.Controls.Add(this.lblSupplierId);
      this.Name = "frmSupplierAddEditSup";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmSupplierAddEditSup_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblSupplierId;
    private System.Windows.Forms.Label lblSupplierName;
    private System.Windows.Forms.TextBox txtSupplierId;
    private System.Windows.Forms.TextBox txtSupplierName;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label label1;
  }
}