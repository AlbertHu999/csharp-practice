using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeLibrary
{
    public partial class UC_多用途共用 : UserControl
    {
        public UC_多用途共用()
        {
            InitializeComponent();
            TxtResult.Font = new Font("Consolas", 14);
            //TxtResult.Font = new Font("Courier New", 14);
        }



        private void BtnSB_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();

            for (int i = 1; i <= 9; i++)
            {
                for
                    (int j = 1; j <= 9; j++)
                {

                    int result = i * j;
                    sb.Append($"{i,2} x {j,2} = {result,2}  ");

                }
                sb.AppendLine();

            }
            TxtResult.Text = sb.ToString();
        }

        private void BtnForeach_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtNumber.Text, out int number))
            {
                MessageBox.Show("请输入一个有效的整数！");
                return;
            }
            var sb = new StringBuilder();
            sb.AppendLine($"{number}的乘法表");
            sb.AppendLine("=============");    
            foreach (var i in Enumerable.Range(1, 9))
            {
                sb.AppendLine($"{number,2
                    } x {i,2} = {number * i,2}");
            }

            TxtResult.Text= sb.ToString();
        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

