using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeLibrary
{
    public partial class UC_成績等第計算器 : UserControl
    {
        public UC_成績等第計算器()
        {
            InitializeComponent();
        }



        private void UC_成績等第計算器_Load(object sender, EventArgs e)
        {

        }

        private void bthCalCulate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text?.Trim() ?? "未輸入";
            if (!double.TryParse(txtScore1.Text, out double score1) || !double.TryParse(txtScore2.Text, out double score2) || !double.TryParse(txtScore3.Text, out double score3))
            {
                MessageBox.Show("請輸入有效的分數");
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

            // === 4. 判斷評語 ===
            string comment = grade switch
            {
                "A" => "優秀！繼續保持！",
                "B" => "良好！再加把勁！",
                "C" => "普通，還有進步空間。",
                "D" => "及格了，但要更努力。",
                _ => "不及格，需要加強複習。"
            };

            // === 5. 使用字串插值顯示結果 ===
            //lblResult.Text = $"學生{name}\n的平均分數是: {average:F2}\n等第{grade}";
            string result = $"""
            分數：{average} 分
            等第：{grade}
            評語：{comment}
            """;

            lblResult.Text = result;

            // === 6. 根據等第改變顏色 ===
            lblResult.ForeColor = grade switch
            {
                "A" => Color.Green,
                "B" => Color.Blue,
                "C" => Color.Orange,
                "D" => Color.DarkOrange,
                _ => Color.Red
            };
            //顯示結果
        }
    }
}

