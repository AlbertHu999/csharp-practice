using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace CodeLibrary
{
    public partial class UC_猜數字 : UserControl
    {
        public UC_猜數字()
        {
            InitializeComponent();
        }
        private int targetNumber;
        private int attempts;

        private void UC_猜數字_Load(object sender, EventArgs e)
        {
     

            StartNewGame();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }


        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuess.Text, out int guess))
            {
                MessageBox.Show("請輸入有效的數字！");
                return;
            }
            if (guess < 1 || guess > 100)
            {
                MessageBox.Show("請輸入1到100之間的數字！");
                return;
            }


            //計算嘗試次數
            attempts++;

            //判斷猜測結果
            //if (guess < targetNumber)
            //{
            //    lblResult.Text = "太小了！再試一次。";
            //}
            //else if (guess > targetNumber)
            //{
            //    lblResult.Text = "太大了！再試一次。";
            //}
            //else
            //{
            //    lblResult.Text = $"恭喜你！猜對了！總共嘗試了 {attempts} 次。";
            //    btnGuess.Enabled = false; // 禁止繼續猜測
            //}
            String message = (guess, targetNumber) switch
            {
                var (g, t) when g < t => "太小了！再試一次。",
                var (g, t) when g > t => "太大了！再試一次。",
                var (g, t) when g == t => $"恭喜你！猜對了！總共嘗試了 {attempts} 次。",
                _ => $"其他錯誤"
            };
            lblResult.Text = message;

            //如果猜對了,詢問是否重新開始遊戲
            if (guess == targetNumber)
            {
                var result = MessageBox.Show("你想再玩一次嗎？", "遊戲結束", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StartNewGame();
                }
                else
                {
                    btnGuess.Enabled = false; // 禁止繼續猜測
                }
            }

        }
        private void StartNewGame()
        {
            Random rand = new Random();
            targetNumber = rand.Next(1, 101); // 生成1到100之間的隨機數字
            attempts = 0;
            lblResult.Text = "遊戲開始！請猜一個1到100之間的數字。";
            btnGuess.Enabled = true; // 啟用猜測按鈕
            txtGuess.Text = "";
            txtGuess.Focus(); // 將焦點設置到輸入框

        }
    }
}

