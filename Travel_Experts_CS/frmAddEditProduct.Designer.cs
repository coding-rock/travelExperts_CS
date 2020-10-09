namespace Travel_Experts_CS
{
  partial class frmAddEditProduct
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
      System.Windows.Forms.Label prodNameLabel;
      System.Windows.Forms.Label productIdLabel;
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.prodNameTextBox = new System.Windows.Forms.TextBox();
      this.productIdTextBox = new System.Windows.Forms.TextBox();
      prodNameLabel = new System.Windows.Forms.Label();
      productIdLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // prodNameLabel
      // 
      prodNameLabel.AutoSize = true;
      prodNameLabel.Location = new System.Drawing.Point(10, 53);
      prodNameLabel.Name = "prodNameLabel";
      prodNameLabel.Size = new System.Drawing.Size(98, 20);
      prodNameLabel.TabIndex = 7;
      prodNameLabel.Text = "Prod Name:";
      // 
      // productIdLabel
      // 
      productIdLabel.AutoSize = true;
      productIdLabel.Location = new System.Drawing.Point(10, 15);
      productIdLabel.Name = "productIdLabel";
      productIdLabel.Size = new System.Drawing.Size(90, 20);
      productIdLabel.TabIndex = 9;
      productIdLabel.Text = "Product Id:";
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(206, 86);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 12;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(13, 86);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 11;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // prodNameTextBox
      // 
      this.prodNameTextBox.Location = new System.Drawing.Point(96, 50);
      this.prodNameTextBox.Name = "prodNameTextBox";
      this.prodNameTextBox.Size = new System.Drawing.Size(185, 26);
      this.prodNameTextBox.TabIndex = 8;
      this.prodNameTextBox.Tag = "Product Name";
      // 
      // productIdTextBox
      // 
      this.productIdTextBox.Location = new System.Drawing.Point(96, 12);
      this.productIdTextBox.Name = "productIdTextBox";
      this.productIdTextBox.ReadOnly = true;
      this.productIdTextBox.Size = new System.Drawing.Size(185, 26);
      this.productIdTextBox.TabIndex = 10;
      // 
      // frmAddEditProduct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(309, 127);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(prodNameLabel);
      this.Controls.Add(this.prodNameTextBox);
      this.Controls.Add(productIdLabel);
      this.Controls.Add(this.productIdTextBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmAddEditProduct";
      this.Text = "frmAddEditProduct";
      this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox prodNameTextBox;
    private System.Windows.Forms.TextBox productIdTextBox;
  }
}