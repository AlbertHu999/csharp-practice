using System.Windows.Forms;

namespace CodeLibrary
{
    // ★ 注意：不要在 VS 開 LoginForm.cs [設計] 標籤
    //          開了設計工具會自動修改 Designer.cs，破壞手寫的版面
    public partial class LoginForm : Form
    {
        public LoginForm() => InitializeComponent();

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string user = txtUsername.Text.Trim().ToLower();
            string pass = txtPassword.Text;

            if ((user == "admin" || user == "user") && pass == "")
            {
                AppSession.Login(user, user); // role 與 username 相同
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Visible = true;
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txtPassword.Focus(); e.SuppressKeyPress = true; }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnLogin_Click(sender, e); e.SuppressKeyPress = true; }
        }
    }
}
