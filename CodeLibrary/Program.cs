using System.Windows.Forms;

namespace CodeLibrary
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 先顯示登入視窗，登入成功才進主畫面
            //正式流程,目前註解掉
            var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm());

            // 測試用（要測哪個就開哪個）
            //Application.Run(new Form()
            //{
            //    Controls = { new UC_成績等第計算器() { Dock = DockStyle.Fill } },
            //    Text = "測試",
            //    Size = new Size(800, 600)
            //});
        }
    }
}
