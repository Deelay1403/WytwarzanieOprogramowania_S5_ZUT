﻿namespace GUI
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lnawias = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Hex = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
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
            this.button33 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 67);
            this.textBox2.TabIndex = 0;
            // 
            // Lnawias
            // 
            this.Lnawias.Location = new System.Drawing.Point(71, 122);
            this.Lnawias.Name = "Lnawias";
            this.Lnawias.Size = new System.Drawing.Size(41, 31);
            this.Lnawias.TabIndex = 4;
            this.Lnawias.Text = "(";
            this.Lnawias.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(283, 186);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(8, 8);
            this.button14.TabIndex = 6;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // Hex
            // 
            this.Hex.FormattingEnabled = true;
            this.Hex.Items.AddRange(new object[] {
            "Hex",
            "Dec",
            "Oct",
            "Bin"});
            this.Hex.Location = new System.Drawing.Point(2, 85);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(62, 109);
            this.Hex.TabIndex = 7;
            this.Hex.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Qword",
            "Dword",
            "Word",
            "Bajt"});
            this.checkedListBox1.Location = new System.Drawing.Point(2, 195);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(62, 109);
            this.checkedListBox1.TabIndex = 8;
            // 
            // RoL
            // 
            this.RoL.Location = new System.Drawing.Point(71, 163);
            this.RoL.Name = "RoL";
            this.RoL.Size = new System.Drawing.Size(41, 31);
            this.RoL.TabIndex = 9;
            this.RoL.Text = "RoL";
            this.RoL.UseVisualStyleBackColor = true;
            // 
            // Or
            // 
            this.Or.Location = new System.Drawing.Point(71, 200);
            this.Or.Name = "Or";
            this.Or.Size = new System.Drawing.Size(41, 31);
            this.Or.TabIndex = 10;
            this.Or.Text = "Or";
            this.Or.UseVisualStyleBackColor = true;
            // 
            // Lsh
            // 
            this.Lsh.Location = new System.Drawing.Point(71, 237);
            this.Lsh.Name = "Lsh";
            this.Lsh.Size = new System.Drawing.Size(41, 31);
            this.Lsh.TabIndex = 11;
            this.Lsh.Text = "Lsh";
            this.Lsh.UseVisualStyleBackColor = true;
            this.Lsh.Click += new System.EventHandler(this.button17_Click);
            // 
            // Not
            // 
            this.Not.Location = new System.Drawing.Point(71, 274);
            this.Not.Name = "Not";
            this.Not.Size = new System.Drawing.Size(41, 31);
            this.Not.TabIndex = 12;
            this.Not.Text = "Not";
            this.Not.UseVisualStyleBackColor = true;
            this.Not.Click += new System.EventHandler(this.button18_Click);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(117, 85);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(41, 31);
            this.Mod.TabIndex = 13;
            this.Mod.Text = "Mod";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.Mod_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(164, 85);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(41, 31);
            this.A.TabIndex = 14;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(211, 85);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(41, 31);
            this.MC.TabIndex = 15;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(258, 85);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(41, 31);
            this.MR.TabIndex = 16;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(305, 85);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(41, 31);
            this.MS.TabIndex = 17;
            this.MS.Text = "MS";
            this.MS.UseVisualStyleBackColor = true;
            // 
            // Mplus
            // 
            this.Mplus.Location = new System.Drawing.Point(352, 85);
            this.Mplus.Name = "Mplus";
            this.Mplus.Size = new System.Drawing.Size(41, 31);
            this.Mplus.TabIndex = 18;
            this.Mplus.Text = "M+";
            this.Mplus.UseVisualStyleBackColor = true;
            // 
            // Mminus
            // 
            this.Mminus.Location = new System.Drawing.Point(399, 85);
            this.Mminus.Name = "Mminus";
            this.Mminus.Size = new System.Drawing.Size(41, 31);
            this.Mminus.TabIndex = 19;
            this.Mminus.Text = "M-";
            this.Mminus.UseVisualStyleBackColor = true;
            // 
            // Xor
            // 
            this.Xor.Location = new System.Drawing.Point(118, 200);
            this.Xor.Name = "Xor";
            this.Xor.Size = new System.Drawing.Size(41, 31);
            this.Xor.TabIndex = 20;
            this.Xor.Text = "Xor";
            this.Xor.UseVisualStyleBackColor = true;
            // 
            // Ror
            // 
            this.Ror.Location = new System.Drawing.Point(118, 163);
            this.Ror.Name = "Ror";
            this.Ror.Size = new System.Drawing.Size(41, 31);
            this.Ror.TabIndex = 21;
            this.Ror.Text = "RoR";
            this.Ror.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(165, 122);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(41, 31);
            this.B.TabIndex = 22;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // Rsh
            // 
            this.Rsh.Location = new System.Drawing.Point(118, 237);
            this.Rsh.Name = "Rsh";
            this.Rsh.Size = new System.Drawing.Size(41, 31);
            this.Rsh.TabIndex = 23;
            this.Rsh.Text = "Rsh";
            this.Rsh.UseVisualStyleBackColor = true;
            // 
            // And
            // 
            this.And.Location = new System.Drawing.Point(118, 274);
            this.And.Name = "And";
            this.And.Size = new System.Drawing.Size(41, 31);
            this.And.TabIndex = 24;
            this.And.Text = "And";
            this.And.UseVisualStyleBackColor = true;
            this.And.Click += new System.EventHandler(this.button27_Click);
            // 
            // Pnawias
            // 
            this.Pnawias.Location = new System.Drawing.Point(118, 122);
            this.Pnawias.Name = "Pnawias";
            this.Pnawias.Size = new System.Drawing.Size(41, 31);
            this.Pnawias.TabIndex = 25;
            this.Pnawias.Text = ")";
            this.Pnawias.UseVisualStyleBackColor = true;
            // 
            // strzalka
            // 
            this.strzalka.Location = new System.Drawing.Point(211, 122);
            this.strzalka.Name = "strzalka";
            this.strzalka.Size = new System.Drawing.Size(41, 31);
            this.strzalka.TabIndex = 26;
            this.strzalka.Text = "<--";
            this.strzalka.UseVisualStyleBackColor = true;
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(258, 122);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(41, 31);
            this.CE.TabIndex = 27;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(305, 122);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(41, 31);
            this.Clear.TabIndex = 28;
            this.Clear.Text = "c";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // plusMinus
            // 
            this.plusMinus.Location = new System.Drawing.Point(352, 122);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(41, 31);
            this.plusMinus.TabIndex = 29;
            this.plusMinus.Text = "±";
            this.plusMinus.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(399, 122);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(41, 31);
            this.button33.TabIndex = 30;
            this.button33.Text = "√";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(165, 200);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(41, 31);
            this.D.TabIndex = 31;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(164, 237);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(41, 31);
            this.E.TabIndex = 32;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(164, 274);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(41, 31);
            this.F.TabIndex = 33;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // procent
            // 
            this.procent.Location = new System.Drawing.Point(399, 163);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(41, 31);
            this.procent.TabIndex = 34;
            this.procent.Text = "%";
            this.procent.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(165, 163);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(41, 31);
            this.C.TabIndex = 35;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // siedem
            // 
            this.siedem.Location = new System.Drawing.Point(211, 163);
            this.siedem.Name = "siedem";
            this.siedem.Size = new System.Drawing.Size(41, 31);
            this.siedem.TabIndex = 36;
            this.siedem.Text = "7";
            this.siedem.UseVisualStyleBackColor = true;
            // 
            // osiem
            // 
            this.osiem.Location = new System.Drawing.Point(258, 163);
            this.osiem.Name = "osiem";
            this.osiem.Size = new System.Drawing.Size(41, 31);
            this.osiem.TabIndex = 37;
            this.osiem.Text = "8";
            this.osiem.UseVisualStyleBackColor = true;
            // 
            // dziewiec
            // 
            this.dziewiec.Location = new System.Drawing.Point(305, 163);
            this.dziewiec.Name = "dziewiec";
            this.dziewiec.Size = new System.Drawing.Size(41, 31);
            this.dziewiec.TabIndex = 38;
            this.dziewiec.Text = "9";
            this.dziewiec.UseVisualStyleBackColor = true;
            // 
            // podzielic
            // 
            this.podzielic.Location = new System.Drawing.Point(352, 163);
            this.podzielic.Name = "podzielic";
            this.podzielic.Size = new System.Drawing.Size(41, 31);
            this.podzielic.TabIndex = 39;
            this.podzielic.Text = "/";
            this.podzielic.UseVisualStyleBackColor = true;
            this.podzielic.Click += new System.EventHandler(this.button42_Click);
            // 
            // cztery
            // 
            this.cztery.Location = new System.Drawing.Point(212, 200);
            this.cztery.Name = "cztery";
            this.cztery.Size = new System.Drawing.Size(41, 31);
            this.cztery.TabIndex = 40;
            this.cztery.Text = "4";
            this.cztery.UseVisualStyleBackColor = true;
            // 
            // jeden
            // 
            this.jeden.Location = new System.Drawing.Point(212, 237);
            this.jeden.Name = "jeden";
            this.jeden.Size = new System.Drawing.Size(41, 31);
            this.jeden.TabIndex = 41;
            this.jeden.Text = "1";
            this.jeden.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(211, 274);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(89, 31);
            this.zero.TabIndex = 42;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button45_Click);
            // 
            // piec
            // 
            this.piec.Location = new System.Drawing.Point(259, 200);
            this.piec.Name = "piec";
            this.piec.Size = new System.Drawing.Size(41, 31);
            this.piec.TabIndex = 43;
            this.piec.Text = "5";
            this.piec.UseVisualStyleBackColor = true;
            // 
            // dwa
            // 
            this.dwa.Location = new System.Drawing.Point(258, 237);
            this.dwa.Name = "dwa";
            this.dwa.Size = new System.Drawing.Size(41, 31);
            this.dwa.TabIndex = 44;
            this.dwa.Text = "2";
            this.dwa.UseVisualStyleBackColor = true;
            // 
            // szesc
            // 
            this.szesc.Location = new System.Drawing.Point(305, 200);
            this.szesc.Name = "szesc";
            this.szesc.Size = new System.Drawing.Size(41, 31);
            this.szesc.TabIndex = 46;
            this.szesc.Text = "6";
            this.szesc.UseVisualStyleBackColor = true;
            // 
            // trzy
            // 
            this.trzy.Location = new System.Drawing.Point(305, 237);
            this.trzy.Name = "trzy";
            this.trzy.Size = new System.Drawing.Size(41, 31);
            this.trzy.TabIndex = 47;
            this.trzy.Text = "3";
            this.trzy.UseVisualStyleBackColor = true;
            // 
            // przecinek
            // 
            this.przecinek.Location = new System.Drawing.Point(305, 274);
            this.przecinek.Name = "przecinek";
            this.przecinek.Size = new System.Drawing.Size(41, 31);
            this.przecinek.TabIndex = 48;
            this.przecinek.Text = ",";
            this.przecinek.UseVisualStyleBackColor = true;
            // 
            // razy
            // 
            this.razy.Location = new System.Drawing.Point(352, 200);
            this.razy.Name = "razy";
            this.razy.Size = new System.Drawing.Size(41, 31);
            this.razy.TabIndex = 49;
            this.razy.Text = "*";
            this.razy.UseVisualStyleBackColor = true;
            this.razy.Click += new System.EventHandler(this.button52_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(352, 237);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(41, 31);
            this.minus.TabIndex = 50;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(352, 274);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(41, 31);
            this.plus.TabIndex = 51;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // ulamek
            // 
            this.ulamek.Location = new System.Drawing.Point(399, 200);
            this.ulamek.Name = "ulamek";
            this.ulamek.Size = new System.Drawing.Size(41, 31);
            this.ulamek.TabIndex = 52;
            this.ulamek.Text = "1/x";
            this.ulamek.UseVisualStyleBackColor = true;
            // 
            // rownosc
            // 
            this.rownosc.Location = new System.Drawing.Point(399, 237);
            this.rownosc.Name = "rownosc";
            this.rownosc.Size = new System.Drawing.Size(41, 68);
            this.rownosc.TabIndex = 53;
            this.rownosc.Text = "=";
            this.rownosc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(445, 312);
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
            this.Controls.Add(this.button33);
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
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Lnawias);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Lnawias;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.CheckedListBox Hex;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
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
        private System.Windows.Forms.Button button33;
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
    }
}
