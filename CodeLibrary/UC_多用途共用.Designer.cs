namespace CodeLibrary
{
    partial class UC_多用途共用
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
            TxtResult = new TextBox();
            BtnSB = new Button();
            BtnForeach = new Button();
            TxtNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 180);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(2339, 551);
            TxtResult.TabIndex = 1;
            TxtResult.TextChanged += textBox1_TextChanged;
            // 
            // BtnSB
            // 
            BtnSB.Location = new Point(12, 140);
            BtnSB.Name = "BtnSB";
            BtnSB.Size = new Size(112, 34);
            BtnSB.TabIndex = 2;
            BtnSB.Text = "BtnSB";
            BtnSB.UseVisualStyleBackColor = true;
            BtnSB.Click += BtnSB_Click;
            // 
            // BtnForeach
            // 
            BtnForeach.Location = new Point(130, 140);
            BtnForeach.Name = "BtnForeach";
            BtnForeach.Size = new Size(137, 34);
            BtnForeach.TabIndex = 3;
            BtnForeach.Text = "BtnForeach";
            BtnForeach.UseVisualStyleBackColor = true;
            BtnForeach.Click += BtnForeach_Click;
            // 
            // TxtNumber
            // 
            TxtNumber.Location = new Point(177, 78);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(90, 30);
            TxtNumber.TabIndex = 4;
            TxtNumber.TextChanged += TxtNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            label1.Text = "九九乘法表";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 6;
            label2.Text = "數字幾的乘法表";
            // 
            // UC_多用途共用
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNumber);
            Controls.Add(BtnForeach);
            Controls.Add(BtnSB);
            Controls.Add(TxtResult);
            Name = "UC_多用途共用";
            Size = new Size(2368, 787);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtResult;
        private Button BtnSB;
        private Button BtnForeach;
        private TextBox TxtNumber;
        private Label label1;
        private Label label2;
    }
}
