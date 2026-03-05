namespace 成績計算器
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
            lblResult2.Location = new Point(51, 230);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(46, 23);
            lblResult2.TabIndex = 0;
            lblResult2.Text = "結果";
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(326, 122);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(150, 30);
            txtScore2.TabIndex = 1;
            txtScore2.KeyDown += txtScore2_KeyDown_1;
            // 
            // txtScore3
            // 
            txtScore3.Location = new Point(549, 122);
            txtScore3.Name = "txtScore3";
            txtScore3.Size = new Size(150, 30);
            txtScore3.TabIndex = 2;
            txtScore3.KeyDown += txtScore3_KeyDown_1;
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(112, 122);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(150, 30);
            txtScore1.TabIndex = 3;
            txtScore1.KeyDown += txtScore1_KeyDown_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 60);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 5;
            label1.Text = "姓名";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 125);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 6;
            label2.Text = "成績";
            // 
            // bthCalCulate
            // 
            bthCalCulate.Location = new Point(308, 296);
            bthCalCulate.Name = "bthCalCulate";
            bthCalCulate.Size = new Size(112, 34);
            bthCalCulate.TabIndex = 7;
            bthCalCulate.Text = "計算";
            bthCalCulate.UseVisualStyleBackColor = true;
            bthCalCulate.Click += bthCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(112, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(61, 23);
            lblResult.TabIndex = 8;
            lblResult.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(bthCalCulate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtScore1);
            Controls.Add(txtScore3);
            Controls.Add(txtScore2);
            Controls.Add(lblResult2);
            Name = "Form1";
            Text = "結果";
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
