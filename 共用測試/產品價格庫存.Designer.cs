namespace 共用測試
{
    partial class 產品價格庫存
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAddProduct = new Button();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(787, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 57);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 98);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "stock";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(208, 129);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(85, 12);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(85, 57);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(85, 98);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(btnAddProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddProduct;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtStock;
    }
}
