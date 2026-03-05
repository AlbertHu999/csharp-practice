using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 共用測試
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void calculate(Func<double, double, double> operation, string operatorSymbol)
        {
            if (double.TryParse(txtFirstNumber.Text, out double firstNumber) &&
                double.TryParse(txtSecondNumber.Text, out double secondNumber))
            {
                double result = operation(firstNumber, secondNumber);
                lblResult.Text = $"Result: {firstNumber} {operatorSymbol} {secondNumber} = {result}";
                //return result;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
                //return 0;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //    if (double.TryParse(txtFirstNumber.Text, out double firstNumber) &&
            //        double.TryParse(txtSecondNumber.Text, out double secondNumber))
            //    {
            //        double result = firstNumber + secondNumber;
            //        lblResult.Text = $"Result: {result}";
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter valid numbers.");
            //    }
            calculate((a, b) => a + b, "+");


        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculate((a, b) => a - +b, "-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculate((a, b) => a * b, "*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculate((a, b) => a / b, "/");
        }
    }
}
