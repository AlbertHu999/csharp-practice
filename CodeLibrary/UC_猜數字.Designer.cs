namespace CodeLibrary
{
    partial class UC_猜數字
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
            txtGuess = new TextBox();
            btnGuess = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(547, 594);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(46, 23);
            lblResult.TabIndex = 0;
            lblResult.Text = "結果";
            lblResult.Click += lblResult_Click;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(513, 380);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(150, 30);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(525, 479);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(112, 34);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "我猜";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // UC_猜數字
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblResult);
            Name = "UC_猜數字";
            Size = new Size(1142, 807);
            Load += UC_猜數字_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtGuess;
        private Button btnGuess;
    }
}
