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
        enum masks
        {
            Qword,
            Dword,
            Word,
            Byte
        }
        enum number_types : int
        {
            hex = 16,
            dec = 10,
            oct = 8,
            bin = 2
        }

        dynamic mask = masks.Dword;
        int type = (int)number_types.dec;
        long First;
        string Operation = "0";
        long holder;
        long memory_number = 0;
        public Form1()
        {
            InitializeComponent();
            DEC.Select();
            dword_btn.Select();
            blank_button.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setView("0");
        }
        private void setView(string s)
        {
            textBox2.Text = s;
        }
        private string getView()
        {
            return textBox2.Text;
        }
        //changeViewWithValidate("", false);
        private int changeViewWithValidate(String s, bool isButton = true)
        {
            dynamic num = convertToType(Convert.ToString(getView()+s),this.type);
            dynamic whole_number = convertToType(Convert.ToString(getView() + s), this.type, true);
            dynamic min = 0;
            dynamic max = 0;
            string new_text = "";
            if (getView() == "0" && getView() != null)
            {
                setView(s);
                return 0;
            }
            if (this.mask is masks.Byte)
            {
                new_text = WytwarzanieOprogramowania.Calc.Byte(num).ToString();
                min = sbyte.MinValue;
                max = sbyte.MaxValue;
            }
            else if (this.mask is masks.Word)
            {
                new_text = WytwarzanieOprogramowania.Calc.Word(num).ToString();
                min = short.MinValue;
                max = short.MaxValue;
            }
            else if (this.mask is masks.Dword)
            {
                new_text = WytwarzanieOprogramowania.Calc.DWord(num).ToString();
                min = int.MinValue;
                max = int.MaxValue;
            }
            else if (this.mask is masks.Qword)
            {
                new_text = WytwarzanieOprogramowania.Calc.QWord(num).ToString();
                min = long.MinValue;
                max = long.MaxValue;
            }
            new_text = (WytwarzanieOprogramowania.Calc.convert(Convert.ToInt64(new_text), this.type));
            //bool test = ((num > min && num < max) || (isButton is true));
            if((whole_number < min && whole_number > max) && isButton == true)
            {
                return 0;
            }else if((whole_number >= min && whole_number <= max) || isButton is false)
            {
                setView(new_text);
                return 0;
            }
            return 0;
        }

        private void jeden_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("1");
        }

        private void dwa_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("2");
        }

        private void trzy_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("3");
        }

        private void cztery_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("4");
        }

        private void piec_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("5");
        }

        private void szesc_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("6");
        }

        private void siedem_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("7");
        }

        private void osiem_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("8");
        }

        private void dziewiec_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("0");
        }
        private void A_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("a");
        }

        private void B_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("b");
        }

        private void C_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("c");
        }

        private void D_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("d");
        }

        private void E_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("e");
        }

        private void F_Click(object sender, EventArgs e)
        {
                changeViewWithValidate("f");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (Operation =="0")
            {
                First = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                Operation = "+";
            }
            else
            {
                holder = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                First = WytwarzanieOprogramowania.Calc.Add(First, holder);
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {

            if (Operation == "0")
            {
                First = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                Operation = "-";
            }
            else
            {
                holder = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                First = WytwarzanieOprogramowania.Calc.Sub(First, holder);

            }
        }

        private void razy_Click(object sender, EventArgs e)
        {

            if (Operation == "0")
            {
                First = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                Operation = "*";
            }
            else
            {
                holder = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                First = WytwarzanieOprogramowania.Calc.Multiply(First, holder);

            }
        }

        private void podzielic_Click(object sender, EventArgs e)
        {

            if (Operation == "0")
            {
                First = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                Operation = "/";
            }
            else
            {
                holder = convertToType(Convert.ToString(getView()), this.type, true);
                setView("0");
                First = WytwarzanieOprogramowania.Calc.Divide(First, holder);

            }
        }

        private void rownosc_print_helping_funct(long result)
        {
            setView("");
            changeViewWithValidate(
            WytwarzanieOprogramowania.Calc.convert(
                result, this.type),
                false);
            First = result;
        }
        private void rownosc_Click(object sender, EventArgs e)
        {
            long SecondNumber;
            long Result;

            SecondNumber = convertToType(Convert.ToString(getView()), this.type, true);

            if (Operation == "+")
            {
                Result = WytwarzanieOprogramowania.Calc.Add(First, SecondNumber);
                rownosc_print_helping_funct(Result);
            }
            else if (Operation == "-")
            {
                Result = WytwarzanieOprogramowania.Calc.Sub(First, SecondNumber);
                rownosc_print_helping_funct(Result);
            }
            else if (Operation == "*")
            {
                Result = WytwarzanieOprogramowania.Calc.Multiply(First, SecondNumber);
                rownosc_print_helping_funct(Result);
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
                    rownosc_print_helping_funct(Result);
                }
            }
            else if (Operation == "%")
            {
                Result = WytwarzanieOprogramowania.Calc.Modulo(First, SecondNumber);
                rownosc_print_helping_funct(Result);
            }

            else if (Operation == "or")
            {
                Result = WytwarzanieOprogramowania.Calc.OR(Convert.ToInt64(First), Convert.ToInt64(SecondNumber));
                rownosc_print_helping_funct(Result);
            }

            else if (Operation == "xor")
            {
                Result = WytwarzanieOprogramowania.Calc.XOR(Convert.ToInt64(First), Convert.ToInt64(SecondNumber));
                rownosc_print_helping_funct(Result);
            }

            else if (Operation == "and")
            {
                Result = WytwarzanieOprogramowania.Calc.AND(Convert.ToInt64(First), Convert.ToInt64(SecondNumber));
                rownosc_print_helping_funct(Result);
            }
            else if (Operation == "<<")
            {
                Result = WytwarzanieOprogramowania.Calc.Lsh(Convert.ToInt64(First), Convert.ToInt32(SecondNumber));
                rownosc_print_helping_funct(Result);
            }

            else if (Operation == ">>")
            {
                Result = WytwarzanieOprogramowania.Calc.Rsh(Convert.ToInt64(First), Convert.ToInt32(SecondNumber));
                rownosc_print_helping_funct(Result);
            }
            this.Operation = "0";
        }
        private dynamic convertToType(string str, int sys, bool ignoreMask = false)
        {
            str = str == "" ? "0" : str;
            long num = Convert.ToInt64(str, sys);
            if (ignoreMask)
                return num;
            if (this.mask is masks.Byte)
                return WytwarzanieOprogramowania.Calc.Byte(num);
            else if (this.mask is masks.Word)
                return WytwarzanieOprogramowania.Calc.Word(num);
            else if (this.mask is masks.Dword)
                return WytwarzanieOprogramowania.Calc.DWord(num);
            else if (this.mask is masks.Qword)
                return WytwarzanieOprogramowania.Calc.QWord(num);
            return -1;
        }
        private dynamic convertToType(int sys)
        {
            return convertToType(getView(), sys);
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
            setView(WytwarzanieOprogramowania.Calc.convert(convertToType(this.type), 2));
            this.type = (int)number_types.bin;
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
            setView(WytwarzanieOprogramowania.Calc.convert(convertToType(this.type), 8));
            this.type = (int)number_types.oct;
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
            setView(WytwarzanieOprogramowania.Calc.convert(convertToType(this.type), 10));
            this.type = (int)number_types.dec;
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
            setView(WytwarzanieOprogramowania.Calc.convert(convertToType(this.type), 16));
            this.type = (int)number_types.hex;
        }

        private void strzalka_Click(object sender, EventArgs e)
        {
           string Result;
            if (textBox2.Text.Length > 1) { Result = WytwarzanieOprogramowania.Calc.Backspace(getView()); setView(Convert.ToString(Result)); }
            else if (textBox2.Text.Length == 1) { setView("0"); }

        }

        private void Ror_Click(object sender, EventArgs e)
        {
            //sprawdzic co sie dzieje w normalnym jak masz 0
            setView(
                WytwarzanieOprogramowania.Calc.convert(
                    Convert.ToString(WytwarzanieOprogramowania.Calc.Ror(
                convertToType(this.type))), this.type));
        }

        private void RoL_Click(object sender, EventArgs e)
        {
            setView(
                WytwarzanieOprogramowania.Calc.convert(
                    Convert.ToString(WytwarzanieOprogramowania.Calc.Rol(
                convertToType(this.type))),this.type));

        }

        private void CE_Click(object sender, EventArgs e)
        {
            string Result;
            Result=WytwarzanieOprogramowania.Calc.CE();
            textBox2.Text = Convert.ToString(Result);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            First = holder = WytwarzanieOprogramowania.Calc.C();
            setView(Convert.ToString(WytwarzanieOprogramowania.Calc.C()));
            Operation = "0";
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {

            setView(WytwarzanieOprogramowania.Calc.toString(
                WytwarzanieOprogramowania.Calc.PlusMinus(
                    convertToType(this.type)
                    )));

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
            WytwarzanieOprogramowania.Calc.MC(ref this.memory_number);
        }
        private void MR_Click(object sender, EventArgs e)
        {
            setView(WytwarzanieOprogramowania.Calc.toString(
                this.memory_number));
        }
        private void MS_Click(object sender, EventArgs e)
        {
            setView(WytwarzanieOprogramowania.Calc.toString(this.memory_number));
            WytwarzanieOprogramowania.Calc.MC(ref this.memory_number);
        }
        private void Mplus_Click(object sender, EventArgs e)
        {
            WytwarzanieOprogramowania.Calc.Mplus(
                convertToType(this.type),
                ref this.memory_number);
        }

        private void Mminus_Click(object sender, EventArgs e)
        {
            WytwarzanieOprogramowania.Calc.Mminus(
                convertToType(this.type),
                ref this.memory_number);
        }

        private void dword_CheckedChanged(object sender, EventArgs e)
        {
            this.mask = masks.Dword;
            changeViewWithValidate("", false);
        }

        private void qword_CheckedChanged(object sender, EventArgs e)
        {
            this.mask = masks.Qword;
            changeViewWithValidate("", false);
        }

        private void word_btn_CheckedChanged(object sender, EventArgs e)
        {
            this.mask = masks.Word;
            changeViewWithValidate("", false);
        }

        private void bajt_btn_CheckedChanged(object sender, EventArgs e)
        {
            this.mask = masks.Byte;
            changeViewWithValidate("", false);
        }

    }
}
