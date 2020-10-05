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
      this.components = new System.ComponentModel.Container();
      this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.productDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnNewProduct = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // productBindingSource
      // 
      this.productBindingSource.DataSource = typeof(Travel_Experts_CS.Product);
      // 
      // productDataGridView
      // 
      this.productDataGridView.AutoGenerateColumns = false;
      this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.productDataGridView.DataSource = this.productBindingSource;
      this.productDataGridView.Location = new System.Drawing.Point(26, 50);
      this.productDataGridView.Name = "productDataGridView";
      this.productDataGridView.Size = new System.Drawing.Size(295, 220);
      this.productDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
      this.dataGridViewTextBoxColumn1.HeaderText = "ProductId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
      this.dataGridViewTextBoxColumn2.HeaderText = "ProdName";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // btnNewProduct
      // 
      this.btnNewProduct.Location = new System.Drawing.Point(381, 50);
      this.btnNewProduct.Name = "btnNewProduct";
      this.btnNewProduct.Size = new System.Drawing.Size(121, 23);
      this.btnNewProduct.TabIndex = 2;
      this.btnNewProduct.Text = "New Product";
      this.btnNewProduct.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 16);
      this.label1.TabIndex = 3;
      this.label1.Text = "Product List";
      // 
      // frmProduct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(849, 554);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnNewProduct);
      this.Controls.Add(this.productDataGridView);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmProduct";
      this.Text = "frmProduct";
      this.Load += new System.EventHandler(this.frmProduct_Load);
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource productBindingSource;
    private System.Windows.Forms.DataGridView productDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.Button btnNewProduct;
    private System.Windows.Forms.Label label1;
  }
}