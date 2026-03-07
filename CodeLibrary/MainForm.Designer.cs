namespace CodeLibrary
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        // ★ Designer.cs 只宣告 MenuStrip 物件和選單項目
        // ★ MenuStrip 的加入由 MainForm.cs 的 BuildLayout() 負責
        // ★ 這樣可以把 MenuStrip 放進 TableLayoutPanel 的第一列，避免遮擋問題
        private void InitializeComponent()
        {
            // 只宣告，不加入 Form
            menuStrip = new System.Windows.Forms.MenuStrip
            {
                BackColor = System.Drawing.Color.FromArgb(30, 30, 46),
                ForeColor = System.Drawing.Color.White,
                Font      = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F),
                Dock      = System.Windows.Forms.DockStyle.None  // 不 Dock，由 TableLayout 控制
            };

            tsmi_File     = new System.Windows.Forms.ToolStripMenuItem("檔案(&F)");
            tsmi_Logout   = new System.Windows.Forms.ToolStripMenuItem("登出(&L)");
            tsmi_Exit     = new System.Windows.Forms.ToolStripMenuItem("離開(&X)");
            tsmi_Home     = new System.Windows.Forms.ToolStripMenuItem("首頁(&H)");
            tsmi_Examples = new System.Windows.Forms.ToolStripMenuItem("範例功能區(&E)");
            tsmi_Ex1      = new System.Windows.Forms.ToolStripMenuItem("📌 TryParse 輸入驗證");
            tsmi_Ex2      = new System.Windows.Forms.ToolStripMenuItem("📌 Lambda 與 Func");
            tsmi_Ex3      = new System.Windows.Forms.ToolStripMenuItem("📌 List 與 LINQ");
            tsmi_Ex4      = new System.Windows.Forms.ToolStripMenuItem("📌 DataGridView 操作");
            tsmi_Ex5      = new System.Windows.Forms.ToolStripMenuItem("📌 MessageBox 與 Dialog");
            tsmi_Ex6      = new System.Windows.Forms.ToolStripMenuItem("📌 Timer 計時器");
            tsmi_Ex7      = new System.Windows.Forms.ToolStripMenuItem("📌 檔案讀寫");
            tsmi_Ex8      = new System.Windows.Forms.ToolStripMenuItem("📌 JSON 序列化");
            tsmi_Practice = new System.Windows.Forms.ToolStripMenuItem("練習庫(&P)");
            tsmi_Best     = new System.Windows.Forms.ToolStripMenuItem("精選區(&B)");
            tsmi_Auth     = new System.Windows.Forms.ToolStripMenuItem("權限練習區(&A)");
            tsmi_Auth1    = new System.Windows.Forms.ToolStripMenuItem("功能1 - 基本查詢（全員）");
            tsmi_Auth2    = new System.Windows.Forms.ToolStripMenuItem("功能2 - 個人資料（全員）");
            tsmi_Auth3    = new System.Windows.Forms.ToolStripMenuItem("功能3 - 資料修改（Admin）");
            tsmi_Auth4    = new System.Windows.Forms.ToolStripMenuItem("功能4 - 資料刪除（Admin）");
            tsmi_Auth5    = new System.Windows.Forms.ToolStripMenuItem("功能5 - 系統設定（Admin）");

            tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                { tsmi_Logout, new System.Windows.Forms.ToolStripSeparator(), tsmi_Exit });

            tsmi_Examples.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                { tsmi_Ex1, tsmi_Ex2, tsmi_Ex3, tsmi_Ex4, tsmi_Ex5, tsmi_Ex6, tsmi_Ex7, tsmi_Ex8 });

            tsmi_Auth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                { tsmi_Auth1, tsmi_Auth2, tsmi_Auth3, tsmi_Auth4, tsmi_Auth5 });

            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                { tsmi_File, tsmi_Home, tsmi_Examples, tsmi_Practice, tsmi_Best, tsmi_Auth });

            // Form 基本設定（不在這裡加入任何控制項）
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize          = new System.Drawing.Size(1280, 720);
            this.MinimumSize         = new System.Drawing.Size(900, 600);
            this.Font                = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.Text                = "系統名稱 v1.0";
            this.MainMenuStrip       = menuStrip;
            this.Load               += new System.EventHandler(this.MainForm_Load);
        }

        private System.Windows.Forms.MenuStrip              menuStrip;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_File;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Logout;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Exit;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Home;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Examples;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Ex1, tsmi_Ex2, tsmi_Ex3, tsmi_Ex4;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Ex5, tsmi_Ex6, tsmi_Ex7, tsmi_Ex8;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Practice;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Best;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Auth;
        private System.Windows.Forms.ToolStripMenuItem      tsmi_Auth1, tsmi_Auth2, tsmi_Auth3, tsmi_Auth4, tsmi_Auth5;
    }
}
