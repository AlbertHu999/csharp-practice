namespace CodeLibrary
{
    partial class SimpleCalculator
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSecondNumber = new TextBox();
            txtFirstNumber = new TextBox();
            btnAdd = new Button();
            bindingSource1 = new BindingSource(components);
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(327, 89);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 0;
            label1.Text = "簡易計算機";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(62, 145);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 1;
            label2.Text = "數字一";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(62, 213);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 2;
            label3.Text = "數字二";
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(165, 213);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(100, 23);
            txtSecondNumber.TabIndex = 3;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new Point(165, 146);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(100, 23);
            txtFirstNumber.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(142, 265);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 6;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(276, 265);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(402, 265);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 23);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblResult.Location = new Point(239, 362);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(48, 24);
            lblResult.TabIndex = 10;
            lblResult.Text = "結果";
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtFirstNumber);
            Controls.Add(txtSecondNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SimpleCalculator";
            Text = "SimpleCalculator";
            Load += SimpleCalculator_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSecondNumber;
        private TextBox txtFirstNumber;
        private Button btnAdd;
        private BindingSource bindingSource1;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Label lblResult;
    }
}