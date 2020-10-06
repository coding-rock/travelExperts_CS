namespace Travel_Experts_CS
{
  partial class frmAddEditPackage
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.dtpEnd = new System.Windows.Forms.DateTimePicker();
      this.dtpStart = new System.Windows.Forms.DateTimePicker();
      this.txtPkgCom = new System.Windows.Forms.TextBox();
      this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
      this.txtPkgDesc = new System.Windows.Forms.TextBox();
      this.txtPkgName = new System.Windows.Forms.TextBox();
      this.txtPackageID = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(355, 460);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(161, 76);
      this.btnCancel.TabIndex = 36;
      this.btnCancel.Text = "CANCEL";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(124, 460);
      this.btnSave.Margin = new System.Windows.Forms.Padding(4);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(161, 76);
      this.btnSave.TabIndex = 35;
      this.btnSave.Text = "SAVE";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // dtpEnd
      // 
      this.dtpEnd.Location = new System.Drawing.Point(180, 400);
      this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
      this.dtpEnd.Name = "dtpEnd";
      this.dtpEnd.Size = new System.Drawing.Size(434, 23);
      this.dtpEnd.TabIndex = 34;
      // 
      // dtpStart
      // 
      this.dtpStart.Location = new System.Drawing.Point(180, 344);
      this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
      this.dtpStart.Name = "dtpStart";
      this.dtpStart.Size = new System.Drawing.Size(434, 23);
      this.dtpStart.TabIndex = 33;
      // 
      // txtPkgCom
      // 
      this.txtPkgCom.Location = new System.Drawing.Point(276, 292);
      this.txtPkgCom.Margin = new System.Windows.Forms.Padding(4);
      this.txtPkgCom.Name = "txtPkgCom";
      this.txtPkgCom.Size = new System.Drawing.Size(124, 23);
      this.txtPkgCom.TabIndex = 32;
      // 
      // txtPkgBasePrice
      // 
      this.txtPkgBasePrice.Location = new System.Drawing.Point(276, 232);
      this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(4);
      this.txtPkgBasePrice.Name = "txtPkgBasePrice";
      this.txtPkgBasePrice.Size = new System.Drawing.Size(124, 23);
      this.txtPkgBasePrice.TabIndex = 31;
      // 
      // txtPkgDesc
      // 
      this.txtPkgDesc.Location = new System.Drawing.Point(238, 120);
      this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(4);
      this.txtPkgDesc.Multiline = true;
      this.txtPkgDesc.Name = "txtPkgDesc";
      this.txtPkgDesc.Size = new System.Drawing.Size(376, 90);
      this.txtPkgDesc.TabIndex = 30;
      // 
      // txtPkgName
      // 
      this.txtPkgName.Location = new System.Drawing.Point(238, 75);
      this.txtPkgName.Margin = new System.Windows.Forms.Padding(4);
      this.txtPkgName.Name = "txtPkgName";
      this.txtPkgName.Size = new System.Drawing.Size(376, 23);
      this.txtPkgName.TabIndex = 29;
      // 
      // txtPackageID
      // 
      this.txtPackageID.Enabled = false;
      this.txtPackageID.Location = new System.Drawing.Point(238, 21);
      this.txtPackageID.Margin = new System.Windows.Forms.Padding(4);
      this.txtPackageID.Name = "txtPackageID";
      this.txtPackageID.Size = new System.Drawing.Size(124, 23);
      this.txtPackageID.TabIndex = 28;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(21, 400);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(71, 17);
      this.label7.TabIndex = 27;
      this.label7.Text = "End Date:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(21, 344);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(76, 17);
      this.label6.TabIndex = 26;
      this.label6.Text = "Start Date:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(21, 292);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(160, 17);
      this.label5.TabIndex = 25;
      this.label5.Text = "Agency Commission ($):";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(21, 236);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(102, 17);
      this.label4.TabIndex = 24;
      this.label4.Text = "Base Price ($):";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 124);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 17);
      this.label3.TabIndex = 23;
      this.label3.Text = "Description:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 75);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 17);
      this.label2.TabIndex = 22;
      this.label2.Text = "Name:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 21);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 17);
      this.label1.TabIndex = 21;
      this.label1.Text = "Package ID:";
      // 
      // frmAddEditPackage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 547);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.dtpEnd);
      this.Controls.Add(this.dtpStart);
      this.Controls.Add(this.txtPkgCom);
      this.Controls.Add(this.txtPkgBasePrice);
      this.Controls.Add(this.txtPkgDesc);
      this.Controls.Add(this.txtPkgName);
      this.Controls.Add(this.txtPackageID);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmAddEditPackage";
      this.Text = "frmAddEditPackage";
      this.Load += new System.EventHandler(this.frmAddEditPackage_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DateTimePicker dtpEnd;
    private System.Windows.Forms.DateTimePicker dtpStart;
    private System.Windows.Forms.TextBox txtPkgCom;
    private System.Windows.Forms.TextBox txtPkgBasePrice;
    private System.Windows.Forms.TextBox txtPkgDesc;
    private System.Windows.Forms.TextBox txtPkgName;
    private System.Windows.Forms.TextBox txtPackageID;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}