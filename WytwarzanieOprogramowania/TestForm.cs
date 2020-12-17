using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WytwarzanieOprogramowania
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  

        }
        [DataTestMethod]
        private void Add_int_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Add(2, 2), 4);
                bt_add_int.BackColor = Color.Green;
            }
            catch
            {
                bt_add_int.BackColor = Color.Red;
            }
        }
        [DataTestMethod]
        private void Add_double_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Add(2.1, 2.1), 4.2);
                bt_add_double.BackColor = Color.Green;
            }
            catch
            {
                bt_add_double.BackColor = Color.Red;
            }
        }
        [DataTestMethod]
        private void Sub_int_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Sub(10, 2), 8);
                bt_sub_int.BackColor = Color.Green;
            }
            catch
            {
                bt_sub_int.BackColor = Color.Red;
            }
        }
        [DataTestMethod]
        private void Sub_double_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Sub(10.11, 2.1), 8.01);
                bt_sub_double.BackColor = Color.Green;
            }
            catch
            {
                bt_sub_double.BackColor = Color.Red;
            }
        }
        [DataTestMethod]
        private void Multi_int_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Multiply(5, 5), 25);
                bt_multi_int.BackColor = Color.Green;
            }
            catch
            {
                bt_multi_int.BackColor = Color.Red;
            }
        }
        [DataTestMethod]
        private void Multi_double_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Multiply(5.0, 5.5), 27.5);
                bt_multi_double.BackColor = Color.Green;
            }
            catch
            {
                bt_multi_double.BackColor = Color.Red;
            }
        }
        [DataTestMethod]
        private void Divide_int_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Divide(10, 2), 5);
                bt_divide_int.BackColor = Color.Green;
            }
            catch
            {
                bt_divide_int.BackColor = Color.Red;
            }
        }
        [DataTestMethod]
        private void Divide_double_test(object sender, EventArgs e)
        {
            try
            {
                Assert.AreEqual(Calc.Divide(12.5, 2.5), 5);
                bt_divide_double.BackColor = Color.Green;
            }
            catch
            {
                bt_divide_double.BackColor = Color.Red;
            }
        }
    }
}
