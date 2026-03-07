namespace CodeLibrary
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // 宣告需要跨方法存取的控制項
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin    = new System.Windows.Forms.Button();
            lblError    = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ════════════════════════════
            // 左側深色區塊
            // ════════════════════════════
            var pnlLeft = new System.Windows.Forms.Panel
            {
                Dock      = System.Windows.Forms.DockStyle.Left,
                Width     = 200,
                BackColor = System.Drawing.Color.FromArgb(30, 30, 46)
            };
            var lblAppName = new System.Windows.Forms.Label
            {
                Text      = "🖥️\r\n\r\n系統\r\n名稱",
                ForeColor = System.Drawing.Color.White,
                Font      = new System.Drawing.Font("Microsoft JhengHei UI", 16, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock      = System.Windows.Forms.DockStyle.Fill
            };
            pnlLeft.Controls.Add(lblAppName);

            // ════════════════════════════
            // 右側登入區
            // ════════════════════════════
            var pnlRight = new System.Windows.Forms.Panel
            {
                Dock      = System.Windows.Forms.DockStyle.Fill,
                BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
            };

            var lblTitle = new System.Windows.Forms.Label { Text = "登入系統", Font = new System.Drawing.Font("Microsoft JhengHei UI", 18, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.FromArgb(30, 30, 46), AutoSize = true, Location = new System.Drawing.Point(40, 50) };
            var lblSub   = new System.Windows.Forms.Label { Text = "請輸入帳號與密碼", Font = new System.Drawing.Font("Microsoft JhengHei UI", 10), ForeColor = System.Drawing.Color.FromArgb(100, 116, 139), AutoSize = true, Location = new System.Drawing.Point(40, 92) };
            var lblUser  = new System.Windows.Forms.Label { Text = "帳號", Font = new System.Drawing.Font("Microsoft JhengHei UI", 10, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.FromArgb(30, 30, 46), AutoSize = true, Location = new System.Drawing.Point(40, 138) };

            txtUsername.Location    = new System.Drawing.Point(40, 160);
            txtUsername.Size        = new System.Drawing.Size(260, 28);
            txtUsername.Font        = new System.Drawing.Font("Microsoft JhengHei UI", 11);
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.KeyDown    += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);

            var lblPass = new System.Windows.Forms.Label { Text = "密碼", Font = new System.Drawing.Font("Microsoft JhengHei UI", 10, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.FromArgb(30, 30, 46), AutoSize = true, Location = new System.Drawing.Point(40, 204) };

            txtPassword.Location     = new System.Drawing.Point(40, 226);
            txtPassword.Size         = new System.Drawing.Size(260, 28);
            txtPassword.Font         = new System.Drawing.Font("Microsoft JhengHei UI", 11);
            txtPassword.PasswordChar = '●';
            txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.KeyDown     += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);

            lblError.Text      = "❌  帳號或密碼錯誤，請重新輸入";
            lblError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblError.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 9);
            lblError.AutoSize  = true;
            lblError.Location  = new System.Drawing.Point(40, 266);
            lblError.Visible   = false;

            btnLogin.Text      = "登　入";
            btnLogin.Location  = new System.Drawing.Point(40, 294);
            btnLogin.Size      = new System.Drawing.Size(260, 42);
            btnLogin.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 12, System.Drawing.FontStyle.Bold);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click    += new System.EventHandler(this.btnLogin_Click);

            var lblHint = new System.Windows.Forms.Label { Text = "預設帳號：admin / user　　密碼：空白", Font = new System.Drawing.Font("Microsoft JhengHei UI", 8), ForeColor = System.Drawing.Color.FromArgb(148, 163, 184), AutoSize = true, Location = new System.Drawing.Point(40, 350) };

            pnlRight.Controls.Add(lblTitle);
            pnlRight.Controls.Add(lblSub);
            pnlRight.Controls.Add(lblUser);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(lblPass);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(lblError);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(lblHint);

            // ★ 順序關鍵：Fill 先加，Left 後加
            this.Controls.Add(pnlRight);
            this.Controls.Add(pnlLeft);

            // Form 設定
            this.Text            = "系統登入";
            this.ClientSize      = new System.Drawing.Size(560, 420);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Font            = new System.Drawing.Font("Microsoft JhengHei UI", 10);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button  btnLogin;
        private System.Windows.Forms.Label   lblError;
    }
}
