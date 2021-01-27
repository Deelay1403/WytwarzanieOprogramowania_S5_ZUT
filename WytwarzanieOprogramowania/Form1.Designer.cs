using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(217, 228, 241),
                                                                       Color.FromArgb(217, 228, 241),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lnawias = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.RoL = new System.Windows.Forms.Button();
            this.Or = new System.Windows.Forms.Button();
            this.Lsh = new System.Windows.Forms.Button();
            this.Not = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.Button();
            this.Mplus = new System.Windows.Forms.Button();
            this.Mminus = new System.Windows.Forms.Button();
            this.Xor = new System.Windows.Forms.Button();
            this.Ror = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.Rsh = new System.Windows.Forms.Button();
            this.And = new System.Windows.Forms.Button();
            this.Pnawias = new System.Windows.Forms.Button();
            this.strzalka = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.pierwiastek = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.procent = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.siedem = new System.Windows.Forms.Button();
            this.osiem = new System.Windows.Forms.Button();
            this.dziewiec = new System.Windows.Forms.Button();
            this.podzielic = new System.Windows.Forms.Button();
            this.cztery = new System.Windows.Forms.Button();
            this.jeden = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.piec = new System.Windows.Forms.Button();
            this.dwa = new System.Windows.Forms.Button();
            this.szesc = new System.Windows.Forms.Button();
            this.trzy = new System.Windows.Forms.Button();
            this.przecinek = new System.Windows.Forms.Button();
            this.razy = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.ulamek = new System.Windows.Forms.Button();
            this.rownosc = new System.Windows.Forms.Button();
            this.BIN = new System.Windows.Forms.RadioButton();
            this.OCT = new System.Windows.Forms.RadioButton();
            this.DEC = new System.Windows.Forms.RadioButton();
            this.HEX = new System.Windows.Forms.RadioButton();
            this.Qword = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bajt_btn = new System.Windows.Forms.RadioButton();
            this.word_btn = new System.Windows.Forms.RadioButton();
            this.dword_btn = new System.Windows.Forms.RadioButton();
            this.blank_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.HideSelection = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // Lnawias
            // 
            resources.ApplyResources(this.Lnawias, "Lnawias");
            this.Lnawias.Name = "Lnawias";
            this.Lnawias.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // RoL
            // 
            resources.ApplyResources(this.RoL, "RoL");
            this.RoL.Name = "RoL";
            this.RoL.UseVisualStyleBackColor = true;
            this.RoL.Click += new System.EventHandler(this.RoL_Click);
            // 
            // Or
            // 
            resources.ApplyResources(this.Or, "Or");
            this.Or.Name = "Or";
            this.Or.UseVisualStyleBackColor = true;
            this.Or.Click += new System.EventHandler(this.Or_Click);
            // 
            // Lsh
            // 
            resources.ApplyResources(this.Lsh, "Lsh");
            this.Lsh.Name = "Lsh";
            this.Lsh.UseVisualStyleBackColor = true;
            this.Lsh.Click += new System.EventHandler(this.Lsh_Click);
            // 
            // Not
            // 
            resources.ApplyResources(this.Not, "Not");
            this.Not.Name = "Not";
            this.Not.UseVisualStyleBackColor = true;
            this.Not.Click += new System.EventHandler(this.Not_Click);
            // 
            // Mod
            // 
            resources.ApplyResources(this.Mod, "Mod");
            this.Mod.Name = "Mod";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.Mod_Click);
            // 
            // A
            // 
            resources.ApplyResources(this.A, "A");
            this.A.Name = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // MC
            // 
            resources.ApplyResources(this.MC, "MC");
            this.MC.Name = "MC";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // MR
            // 
            resources.ApplyResources(this.MR, "MR");
            this.MR.Name = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // MS
            // 
            resources.ApplyResources(this.MS, "MS");
            this.MS.Name = "MS";
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.MS_Click);
            // 
            // Mplus
            // 
            resources.ApplyResources(this.Mplus, "Mplus");
            this.Mplus.Name = "Mplus";
            this.Mplus.UseVisualStyleBackColor = true;
            this.Mplus.Click += new System.EventHandler(this.Mplus_Click);
            // 
            // Mminus
            // 
            resources.ApplyResources(this.Mminus, "Mminus");
            this.Mminus.Name = "Mminus";
            this.Mminus.UseVisualStyleBackColor = true;
            this.Mminus.Click += new System.EventHandler(this.Mminus_Click);
            // 
            // Xor
            // 
            resources.ApplyResources(this.Xor, "Xor");
            this.Xor.Name = "Xor";
            this.Xor.UseVisualStyleBackColor = true;
            this.Xor.Click += new System.EventHandler(this.Xor_Click);
            // 
            // Ror
            // 
            resources.ApplyResources(this.Ror, "Ror");
            this.Ror.Name = "Ror";
            this.Ror.UseVisualStyleBackColor = true;
            this.Ror.Click += new System.EventHandler(this.Ror_Click);
            // 
            // B
            // 
            resources.ApplyResources(this.B, "B");
            this.B.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.B.Name = "B";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // Rsh
            // 
            resources.ApplyResources(this.Rsh, "Rsh");
            this.Rsh.Name = "Rsh";
            this.Rsh.UseVisualStyleBackColor = true;
            this.Rsh.Click += new System.EventHandler(this.Rsh_Click);
            // 
            // And
            // 
            resources.ApplyResources(this.And, "And");
            this.And.Name = "And";
            this.And.UseVisualStyleBackColor = true;
            this.And.Click += new System.EventHandler(this.And_Click);
            // 
            // Pnawias
            // 
            resources.ApplyResources(this.Pnawias, "Pnawias");
            this.Pnawias.Name = "Pnawias";
            this.Pnawias.UseVisualStyleBackColor = true;
            // 
            // strzalka
            // 
            resources.ApplyResources(this.strzalka, "strzalka");
            this.strzalka.Name = "strzalka";
            this.strzalka.UseVisualStyleBackColor = true;
            this.strzalka.Click += new System.EventHandler(this.strzalka_Click);
            // 
            // CE
            // 
            resources.ApplyResources(this.CE, "CE");
            this.CE.Name = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // plusMinus
            // 
            resources.ApplyResources(this.plusMinus, "plusMinus");
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.UseVisualStyleBackColor = true;
            this.plusMinus.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // pierwiastek
            // 
            resources.ApplyResources(this.pierwiastek, "pierwiastek");
            this.pierwiastek.Name = "pierwiastek";
            this.pierwiastek.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            resources.ApplyResources(this.D, "D");
            this.D.Name = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // E
            // 
            resources.ApplyResources(this.E, "E");
            this.E.Name = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // F
            // 
            resources.ApplyResources(this.F, "F");
            this.F.Name = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // procent
            // 
            resources.ApplyResources(this.procent, "procent");
            this.procent.Name = "procent";
            this.procent.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            resources.ApplyResources(this.C, "C");
            this.C.Name = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // siedem
            // 
            resources.ApplyResources(this.siedem, "siedem");
            this.siedem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.siedem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
            this.siedem.FlatAppearance.BorderSize = 0;
            this.siedem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(87)))));
            this.siedem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(87)))));
            this.siedem.Name = "siedem";
            this.siedem.UseVisualStyleBackColor = false;
            this.siedem.Click += new System.EventHandler(this.siedem_Click);
            // 
            // osiem
            // 
            resources.ApplyResources(this.osiem, "osiem");
            this.osiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.osiem.Name = "osiem";
            this.osiem.UseVisualStyleBackColor = true;
            this.osiem.Click += new System.EventHandler(this.osiem_Click);
            // 
            // dziewiec
            // 
            resources.ApplyResources(this.dziewiec, "dziewiec");
            this.dziewiec.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dziewiec.FlatAppearance.BorderSize = 0;
            this.dziewiec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(204)))), ((int)(((byte)(135)))));
            this.dziewiec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(198)))));
            this.dziewiec.Name = "dziewiec";
            this.dziewiec.UseVisualStyleBackColor = true;
            this.dziewiec.Click += new System.EventHandler(this.dziewiec_Click);
            // 
            // podzielic
            // 
            resources.ApplyResources(this.podzielic, "podzielic");
            this.podzielic.Name = "podzielic";
            this.podzielic.UseVisualStyleBackColor = true;
            this.podzielic.Click += new System.EventHandler(this.podzielic_Click);
            // 
            // cztery
            // 
            resources.ApplyResources(this.cztery, "cztery");
            this.cztery.Name = "cztery";
            this.cztery.UseVisualStyleBackColor = true;
            this.cztery.Click += new System.EventHandler(this.cztery_Click);
            // 
            // jeden
            // 
            resources.ApplyResources(this.jeden, "jeden");
            this.jeden.Name = "jeden";
            this.jeden.UseVisualStyleBackColor = true;
            this.jeden.Click += new System.EventHandler(this.jeden_Click);
            // 
            // zero
            // 
            resources.ApplyResources(this.zero, "zero");
            this.zero.Name = "zero";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // piec
            // 
            resources.ApplyResources(this.piec, "piec");
            this.piec.Name = "piec";
            this.piec.UseVisualStyleBackColor = true;
            this.piec.Click += new System.EventHandler(this.piec_Click);
            // 
            // dwa
            // 
            resources.ApplyResources(this.dwa, "dwa");
            this.dwa.Name = "dwa";
            this.dwa.UseVisualStyleBackColor = true;
            this.dwa.Click += new System.EventHandler(this.dwa_Click);
            // 
            // szesc
            // 
            resources.ApplyResources(this.szesc, "szesc");
            this.szesc.Name = "szesc";
            this.szesc.UseVisualStyleBackColor = true;
            this.szesc.Click += new System.EventHandler(this.szesc_Click);
            // 
            // trzy
            // 
            resources.ApplyResources(this.trzy, "trzy");
            this.trzy.Name = "trzy";
            this.trzy.UseVisualStyleBackColor = true;
            this.trzy.Click += new System.EventHandler(this.trzy_Click);
            // 
            // przecinek
            // 
            resources.ApplyResources(this.przecinek, "przecinek");
            this.przecinek.Name = "przecinek";
            this.przecinek.UseVisualStyleBackColor = true;
            // 
            // razy
            // 
            resources.ApplyResources(this.razy, "razy");
            this.razy.Name = "razy";
            this.razy.UseVisualStyleBackColor = true;
            this.razy.Click += new System.EventHandler(this.razy_Click);
            // 
            // minus
            // 
            resources.ApplyResources(this.minus, "minus");
            this.minus.Name = "minus";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            resources.ApplyResources(this.plus, "plus");
            this.plus.Name = "plus";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // ulamek
            // 
            resources.ApplyResources(this.ulamek, "ulamek");
            this.ulamek.Name = "ulamek";
            this.ulamek.UseVisualStyleBackColor = true;
            // 
            // rownosc
            // 
            resources.ApplyResources(this.rownosc, "rownosc");
            this.rownosc.Name = "rownosc";
            this.rownosc.UseVisualStyleBackColor = true;
            this.rownosc.Click += new System.EventHandler(this.rownosc_Click);
            // 
            // BIN
            // 
            resources.ApplyResources(this.BIN, "BIN");
            this.BIN.Name = "BIN";
            this.BIN.TabStop = true;
            this.BIN.UseVisualStyleBackColor = true;
            this.BIN.CheckedChanged += new System.EventHandler(this.BIN_CheckedChanged);
            // 
            // OCT
            // 
            resources.ApplyResources(this.OCT, "OCT");
            this.OCT.Name = "OCT";
            this.OCT.TabStop = true;
            this.OCT.UseVisualStyleBackColor = true;
            this.OCT.CheckedChanged += new System.EventHandler(this.OCT_CheckedChanged);
            // 
            // DEC
            // 
            resources.ApplyResources(this.DEC, "DEC");
            this.DEC.Name = "DEC";
            this.DEC.TabStop = true;
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.CheckedChanged += new System.EventHandler(this.DEC_CheckedChanged);
            // 
            // HEX
            // 
            resources.ApplyResources(this.HEX, "HEX");
            this.HEX.Name = "HEX";
            this.HEX.TabStop = true;
            this.HEX.UseVisualStyleBackColor = true;
            this.HEX.CheckedChanged += new System.EventHandler(this.HEX_CheckedChanged);
            // 
            // Qword
            // 
            resources.ApplyResources(this.Qword, "Qword");
            this.Qword.Name = "Qword";
            this.Qword.TabStop = true;
            this.Qword.UseVisualStyleBackColor = true;
            this.Qword.CheckedChanged += new System.EventHandler(this.qword_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.BIN);
            this.groupBox1.Controls.Add(this.OCT);
            this.groupBox1.Controls.Add(this.HEX);
            this.groupBox1.Controls.Add(this.DEC);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.bajt_btn);
            this.groupBox2.Controls.Add(this.word_btn);
            this.groupBox2.Controls.Add(this.dword_btn);
            this.groupBox2.Controls.Add(this.Qword);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // bajt_btn
            // 
            resources.ApplyResources(this.bajt_btn, "bajt_btn");
            this.bajt_btn.Name = "bajt_btn";
            this.bajt_btn.TabStop = true;
            this.bajt_btn.UseVisualStyleBackColor = true;
            this.bajt_btn.CheckedChanged += new System.EventHandler(this.bajt_btn_CheckedChanged);
            // 
            // word_btn
            // 
            resources.ApplyResources(this.word_btn, "word_btn");
            this.word_btn.Name = "word_btn";
            this.word_btn.TabStop = true;
            this.word_btn.UseVisualStyleBackColor = true;
            this.word_btn.CheckedChanged += new System.EventHandler(this.word_btn_CheckedChanged);
            // 
            // dword_btn
            // 
            resources.ApplyResources(this.dword_btn, "dword_btn");
            this.dword_btn.Name = "dword_btn";
            this.dword_btn.TabStop = true;
            this.dword_btn.UseVisualStyleBackColor = true;
            this.dword_btn.CheckedChanged += new System.EventHandler(this.dword_CheckedChanged);
            // 
            // blank_button
            // 
            resources.ApplyResources(this.blank_button, "blank_button");
            this.blank_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.blank_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blank_button.Name = "blank_button";
            this.blank_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.blank_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rownosc);
            this.Controls.Add(this.ulamek);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.razy);
            this.Controls.Add(this.przecinek);
            this.Controls.Add(this.trzy);
            this.Controls.Add(this.szesc);
            this.Controls.Add(this.dwa);
            this.Controls.Add(this.piec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.jeden);
            this.Controls.Add(this.cztery);
            this.Controls.Add(this.podzielic);
            this.Controls.Add(this.dziewiec);
            this.Controls.Add(this.osiem);
            this.Controls.Add(this.siedem);
            this.Controls.Add(this.C);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.pierwiastek);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.strzalka);
            this.Controls.Add(this.Pnawias);
            this.Controls.Add(this.And);
            this.Controls.Add(this.Rsh);
            this.Controls.Add(this.B);
            this.Controls.Add(this.Ror);
            this.Controls.Add(this.Xor);
            this.Controls.Add(this.Mminus);
            this.Controls.Add(this.Mplus);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Not);
            this.Controls.Add(this.Lsh);
            this.Controls.Add(this.Or);
            this.Controls.Add(this.RoL);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Lnawias);
            this.Controls.Add(this.textBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Lnawias;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button RoL;
        private System.Windows.Forms.Button Or;
        private System.Windows.Forms.Button Lsh;
        private System.Windows.Forms.Button Not;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button MS;
        private System.Windows.Forms.Button Mplus;
        private System.Windows.Forms.Button Mminus;
        private System.Windows.Forms.Button Xor;
        private System.Windows.Forms.Button Ror;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button Rsh;
        private System.Windows.Forms.Button And;
        private System.Windows.Forms.Button Pnawias;
        private System.Windows.Forms.Button strzalka;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.Button pierwiastek;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button procent;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button siedem;
        private System.Windows.Forms.Button osiem;
        private System.Windows.Forms.Button dziewiec;
        private System.Windows.Forms.Button podzielic;
        private System.Windows.Forms.Button cztery;
        private System.Windows.Forms.Button jeden;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button piec;
        private System.Windows.Forms.Button dwa;
        private System.Windows.Forms.Button szesc;
        private System.Windows.Forms.Button trzy;
        private System.Windows.Forms.Button przecinek;
        private System.Windows.Forms.Button razy;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button ulamek;
        private System.Windows.Forms.Button rownosc;
        private RadioButton BIN;
        private RadioButton OCT;
        private RadioButton DEC;
        private RadioButton HEX;
        private RadioButton Qword;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton word_btn;
        private RadioButton dword_btn;
        private RadioButton bajt_btn;
        private Button blank_button;
    }
}



