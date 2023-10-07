using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        string option, total;
        long? num1, num2;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = string.Empty;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Insert First number!");
            }
            else
            {
                num2 = null;
                num1 = long.Parse(textBox1.Text);

                Button Option = (Button)sender;
                option += Option.Text;

                textBox1.Text = string.Empty;
            }
        }

        private void btnEql_Click(object sender, EventArgs e)
        {            
            if (textBox1.Text == "")
                MessageBox.Show("You need to insert number!");
            else if (option == null)
                MessageBox.Show("You need to pick an action!");

            else
            {
                if (num2 == null) num2 = long.Parse(textBox1.Text);
                textBox1.Text = string.Empty;

                if(option == "+")
                {
                    total = (num1 + num2).ToString();
                } 
                else if(option == "-")
                {
                    total = (num1 - num2).ToString();
                }
                else if(option == "*")
                {
                    total = (num1 * num2).ToString();
                }
                else if(option == "/")
                {
                    total = (num1 / num2).ToString();
                }
                num1 = long.Parse(total);
                textBox1.Text = total;
            }            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (total != "")
            {
                total = string.Empty;
                textBox1.Text = string.Empty;
                Button Number = (Button)sender;
                textBox1.Text += Number.Text;
            }
            else
            {
                Button Number = (Button)sender;
                textBox1.Text += Number.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            num1 = null; 
            num2 = null;
            option = string.Empty;
            total= string.Empty;
        }
    }
}
