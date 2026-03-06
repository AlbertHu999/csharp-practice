namespace 成績計算器
{
    public partial class GradeCalculator : Form
    {

        public GradeCalculator()
        {
            InitializeComponent();
            txtName.Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bthCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text?.Trim() ?? "未輸入";
            if (!double.TryParse(txtScore1.Text, out double score1) || !double.TryParse(txtScore2.Text, out double score2) || !double.TryParse(txtScore3.Text, out double score3))
            {
                MessageBox.Show("請輸入有效的分數1");
                return;
            }

            //計算平均分數
            double average = (score1 + score2 + score3) / 3.0;

            //判斷等第
            string grade = average switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };


            //顯示結果
            lblResult.Text = $"學生{name}\n的平均分數是: {average:F2}\n等第{grade}";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtScore1.Focus();  // 跳到下一個 TextBox
                e.Handled = true;   // 避免發出嗶聲
                e.SuppressKeyPress = true;  // 抑制按鍵事件
            }
        }

        // txtScore1 按 Enter 跳到 txtScore2


        // txtScore2 按 Enter 跳到 txtScore3


        // txtScore3 按 Enter 直接觸發計算按鈕
        private void txtScore3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 模擬按下計算按鈕
                bthCalCulate.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtScore1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtScore2.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtScore2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScore2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtScore3.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

      
    }
}
