namespace CodeLibrary
{
    partial class UC_成績等第計算器
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            lblResult = new Label();
            label2 = new Label();
            label1 = new Label();
            lblResult2 = new Label();
            txtName = new TextBox();
            txtScore1 = new TextBox();
            txtScore3 = new TextBox();
            txtScore2 = new TextBox();
            bthCalCulate = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(599, 352);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(61, 23);
            lblResult.TabIndex = 12;
            lblResult.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(537, 248);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 11;
            label2.Text = "成績";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 182);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 10;
            label1.Text = "姓名";
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.Location = new Point(537, 352);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(46, 23);
            lblResult2.TabIndex = 9;
            lblResult2.Text = "結果";
            // 
            // txtName
            // 
            txtName.Location = new Point(599, 182);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 13;
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(599, 245);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(150, 30);
            txtScore1.TabIndex = 16;
            // 
            // txtScore3
            // 
            txtScore3.Location = new Point(1035, 245);
            txtScore3.Name = "txtScore3";
            txtScore3.Size = new Size(150, 30);
            txtScore3.TabIndex = 15;
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(812, 245);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(150, 30);
            txtScore2.TabIndex = 14;
            // 
            // bthCalCulate
            // 
            bthCalCulate.Location = new Point(850, 444);
            bthCalCulate.Name = "bthCalCulate";
            bthCalCulate.Size = new Size(112, 34);
            bthCalCulate.TabIndex = 17;
            bthCalCulate.Text = "計算";
            bthCalCulate.UseVisualStyleBackColor = true;
            bthCalCulate.Click += bthCalCulate_Click;
            // 
            // UC_成績等第計算器
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bthCalCulate);
            Controls.Add(txtName);
            Controls.Add(txtScore1);
            Controls.Add(txtScore3);
            Controls.Add(txtScore2);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult2);
            Margin = new Padding(5);
            Name = "UC_成績等第計算器";
            Size = new Size(1932, 936);
            Load += UC_成績等第計算器_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Label label2;
        private Label label1;
        private Label lblResult2;
        private TextBox txtName;
        private TextBox txtScore1;
        private TextBox txtScore3;
        private TextBox txtScore2;
        private Button bthCalCulate;
    }
}
