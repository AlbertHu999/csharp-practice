namespace CodeLibrary
{
    public partial class HelloWinForm : Form
    {
        public HelloWinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello,WinForm!";
            MessageBox.Show("歡迎來到C#", "msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bthGreet_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            label1.Text = $"你好{name},輸入測試";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string any = textBox1.Text;
            label1.Text = $"很棒{any}";

        }

        private void HelloWinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
