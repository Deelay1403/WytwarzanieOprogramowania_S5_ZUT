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
            DEC.Select();
            radioButton6.Select();
            button9.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        class Oper
        {
            string sym = "0";
            byte weight = 1;
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
            if (textBox2.Text == "0" || textBox2.Text == null)//zmienić resztę na takie  jak obok
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
                //First = First + holder;
                First = WytwarzanieOprogramowania.Calc.Add(First, holder);
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
                First = WytwarzanieOprogramowania.Calc.Sub(First, holder);

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
                First = WytwarzanieOprogramowania.Calc.Multiply(First, holder);

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
                First = WytwarzanieOprogramowania.Calc.Divide(First, holder);

            }
        }

        private void rownosc_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox2.Text);

            if (Operation == "+")
            {
                Result = WytwarzanieOprogramowania.Calc.Add(First , SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }
            else if (Operation == "-")
            {
                Result = WytwarzanieOprogramowania.Calc.Sub(First, SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }
            else if (Operation == "*")
            {
                Result = WytwarzanieOprogramowania.Calc.Multiply(First, SecondNumber);
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
                    Result = WytwarzanieOprogramowania.Calc.Divide(First, SecondNumber);
                    textBox2.Text = Convert.ToString(Result);
                    First = Result;
                }
            }
            else if (Operation == "%")
            {
                Result = WytwarzanieOprogramowania.Calc.Modulo(First, SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }

            else if (Operation == "or")
            {
                Result = WytwarzanieOprogramowania.Calc.OR(Convert.ToInt64(First), Convert.ToInt64(SecondNumber));
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }

            else if (Operation == "xor")
            {
                Result = WytwarzanieOprogramowania.Calc.XOR(Convert.ToInt64(First), Convert.ToInt64(SecondNumber));
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }

            else if (Operation == "and")
            {
                Result = WytwarzanieOprogramowania.Calc.AND(Convert.ToInt64(First), Convert.ToInt64(SecondNumber));
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }
            else if (Operation == "<<")
            {
                Result = WytwarzanieOprogramowania.Calc.Lsh(Convert.ToInt64(First), Convert.ToInt32(SecondNumber));
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }

            else if (Operation == ">>")
            {
                Result = WytwarzanieOprogramowania.Calc.Rsh(Convert.ToInt64(First), Convert.ToInt32(SecondNumber));
                textBox2.Text = Convert.ToString(Result);
                First = Result;
            }
        }

       

        private void BIN_CheckedChanged(object sender, EventArgs e)
        {
           
            dwa.Enabled = false;
            trzy.Enabled = false;
            cztery.Enabled = false;
            piec.Enabled = false;
            szesc.Enabled = false;
            siedem.Enabled = false;
            osiem.Enabled = false;
            dziewiec.Enabled = false;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
            przecinek.Enabled = false;
            ulamek.Enabled = false;
            pierwiastek.Enabled = false;
            procent.Enabled = false;


        }

        private void OCT_CheckedChanged(object sender, EventArgs e)
        {
            dwa.Enabled = true;
            trzy.Enabled = true;
            cztery.Enabled = true;
            piec.Enabled = true;
            szesc.Enabled = true;
            siedem.Enabled = true;
            osiem.Enabled = false;
            dziewiec.Enabled = false;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
            przecinek.Enabled = false;
            ulamek.Enabled = false;
            pierwiastek.Enabled = false;
            procent.Enabled = false;
        }

        private void DEC_CheckedChanged(object sender, EventArgs e)
        {
            dwa.Enabled = true;
            trzy.Enabled = true;
            cztery.Enabled = true;
            piec.Enabled = true;
            szesc.Enabled = true;
            siedem.Enabled = true;
            osiem.Enabled = true;
            dziewiec.Enabled = true;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
            przecinek.Enabled = false;
            ulamek.Enabled = false;
            pierwiastek.Enabled = false;
            procent.Enabled = false;
        }
        private void HEX_CheckedChanged(object sender, EventArgs e)
        {
            dwa.Enabled = true;
            trzy.Enabled = true;
            cztery.Enabled = true;
            piec.Enabled = true;
            szesc.Enabled = true;
            siedem.Enabled = true;
            osiem.Enabled = true;
            dziewiec.Enabled = true;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            F.Enabled = true;
            przecinek.Enabled = false;
            ulamek.Enabled = false;
            pierwiastek.Enabled = false;
            procent.Enabled = false;
        }

        private void strzalka_Click(object sender, EventArgs e)
        {
           string Result;
            if (textBox2.Text.Length > 1) { Result = WytwarzanieOprogramowania.Calc.Backspace(textBox2.Text); textBox2.Text = Convert.ToString(Result); }
            else if (textBox2.Text.Length == 1) { textBox2.Text = "0"; }

        }

        private void Ror_Click(object sender, EventArgs e)
        {
//sprawdzic co sie dzieje w normalnym jak masz 0
            long Result=WytwarzanieOprogramowania.Calc.Ror(Convert.ToInt64(textBox2.Text));
            textBox2.Text = Convert.ToString(Result);

        }

        private void RoL_Click(object sender, EventArgs e)
        {
            long Result = WytwarzanieOprogramowania.Calc.Rol(Convert.ToInt64(textBox2.Text));
            textBox2.Text = Convert.ToString(Result);

        }

        private void CE_Click(object sender, EventArgs e)
        {
            string Result;
            Result=WytwarzanieOprogramowania.Calc.CE();
            textBox2.Text = Convert.ToString(Result);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            long Result;
            Result = WytwarzanieOprogramowania.Calc.C();
            textBox2.Text = Convert.ToString(Result);
            
            Result = WytwarzanieOprogramowania.Calc.C();
            textBox2.Text = Convert.ToString(Result);
            Operation = "0";

        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            long Result;
            Result = WytwarzanieOprogramowania.Calc.PlusMinus(Convert.ToInt64(First));
            textBox2.Text = Convert.ToString(Result);

        }

        private void Mod_Click(object sender, EventArgs e)
        {
            if (Operation == "0")
            {
                First = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                Operation = "%";
            }
            else
            {
                holder = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                First = WytwarzanieOprogramowania.Calc.Modulo(Convert.ToInt64(First), Convert.ToInt64(holder));

            }
        }

        private void Or_Click(object sender, EventArgs e)
        {
            if (Operation == "0")
            {
                First = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                Operation = "or";
            }
            else
            {
                holder = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                First = WytwarzanieOprogramowania.Calc.OR(Convert.ToInt64(First), Convert.ToInt64(holder));

            }
        }

        private void Xor_Click(object sender, EventArgs e)
        {
            if (Operation == "0")
            {
                First = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                Operation = "xor";
            }
            else
            {
                holder = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                First = WytwarzanieOprogramowania.Calc.XOR(Convert.ToInt64(First), Convert.ToInt64(holder));

            }
        }

        private void Lsh_Click(object sender, EventArgs e)
        {
            if (Operation == "0")
            {
                First = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                Operation = "<<";
            }
            else
            {
                holder = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                First = WytwarzanieOprogramowania.Calc.Lsh(Convert.ToInt64(First), Convert.ToInt32(holder));

            }
        }

        private void Rsh_Click(object sender, EventArgs e)
        {
            if (Operation == "0")
            {
                First = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                Operation = ">>";
            }
            else
            {
                holder = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                First = WytwarzanieOprogramowania.Calc.Rsh(Convert.ToInt64(First), Convert.ToInt32(holder));

            }
        }

        private void Not_Click(object sender, EventArgs e)
        {
            long Result;
            Result = WytwarzanieOprogramowania.Calc.NOT(Convert.ToInt64(textBox2.Text));
            textBox2.Text = Convert.ToString(Result);
        }

        private void And_Click(object sender, EventArgs e)
        {
            if (Operation == "0")
            {
                First = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                Operation = "and";
            }
            else
            {
                holder = Convert.ToInt64(textBox2.Text);
                textBox2.Text = "0";
                First = WytwarzanieOprogramowania.Calc.AND(Convert.ToInt64(First), Convert.ToInt64(holder));

            }
        }
        long pam = WytwarzanieOprogramowania.Calc.pamiec;
        private void MC_Click(object sender, EventArgs e)
        {
            WytwarzanieOprogramowania.Calc.MC(pam);
        }

        private void MR_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(pam);
        }

        private void MS_Click(object sender, EventArgs e)
        {

        }

        private void Mplus_Click(object sender, EventArgs e)
        {
            if (WytwarzanieOprogramowania.Calc.pamiec != 0)
            {
                textBox2.Text = WytwarzanieOprogramowania.Calc.Mplus(Convert.ToInt64(textBox2.Text)).ToString();
            }
            WytwarzanieOprogramowania.Calc.Mplus(Convert.ToInt64(textBox2.Text));
        }

        private void Mminus_Click(object sender, EventArgs e)
        {
            pam=WytwarzanieOprogramowania.Calc.Mminus(Convert.ToInt64(textBox2.Text), pam);
        }
    }
}
