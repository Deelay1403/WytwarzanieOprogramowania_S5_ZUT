using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double First;
        string Operation="0";
        double holder;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void jeden_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
            }
        }

        private void dwa_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text = textBox2.Text + "2";
            }
        }

        private void trzy_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text = textBox2.Text + "3";
            }
        }

        private void cztery_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
            }
        }

        private void piec_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
            }
        }

        private void szesc_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text = textBox2.Text + "6";
            }
        }

        private void siedem_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
            }
        }

        private void osiem_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
            }
        }

        private void dziewiec_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text = textBox2.Text + "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Text = textBox2.Text + "0";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (Operation =="0")
            {
                First = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                Operation = "+";
            }
            else
            {
                holder = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                First = First + holder;

            }
        }

        private void minus_Click(object sender, EventArgs e)
        {

            if (Operation == "0")
            {
                First = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                Operation = "-";
            }
            else
            {
                holder = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                First = First - holder;

            }
        }

        private void razy_Click(object sender, EventArgs e)
        {

            if (Operation == "0")
            {
                First = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                Operation = "*";
            }
            else
            {
                holder = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                First = First * holder;

            }
        }

        private void podzielic_Click(object sender, EventArgs e)
        {

            if (Operation == "0")
            {
                First = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                Operation = "/";
            }
            else
            {
                holder = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "0";
                First = First / holder;

            }
        }

        private void rownosc_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox2.Text);

            if (Operation == "+")
            {
                Result = (First + SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }
            else if (Operation == "-")
            {
                Result = (First - SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }
            else if (Operation == "*")
            {
                Result = (First * SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }
           else if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox2.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (First / SecondNumber);
                    textBox2.Text = Convert.ToString(Result);
                    First = Result;
                }
            }
        
    }
    }
}
