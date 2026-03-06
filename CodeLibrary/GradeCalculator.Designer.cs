namespace CodeLibrary
{
    partial class GradeCalculator
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
            lblResult2 = new Label();
            txtScore2 = new TextBox();
            txtScore3 = new TextBox();
            txtScore1 = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bthCalCulate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.Location = new Point(32, 150);
            lblResult2.Margin = new Padding(2, 0, 2, 0);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(31, 15);
            lblResult2.TabIndex = 0;
            lblResult2.Text = "結果";
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(207, 80);
            txtScore2.Margin = new Padding(2, 2, 2, 2);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(97, 23);
            txtScore2.TabIndex = 1;
            txtScore2.KeyDown += txtScore2_KeyDown_1;
            // 
            // txtScore3
            // 
            txtScore3.Location = new Point(349, 80);
            txtScore3.Margin = new Padding(2, 2, 2, 2);
            txtScore3.Name = "txtScore3";
            txtScore3.Size = new Size(97, 23);
            txtScore3.TabIndex = 2;
            txtScore3.KeyDown += txtScore3_KeyDown_1;
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(71, 80);
            txtScore1.Margin = new Padding(2, 2, 2, 2);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(97, 23);
            txtScore1.TabIndex = 3;
            txtScore1.KeyDown += txtScore1_KeyDown_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(71, 39);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(97, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "姓名";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "成績";
            // 
            // bthCalCulate
            // 
            bthCalCulate.Location = new Point(196, 193);
            bthCalCulate.Margin = new Padding(2, 2, 2, 2);
            bthCalCulate.Name = "bthCalCulate";
            bthCalCulate.Size = new Size(71, 22);
            bthCalCulate.TabIndex = 7;
            bthCalCulate.Text = "計算";
            bthCalCulate.UseVisualStyleBackColor = true;
            bthCalCulate.Click += bthCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(71, 150);
            lblResult.Margin = new Padding(2, 0, 2, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 8;
            lblResult.Text = "label3";
            // 
            // GradeCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 293);
            Controls.Add(lblResult);
            Controls.Add(bthCalCulate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtScore1);
            Controls.Add(txtScore3);
            Controls.Add(txtScore2);
            Controls.Add(lblResult2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "GradeCalculator";
            Text = "結果";
            Load += GradeCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult2;
        private TextBox txtScore2;
        private TextBox txtScore3;
        private TextBox txtScore1;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Button bthCalCulate;
        private Label lblResult;
    }
}
