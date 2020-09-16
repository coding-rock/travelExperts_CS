namespace Travel_Experts_CS
{
  partial class frmHome
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
      this.btnPackages = new System.Windows.Forms.Button();
      this.btnProduct = new System.Windows.Forms.Button();
      this.frmSupplier = new System.Windows.Forms.Button();
      this.bunExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnPackages
      // 
      this.btnPackages.Location = new System.Drawing.Point(41, 54);
      this.btnPackages.Name = "btnPackages";
      this.btnPackages.Size = new System.Drawing.Size(89, 34);
      this.btnPackages.TabIndex = 0;
      this.btnPackages.Text = "&Packages";
      this.btnPackages.UseVisualStyleBackColor = true;
      this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
      // 
      // btnProduct
      // 
      this.btnProduct.Location = new System.Drawing.Point(156, 54);
      this.btnProduct.Name = "btnProduct";
      this.btnProduct.Size = new System.Drawing.Size(89, 34);
      this.btnProduct.TabIndex = 1;
      this.btnProduct.Text = "Pro&ducts";
      this.btnProduct.UseVisualStyleBackColor = true;
      this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
      // 
      // frmSupplier
      // 
      this.frmSupplier.Location = new System.Drawing.Point(277, 54);
      this.frmSupplier.Name = "frmSupplier";
      this.frmSupplier.Size = new System.Drawing.Size(89, 34);
      this.frmSupplier.TabIndex = 2;
      this.frmSupplier.Text = "&Suppliers";
      this.frmSupplier.UseVisualStyleBackColor = true;
      this.frmSupplier.Click += new System.EventHandler(this.frmSupplier_Click);
      // 
      // bunExit
      // 
      this.bunExit.Location = new System.Drawing.Point(277, 130);
      this.bunExit.Name = "bunExit";
      this.bunExit.Size = new System.Drawing.Size(89, 34);
      this.bunExit.TabIndex = 3;
      this.bunExit.Text = "&Exit";
      this.bunExit.UseVisualStyleBackColor = true;
      this.bunExit.Click += new System.EventHandler(this.bunExit_Click);
      // 
      // frmHome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(412, 197);
      this.Controls.Add(this.bunExit);
      this.Controls.Add(this.frmSupplier);
      this.Controls.Add(this.btnProduct);
      this.Controls.Add(this.btnPackages);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmHome";
      this.Text = "Travel Experts Desktop";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnPackages;
    private System.Windows.Forms.Button btnProduct;
    private System.Windows.Forms.Button frmSupplier;
    private System.Windows.Forms.Button bunExit;
  }
}

