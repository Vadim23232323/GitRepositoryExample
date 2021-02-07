using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        float a, b;
        int count;
        bool znak = true;
        public Calculator()
        {
            InitializeComponent();
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_number0_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 0;
        }

        private void btn_number1_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 1;
        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 2;
        }

        private void btn_number3_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 3;
        }

        private void btn_number4_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 4;
        }

        private void btn_number5_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 5;
        }

        private void btn_number6_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 6;
        }

        private void btn_number7_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 7;
        }

        private void btn_number8_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 8;
        }

        private void btn_number9_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + 9;
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 1;
            lab_operation.Text = a.ToString() + "+";
            znak = true;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_difference_Click(object sender, EventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 2;
            lab_operation.Text = a.ToString() + "-";
            znak = true;
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 3;
            lab_operation.Text = a.ToString() + "*";
            znak = true;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 4;
            lab_operation.Text = a.ToString() + "/";
            znak = true;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_result_Click_1(object sender, EventArgs e)
        {
            calculate();
            lab_operation.Text = "";

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_result.Text = "";
            lab_operation.Text = "";
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            int lenght = tb_result.Text.Length - 1;
            string text = tb_result.Text;
            tb_result.Clear();
            for (int i = 0; i < lenght; i++)
            {
                tb_result.Text = tb_result.Text + text[i];
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                tb_result.Text = "-" + tb_result.Text;
                znak = false;
            }
            else if (znak == false)
            {
                tb_result.Text = tb_result.Text.Replace("-", "");
                znak = true;
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            tb_result.Text = tb_result.Text + ",";
        }
    }
}
