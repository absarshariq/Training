using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string n2 = textBox2.Text;
            Regex regex = new Regex("^[0-9]+$");
            if(regex.IsMatch(n) && regex.IsMatch(n2))
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                var result = 0;
                if (radioButton1.Checked)
                {
                    result = num1 + num2;
                }
                else if(radioButton2.Checked)
                {
                    result = num1 - num2;
                }
                else if(radioButton3.Checked)
                {
                    result = num1*num2;
                }
                else if (radioButton4.Checked)
                {
                    if(num2==0)
                    {
                        MessageBox.Show("Cannot Divide by Zaro");
                        Environment.Exit(0);
                    }
                    result = num1 / num2;
                }
                else
                {
                    MessageBox.Show("Please Select An Operation");
                    Environment.Exit(0);
                }
                MessageBox.Show(result.ToString());
            }
           else
            {
                MessageBox.Show("‘Please enter valid input for the operands");
            }
        }
    }
}
