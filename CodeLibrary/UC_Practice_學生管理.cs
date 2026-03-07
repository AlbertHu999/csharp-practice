using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeLibrary
{
    public partial class UC_Practice_學生管理 : UserControl
    {
        public UC_Practice_學生管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text=textBox1.Text+textBox2.Text+textBox3.Text+textBox4.Text+textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text +textBox9.Text;
            label1.Text = "姓名:" + textBox1.Text + "  性別:" + textBox2.Text + "  年齡:" + textBox3.Text + "  學號:" + textBox4.Text + "  科系:" + textBox5.Text + "  電話:" + textBox6.Text + "  地址:" + textBox7.Text + "  電子郵件:" + textBox8.Text + "  備註:" + textBox9.Text + textBox10.Text + textBox11.Text  + textBox12.Text; 
        }
    }
}

