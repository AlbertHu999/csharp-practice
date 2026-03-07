using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace CodeLibrary
{
    // ═══════════════════════════════════════════════════════════════
    //  UCHelper - 統一骨架
    //
    //  三列 TableLayoutPanel：
    //  列0  標題列  40px 固定
    //  列1  間距列  14px 固定（用 Panel 撐，不靠 Padding，任何 DPI 都一樣）
    //  列2  內容區  填滿剩餘空間
    //
    //  ★ 新增 UC 範本：
    //  public class UC_我的功能 : UserControl
    //  {
    //      public UC_我的功能()
    //      {
    //          this.Dock = DockStyle.Fill;
    //          var work = UCHelper.MakeLayout(this, "📌 標題", Color.FromArgb(59,130,246));
    //          // 在 work 裡放控制項，從 new Point(0, 0) 開始就好
    //      }
    //  }
    // ═══════════════════════════════════════════════════════════════
    public static class UCHelper
    {
        public static Panel MakeLayout(UserControl uc, string title, Color accent)
        {
            var tbl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill, RowCount = 3, ColumnCount = 1,
                BackColor = Color.FromArgb(245, 247, 250), Padding = new Padding(0)
            };
            tbl.RowStyles.Add(new RowStyle(SizeType.Absolute,  40));  // 標題列
            tbl.RowStyles.Add(new RowStyle(SizeType.Absolute,  14));  // 間距列
            tbl.RowStyles.Add(new RowStyle(SizeType.Percent,  100));  // 內容區

            var pnlTitle = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            var bar  = new Panel { Width = 5, Dock = DockStyle.Left, BackColor = accent };
            var lbl  = new Label { Text = title, Font = new Font("Microsoft JhengHei UI", 11, FontStyle.Bold), ForeColor = Color.FromArgb(30, 30, 46), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) };
            pnlTitle.Controls.Add(lbl);
            pnlTitle.Controls.Add(bar);

            var pnlGap  = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(245, 247, 250) };
            var pnlWork = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(245, 247, 250), Padding = new Padding(20, 0, 20, 16) };

            tbl.Controls.Add(pnlTitle, 0, 0);
            tbl.Controls.Add(pnlGap,   0, 1);
            tbl.Controls.Add(pnlWork,  0, 2);
            uc.Controls.Add(tbl);
            return pnlWork;
        }

        public static Button Btn(string text, Color color, int x, int y, int w = 120, int h = 34)
        {
            var b = new Button { Text = text, Location = new Point(x, y), Size = new Size(w, h), FlatStyle = FlatStyle.Flat, BackColor = color, ForeColor = Color.White, Font = new Font("Microsoft JhengHei UI", 10) };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例1：TryParse 輸入驗證
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_TryParse : UserControl
    {
        public UC_Ex_TryParse()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：TryParse 輸入驗證", Color.FromArgb(59, 130, 246));

            var desc   = new Label { Text = "【概念】TryParse 安全地將字串轉換成數字，失敗時不會當機，只回傳 false。\r\n輸入一個數字，示範 int / double / decimal 三種轉換：", Font = new Font("Microsoft JhengHei UI", 10), AutoSize = true, Location = new Point(0, 0) };
            var input  = new TextBox { Location = new Point(0, 54), Width = 200, Font = new Font("Microsoft JhengHei UI", 11), BorderStyle = BorderStyle.FixedSingle };
            var btn    = UCHelper.Btn("▶ 測試", Color.FromArgb(59, 130, 246), 210, 52);
            var result = new Label { Location = new Point(0, 100), AutoSize = true, Font = new Font("Microsoft JhengHei UI", 10) };

            btn.Click += (s, e) =>
            {
                string r = "";
                r += int.TryParse    (input.Text, out int    i) ? $"✅ int     成功：{i}\r\n" : "❌ int     失敗\r\n";
                r += double.TryParse (input.Text, out double d) ? $"✅ double  成功：{d}\r\n" : "❌ double  失敗\r\n";
                r += decimal.TryParse(input.Text, out decimal m)? $"✅ decimal 成功：{m}\r\n" : "❌ decimal 失敗\r\n";
                result.Text = r;
            };
            w.Controls.AddRange(new Control[] { desc, input, btn, result });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例2：Lambda 與 Func
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_Lambda : UserControl
    {
        public UC_Ex_Lambda()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：Lambda 與 Func", Color.FromArgb(16, 185, 129));

            var desc   = new Label { Text = "【概念】Lambda 是匿名函式，搭配 Func<> 可以把「計算邏輯」當參數傳遞。\r\n輸入兩個數字，選擇運算方式：", Font = new Font("Microsoft JhengHei UI", 10), AutoSize = true, Location = new Point(0, 0) };
            var txtA   = new TextBox { Location = new Point(0,  50), Width = 100, Font = new Font("Microsoft JhengHei UI", 11), BorderStyle = BorderStyle.FixedSingle, PlaceholderText = "數字 A" };
            var txtB   = new TextBox { Location = new Point(110, 50), Width = 100, Font = new Font("Microsoft JhengHei UI", 11), BorderStyle = BorderStyle.FixedSingle, PlaceholderText = "數字 B" };
            var bAdd   = UCHelper.Btn("➕ 加", Color.FromArgb(59,  130, 246),   0, 92, 88);
            var bSub   = UCHelper.Btn("➖ 減", Color.FromArgb(245, 158,  11),  96, 92, 88);
            var bMul   = UCHelper.Btn("✖ 乘", Color.FromArgb(139,  92, 246), 192, 92, 88);
            var bDiv   = UCHelper.Btn("➗ 除", Color.FromArgb(239,  68,  68), 288, 92, 88);
            var result = new Label { Location = new Point(0, 138), AutoSize = true, Font = new Font("Microsoft JhengHei UI", 13, FontStyle.Bold) };

            void Calc(Func<double, double, double> op, string sym)
            {
                if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b)) { result.Text = "❌ 請輸入有效數字"; return; }
                if (sym == "÷" && b == 0) { result.Text = "❌ 除數不能為 0"; return; }
                result.Text = $"結果：{a} {sym} {b} = {op(a, b):F4}";
            }
            bAdd.Click += (s, e) => Calc((a, b) => a + b, "+");
            bSub.Click += (s, e) => Calc((a, b) => a - b, "-");
            bMul.Click += (s, e) => Calc((a, b) => a * b, "×");
            bDiv.Click += (s, e) => Calc((a, b) => a / b, "÷");

            w.Controls.AddRange(new Control[] { desc, txtA, txtB, bAdd, bSub, bMul, bDiv, result });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例3：List 與 LINQ
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_ListLinq : UserControl
    {
        public UC_Ex_ListLinq()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：List 與 LINQ", Color.FromArgb(245, 158, 11));

            var scores = new List<int> { 85, 92, 78, 63, 95, 41, 88, 72, 55, 99 };
            var desc   = new Label { Text = $"原始資料：{string.Join(", ", scores)}\r\n點擊按鈕示範各種 LINQ 操作：", Font = new Font("Microsoft JhengHei UI", 10), AutoSize = true, Location = new Point(0, 0) };

            var b1 = UCHelper.Btn("Where (≥60)",  Color.FromArgb(59,  130, 246),   0, 50, 138);
            var b2 = UCHelper.Btn("OrderByDesc",  Color.FromArgb(16,  185, 129), 146, 50, 138);
            var b3 = UCHelper.Btn("Avg/Max/Min",  Color.FromArgb(245, 158,  11), 292, 50, 138);
            var b4 = UCHelper.Btn("Select (×2)",  Color.FromArgb(139,  92, 246),   0, 92, 138);
            var b5 = UCHelper.Btn("Count (≥60)",  Color.FromArgb(236,  72, 153), 146, 92, 138);
            var b6 = UCHelper.Btn("First / Last", Color.FromArgb(239,  68,  68), 292, 92, 138);
            var result = new Label { Location = new Point(0, 140), AutoSize = true, Font = new Font("Microsoft JhengHei UI", 11, FontStyle.Bold) };

            b1.Click += (s, e) => result.Text = $"Where(>=60)：{string.Join(", ", scores.Where(x => x >= 60))}";
            b2.Click += (s, e) => result.Text = $"OrderByDesc：{string.Join(", ", scores.OrderByDescending(x => x))}";
            b3.Click += (s, e) => result.Text = $"Avg：{scores.Average():F1}　Max：{scores.Max()}　Min：{scores.Min()}";
            b4.Click += (s, e) => result.Text = $"Select(x*2)：{string.Join(", ", scores.Select(x => x * 2))}";
            b5.Click += (s, e) => result.Text = $"Count(>=60)：{scores.Count(x => x >= 60)} 個　不及格：{scores.Count(x => x < 60)} 個";
            b6.Click += (s, e) => result.Text = $"First：{scores.First()}　Last：{scores.Last()}　FirstOrDefault(>90)：{scores.FirstOrDefault(x => x > 90)}";

            w.Controls.AddRange(new Control[] { desc, b1, b2, b3, b4, b5, b6, result });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例4：DataGridView 操作
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_DataGrid : UserControl
    {
        public UC_Ex_DataGrid()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：DataGridView 操作", Color.FromArgb(139, 92, 246));

            var bAdd  = UCHelper.Btn("➕ 新增一列",   Color.FromArgb(16,  185, 129),   0, 0, 120);
            var bDel  = UCHelper.Btn("🗑 刪除選取",   Color.FromArgb(239,  68,  68), 128, 0, 120);
            var bSort = UCHelper.Btn("📊 依分數排序", Color.FromArgb(59,  130, 246), 256, 0, 130);

            var dgv = new DataGridView
            {
                Location = new Point(0, 42), Size = new Size(700, 300),
                Anchor   = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackgroundColor = Color.White, BorderStyle = BorderStyle.None,
                RowHeadersVisible = false, AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Font = new Font("Microsoft JhengHei UI", 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 46);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font      = new Font("Microsoft JhengHei UI", 10, FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;
            dgv.Columns.Add("Name", "姓名"); dgv.Columns.Add("Score", "分數");
            dgv.Columns["Name"]!.FillWeight = 50; dgv.Columns["Score"]!.FillWeight = 50;

            int n = 3;
            dgv.Rows.Add("王小明", 85); dgv.Rows.Add("李小華", 92); dgv.Rows.Add("張大同", 78);

            bAdd.Click  += (s, e) => dgv.Rows.Add($"學生{++n:D2}", new Random().Next(40, 100));
            bDel.Click  += (s, e) => { if (dgv.SelectedRows.Count > 0) dgv.Rows.Remove(dgv.SelectedRows[0]); };
            bSort.Click += (s, e) => dgv.Sort(dgv.Columns["Score"]!, System.ComponentModel.ListSortDirection.Descending);

            w.Controls.AddRange(new Control[] { bAdd, bDel, bSort, dgv });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例5：MessageBox 與 Dialog
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_Dialog : UserControl
    {
        public UC_Ex_Dialog()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：MessageBox 與 Dialog", Color.FromArgb(236, 72, 153));

            var desc   = new Label { Text = "點擊按鈕體驗各種對話框：", Font = new Font("Microsoft JhengHei UI", 10), AutoSize = true, Location = new Point(0, 0) };
            var b1 = UCHelper.Btn("ℹ️ Information", Color.FromArgb(59,  130, 246),   0, 32, 160);
            var b2 = UCHelper.Btn("⚠️ Warning",     Color.FromArgb(245, 158,  11), 168, 32, 160);
            var b3 = UCHelper.Btn("❌ Error",       Color.FromArgb(239,  68,  68),   0, 74, 160);
            var b4 = UCHelper.Btn("❓ YesNo 確認",  Color.FromArgb(16,  185, 129), 168, 74, 160);
            var b5 = UCHelper.Btn("📂 開啟檔案",    Color.FromArgb(139,  92, 246),   0,116, 160);
            var b6 = UCHelper.Btn("💾 儲存檔案",    Color.FromArgb(236,  72, 153), 168,116, 160);
            var result = new Label { Location = new Point(0, 162), AutoSize = true, Font = new Font("Microsoft JhengHei UI", 10) };

            b1.Click += (s, e) => MessageBox.Show("這是 Information 訊息框", "資訊",   MessageBoxButtons.OK, MessageBoxIcon.Information);
            b2.Click += (s, e) => MessageBox.Show("這是 Warning 警告框",     "警告",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            b3.Click += (s, e) => MessageBox.Show("這是 Error 錯誤框",       "錯誤",   MessageBoxButtons.OK, MessageBoxIcon.Error);
            b4.Click += (s, e) => result.Text = MessageBox.Show("確定要執行嗎？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? "你選擇了：Yes ✅" : "你選擇了：No ❌";
            b5.Click += (s, e) => { var d = new OpenFileDialog(); if (d.ShowDialog() == DialogResult.OK) result.Text = $"選擇：{d.FileName}"; };
            b6.Click += (s, e) => { var d = new SaveFileDialog { Filter = "文字檔|*.txt" }; if (d.ShowDialog() == DialogResult.OK) result.Text = $"儲存：{d.FileName}"; };

            w.Controls.AddRange(new Control[] { desc, b1, b2, b3, b4, b5, b6, result });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例6：Timer 計時器
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_Timer : UserControl
    {
        private readonly System.Windows.Forms.Timer _tmr = new();
        private int _sec; private bool _on;

        public UC_Ex_Timer()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：Timer 計時器", Color.FromArgb(59, 130, 246));

            var lblTime = new Label { Text = "00:00", Font = new Font("Microsoft JhengHei UI", 36, FontStyle.Bold), ForeColor = Color.FromArgb(30, 30, 46), AutoSize = true, Location = new Point(0, 0) };
            var lblDesc = new Label { Text = "【概念】System.Windows.Forms.Timer 每隔固定時間觸發 Tick 事件", Font = new Font("Microsoft JhengHei UI", 9), ForeColor = Color.FromArgb(100, 116, 139), AutoSize = true, Location = new Point(0, 64) };
            var bStart  = UCHelper.Btn("▶ 開始", Color.FromArgb(16,  185, 129),   0, 92, 100);
            var bStop   = UCHelper.Btn("⏸ 暫停", Color.FromArgb(245, 158,  11), 108, 92, 100);
            var bReset  = UCHelper.Btn("⏹ 重置", Color.FromArgb(239,  68,  68), 216, 92, 100);

            _tmr.Interval = 1000;
            _tmr.Tick    += (s, e) => { _sec++; lblTime.Text = $"{_sec/60:D2}:{_sec%60:D2}"; };

            bStart.Click += (s, e) => { if (!_on) { _tmr.Start(); _on = true; } };
            bStop.Click  += (s, e) => { _tmr.Stop(); _on = false; };
            bReset.Click += (s, e) => { _tmr.Stop(); _on = false; _sec = 0; lblTime.Text = "00:00"; };
            this.Disposed += (s, e) => _tmr.Stop();

            w.Controls.AddRange(new Control[] { lblTime, lblDesc, bStart, bStop, bReset });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例7：檔案讀寫
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_FileIO : UserControl
    {
        public UC_Ex_FileIO()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：檔案讀寫", Color.FromArgb(245, 158, 11));

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test_fileio.txt");
            var desc   = new Label { Text = $"測試檔案：{path}", Font = new Font("Microsoft JhengHei UI", 9), ForeColor = Color.FromArgb(100, 116, 139), AutoSize = true, Location = new Point(0, 0) };
            var txt    = new TextBox { Location = new Point(0, 26), Size = new Size(500, 100), Multiline = true, Font = new Font("Microsoft JhengHei UI", 10), ScrollBars = ScrollBars.Vertical, BorderStyle = BorderStyle.FixedSingle, Text = "在這裡輸入要寫入檔案的內容..." };
            var bW     = UCHelper.Btn("💾 寫入",  Color.FromArgb(16,  185, 129),   0, 136, 110);
            var bR     = UCHelper.Btn("📂 讀取",  Color.FromArgb(59,  130, 246), 118, 136, 110);
            var bA     = UCHelper.Btn("➕ 附加",  Color.FromArgb(139,  92, 246), 236, 136, 110);
            var result = new Label { Location = new Point(0, 180), AutoSize = true, Font = new Font("Microsoft JhengHei UI", 10) };

            bW.Click += (s, e) => { try { File.WriteAllText(path, txt.Text); result.Text = "✅ 寫入成功！"; } catch (Exception ex) { result.Text = $"❌ {ex.Message}"; } };
            bR.Click += (s, e) => { if (File.Exists(path)) { txt.Text = File.ReadAllText(path); result.Text = "✅ 讀取成功！"; } else result.Text = "❌ 檔案不存在"; };
            bA.Click += (s, e) => { try { File.AppendAllText(path, "\r\n" + txt.Text); result.Text = "✅ 附加成功！"; } catch (Exception ex) { result.Text = $"❌ {ex.Message}"; } };

            w.Controls.AddRange(new Control[] { desc, txt, bW, bR, bA, result });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  範例8：JSON 序列化
    // ─────────────────────────────────────────────────────────────
    public class UC_Ex_Json : UserControl
    {
        record Student(string Name, int Score, string Grade);

        public UC_Ex_Json()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "📌 範例：JSON 序列化", Color.FromArgb(139, 92, 246));

            var desc    = new Label { Text = "【概念】System.Text.Json 將物件轉換成 JSON 字串，或反向解析。", Font = new Font("Microsoft JhengHei UI", 10), AutoSize = true, Location = new Point(0, 0) };
            var txtJson = new TextBox { Location = new Point(0, 28), Size = new Size(600, 130), Multiline = true, Font = new Font("Consolas", 10), ScrollBars = ScrollBars.Both, ReadOnly = true, BorderStyle = BorderStyle.FixedSingle };
            var b1      = UCHelper.Btn("▶ 物件→JSON", Color.FromArgb(139,  92, 246),   0, 170, 140);
            var b2      = UCHelper.Btn("▶ JSON→物件", Color.FromArgb(16,  185, 129), 148, 170, 140);
            var b3      = UCHelper.Btn("▶ List→JSON", Color.FromArgb(59,  130, 246), 296, 170, 140);
            var result  = new Label { Location = new Point(0, 214), AutoSize = true, Font = new Font("Microsoft JhengHei UI", 10) };

            var opt = new JsonSerializerOptions { WriteIndented = true };
            b1.Click += (s, e) => { txtJson.Text = JsonSerializer.Serialize(new Student("王小明", 92, "A"), opt); result.Text = "✅ 序列化成功"; };
            b2.Click += (s, e) => { try { var st = JsonSerializer.Deserialize<Student>(txtJson.Text); result.Text = $"✅ 姓名={st?.Name}　分數={st?.Score}　等第={st?.Grade}"; } catch { result.Text = "❌ 請先點「物件→JSON」"; } };
            b3.Click += (s, e) => { txtJson.Text = JsonSerializer.Serialize(new List<Student> { new("王小明",92,"A"), new("李小華",78,"B"), new("張大同",55,"C") }, opt); result.Text = "✅ List 序列化成功"; };

            w.Controls.AddRange(new Control[] { desc, txtJson, b1, b2, b3, result });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  權限功能 1、2（全員可用）
    // ─────────────────────────────────────────────────────────────
    public class UC_Auth_Func1 : UserControl
    {
        public UC_Auth_Func1()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "🔐 功能1 - 基本查詢（全員可用）", Color.FromArgb(16, 185, 129));
            w.Controls.Add(new Label { Text = $"✅ 登入者：{AppSession.CurrentUser.ToUpper()}（{AppSession.CurrentRole}）\r\n\r\n此功能所有人都可以使用。\r\n這裡放你的基本查詢功能。", Font = new Font("Microsoft JhengHei UI", 12), AutoSize = true, Location = new Point(0, 0) });
        }
    }

    public class UC_Auth_Func2 : UserControl
    {
        public UC_Auth_Func2()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "🔐 功能2 - 個人資料（全員可用）", Color.FromArgb(16, 185, 129));
            w.Controls.Add(new Label { Text = $"✅ 登入者：{AppSession.CurrentUser.ToUpper()}（{AppSession.CurrentRole}）\r\n\r\n此功能所有人都可以使用。\r\n這裡放個人資料功能。", Font = new Font("Microsoft JhengHei UI", 12), AutoSize = true, Location = new Point(0, 0) });
        }
    }

    // ─────────────────────────────────────────────────────────────
    //  權限功能 3、4、5（Admin Only）
    // ─────────────────────────────────────────────────────────────
    public class UC_Auth_Func3 : UserControl
    {
        public UC_Auth_Func3()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "🔐 功能3 - 資料修改（Admin Only）", Color.FromArgb(245, 158, 11));
            w.Controls.Add(new Label { Text = $"🔑 Admin 專屬功能\r\n\r\n登入者：{AppSession.CurrentUser.ToUpper()}\r\n\r\n這裡放資料修改功能。", Font = new Font("Microsoft JhengHei UI", 12), AutoSize = true, Location = new Point(0, 0) });
        }
    }

    public class UC_Auth_Func4 : UserControl
    {
        public UC_Auth_Func4()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "🔐 功能4 - 資料刪除（Admin Only）", Color.FromArgb(239, 68, 68));
            w.Controls.Add(new Label { Text = $"🔑 Admin 專屬功能\r\n\r\n登入者：{AppSession.CurrentUser.ToUpper()}\r\n\r\n這裡放資料刪除功能。", Font = new Font("Microsoft JhengHei UI", 12), AutoSize = true, Location = new Point(0, 0) });
        }
    }

    public class UC_Auth_Func5 : UserControl
    {
        public UC_Auth_Func5()
        {
            this.Dock = DockStyle.Fill;
            var w = UCHelper.MakeLayout(this, "🔐 功能5 - 系統設定（Admin Only）", Color.FromArgb(30, 30, 46));
            w.Controls.Add(new Label { Text = $"🔑 Admin 專屬功能\r\n\r\n登入者：{AppSession.CurrentUser.ToUpper()}\r\n\r\n這裡放系統設定功能。", Font = new Font("Microsoft JhengHei UI", 12), AutoSize = true, Location = new Point(0, 0) });
        }
    }
}
