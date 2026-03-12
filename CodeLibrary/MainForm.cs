using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodeLibrary
{
    public partial class MainForm : Form
    {
        private readonly Panel contentPanel = new();
        private readonly Label lblStatus    = new();

        public MainForm()
        {
            InitializeComponent();  // 宣告 MenuStrip 和選單項目
            BuildLayout();          // 把 MenuStrip + 內容區 + 狀態列放進 TableLayout
            SetPermissions();
            ShowHomePage();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        // ═══════════════════════════════════════════════════════
        // 核心版面：三列 TableLayoutPanel
        //   列0：MenuStrip（固定高度）
        //   列1：內容區（填滿）
        //   列2：狀態列（固定高度）
        //
        // MenuStrip 放在 TableLayout 的列0，跟內容區完全隔開
        // 不用 Dock=Top，徹底避免遮擋問題
        // ═══════════════════════════════════════════════════════
        private void BuildLayout()
        {
            var main = new TableLayoutPanel
            {
                Dock        = DockStyle.Fill,
                RowCount    = 3,
                ColumnCount = 1,
                Padding     = new Padding(0),
                BackColor   = Color.FromArgb(245, 247, 250)
            };
            main.RowStyles.Add(new RowStyle(SizeType.AutoSize));         // 列0：MenuStrip（自動高度）
            main.RowStyles.Add(new RowStyle(SizeType.Percent,  100));    // 列1：內容區
            main.RowStyles.Add(new RowStyle(SizeType.Absolute,  26));    // 列2：狀態列

            // 列0：MenuStrip（Dock=Fill 填滿這一列）
            menuStrip.Dock = DockStyle.Fill;

            // 列1：內容區
            contentPanel.Dock      = DockStyle.Fill;
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Padding   = new Padding(0);

            // 列2：狀態列
            var statusBar = new Panel
            {
                Dock      = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 46),
                Padding   = new Padding(12, 0, 0, 0)
            };
            lblStatus.Dock      = DockStyle.Fill;
            lblStatus.Font      = new Font("Microsoft JhengHei UI", 9);
            lblStatus.ForeColor = Color.FromArgb(180, 180, 200);
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            statusBar.Controls.Add(lblStatus);

            main.Controls.Add(menuStrip,     0, 0);
            main.Controls.Add(contentPanel,  0, 1);
            main.Controls.Add(statusBar,     0, 2);

            this.Controls.Add(main);
            BindMenu();
        }

        private void SetPermissions()
        {
            if (!AppSession.IsAdmin)
            {
                tsmi_Auth3.Visible = false;
                tsmi_Auth4.Visible = false;
                tsmi_Auth5.Visible = false;
            }
        }

        private void Show(UserControl uc, string name)
        {
            contentPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(uc);
            lblStatus.Text = $"{name}　使用者：{AppSession.CurrentUser.ToUpper()}　{DateTime.Now:yyyy/MM/dd HH:mm}";
        }

        private void BindMenu()
        {
            tsmi_Home.Click += (s, e) => ShowHomePage();

            tsmi_Ex1.Click += (s, e) => Show(new UC_Ex_TryParse(), "TryParse 輸入驗證");
            tsmi_Ex2.Click += (s, e) => Show(new UC_Ex_Lambda(),   "Lambda 與 Func");
            tsmi_Ex3.Click += (s, e) => Show(new UC_Ex_ListLinq(), "List 與 LINQ");
            tsmi_Ex4.Click += (s, e) => Show(new UC_Ex_DataGrid(), "DataGridView 操作");
            tsmi_Ex5.Click += (s, e) => Show(new UC_Ex_Dialog(),   "MessageBox 與 Dialog");
            tsmi_Ex6.Click += (s, e) => Show(new UC_Ex_Timer(),    "Timer 計時器");
            tsmi_Ex7.Click += (s, e) => Show(new UC_Ex_FileIO(),   "檔案讀寫");
            tsmi_Ex8.Click += (s, e) => Show(new UC_Ex_Json(),     "JSON 序列化");

            // ── 練習庫 ──
            var tsmi_P1 = new ToolStripMenuItem("📝 成績等第計算器");
            tsmi_P1.Click += (s, e) => Show(new UC_成績等第計算器(), "成績等第計算器");
            tsmi_Practice.DropDownItems.Add(tsmi_P1);

            var tsmi_P2 = new ToolStripMenuItem("📝 猜數字");
            tsmi_P2.Click += (s, e) => Show(new UC_猜數字(), "猜數字");
            tsmi_Practice.DropDownItems.Add(tsmi_P2);

            var tsmi_P3 = new ToolStripMenuItem("📝 多用途共用");
            tsmi_P3.Click += (s, e) => Show(new UC_多用途共用(), "多用途共用");
            tsmi_Practice.DropDownItems.Add(tsmi_P3);
            // ── 精選區 ──
            //var tsmi_B1 = new ToolStripMenuItem("⭐ 精選功能01");
            //tsmi_B1.Click += (s, e) => Show(new UC_Best_01(), "精選功能01");
            //tsmi_Best.DropDownItems.Add(tsmi_B1);

            tsmi_Auth1.Click += (s, e) => Show(new UC_Auth_Func1(), "功能1（全員）");
            tsmi_Auth2.Click += (s, e) => Show(new UC_Auth_Func2(), "功能2（全員）");
            tsmi_Auth3.Click += (s, e) => Show(new UC_Auth_Func3(), "功能3（Admin）");
            tsmi_Auth4.Click += (s, e) => Show(new UC_Auth_Func4(), "功能4（Admin）");
            tsmi_Auth5.Click += (s, e) => Show(new UC_Auth_Func5(), "功能5（Admin）");

            tsmi_Logout.Click += (s, e) =>
            {
                if (MessageBox.Show("確定要登出嗎？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                AppSession.Logout();
                var login = new LoginForm();
                if (login.ShowDialog() == DialogResult.OK) { SetPermissions(); ShowHomePage(); }
                else Application.Exit();
            };

            tsmi_Exit.Click += (s, e) =>
            {
                if (MessageBox.Show("確定要離開嗎？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            };
        }

        private void ShowHomePage()
        {
            contentPanel.Controls.Clear();

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill, RowCount = 3, ColumnCount = 1,
                BackColor = Color.FromArgb(245, 247, 250), Padding = new Padding(0)
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute,  56));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 106));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent,  100));

            var pnlWelcome = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(24, 0, 0, 0) };
            pnlWelcome.Controls.Add(new Label
            {
                Text      = $"👋  歡迎回來，{AppSession.CurrentUser.ToUpper()}！　　角色：{AppSession.CurrentRole.ToUpper()}",
                Font      = new Font("Microsoft JhengHei UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 46),
                Dock      = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            });

            var cardFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill, BackColor = Color.FromArgb(245, 247, 250),
                Padding = new Padding(24, 16, 0, 0)
            };

            void Card(string title, string val, Color color)
            {
                var c = new Panel { Width = 176, Height = 74, Margin = new Padding(0, 0, 16, 0), BackColor = Color.White };
                var b = new Panel { Width = 5, Dock = DockStyle.Left, BackColor = color };
                var t = new Label { Text = title, Font = new Font("Microsoft JhengHei UI", 9), ForeColor = Color.FromArgb(100, 116, 139), AutoSize = false, Bounds = new Rectangle(12, 8, 156, 22), TextAlign = ContentAlignment.MiddleLeft };
                var v = new Label { Text = val, Font = new Font("Microsoft JhengHei UI", 14, FontStyle.Bold), ForeColor = color, AutoSize = false, Bounds = new Rectangle(12, 32, 156, 30), TextAlign = ContentAlignment.MiddleLeft };
                c.Controls.AddRange(new Control[] { b, t, v });
                cardFlow.Controls.Add(c);
            }

            Card("📚 範例功能區", "8 個範例",  Color.FromArgb(59,  130, 246));
            Card("🔨 練習庫",    "自行新增",   Color.FromArgb(16,  185, 129));
            Card("⭐ 精選區",    "自行新增",   Color.FromArgb(245, 158,  11));
            Card("🔐 權限練習區", AppSession.IsAdmin ? "5 個 (Admin)" : "2 個 (User)", Color.FromArgb(139, 92, 246));

            layout.Controls.Add(pnlWelcome, 0, 0);
            layout.Controls.Add(cardFlow,   0, 1);
            layout.Controls.Add(new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(245, 247, 250) }, 0, 2);

            contentPanel.Controls.Add(layout);
            lblStatus.Text = $"首頁　使用者：{AppSession.CurrentUser.ToUpper()}　{DateTime.Now:yyyy/MM/dd HH:mm}";
        }
    }
}
