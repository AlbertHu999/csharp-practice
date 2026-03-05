namespace 共用測試
{
    partial class HelloWinForm
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            bthGreet = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(202, 62);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(72, 37);
            button1.TabIndex = 0;
            button1.Text = "點我";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(212, 134);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 1;
            label1.Text = "等待點擊";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 33);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 2;
            // 
            // bthGreet
            // 
            bthGreet.Location = new Point(293, 62);
            bthGreet.Margin = new Padding(2);
            bthGreet.Name = "bthGreet";
            bthGreet.Size = new Size(81, 37);
            bthGreet.TabIndex = 3;
            bthGreet.Text = "打招呼";
            bthGreet.UseVisualStyleBackColor = true;
            bthGreet.Click += bthGreet_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 186);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(106, 40);
            button2.TabIndex = 4;
            button2.Text = "Git測試";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HelloWinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(568, 369);
            Controls.Add(button2);
            Controls.Add(bthGreet);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "HelloWinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelloWorld";
            Load += HelloWinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button bthGreet;
        private Button button2;
    }
}
