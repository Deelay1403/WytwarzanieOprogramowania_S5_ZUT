
namespace WytwarzanieOprogramowania
{
    partial class TestForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_divide_double = new System.Windows.Forms.Button();
            this.bt_divide_int = new System.Windows.Forms.Button();
            this.bt_multi_double = new System.Windows.Forms.Button();
            this.bt_multi_int = new System.Windows.Forms.Button();
            this.bt_sub_double = new System.Windows.Forms.Button();
            this.bt_sub_int = new System.Windows.Forms.Button();
            this.bt_add_double = new System.Windows.Forms.Button();
            this.bt_add_int = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_divide_double);
            this.groupBox1.Controls.Add(this.bt_divide_int);
            this.groupBox1.Controls.Add(this.bt_multi_double);
            this.groupBox1.Controls.Add(this.bt_multi_int);
            this.groupBox1.Controls.Add(this.bt_sub_double);
            this.groupBox1.Controls.Add(this.bt_sub_int);
            this.groupBox1.Controls.Add(this.bt_add_double);
            this.groupBox1.Controls.Add(this.bt_add_int);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacje arytmetyczne";
            // 
            // bt_divide_double
            // 
            this.bt_divide_double.Location = new System.Drawing.Point(3, 219);
            this.bt_divide_double.Name = "bt_divide_double";
            this.bt_divide_double.Size = new System.Drawing.Size(130, 23);
            this.bt_divide_double.TabIndex = 7;
            this.bt_divide_double.Text = "Divide double";
            this.bt_divide_double.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_divide_double.UseVisualStyleBackColor = true;
            this.bt_divide_double.Enter += new System.EventHandler(this.Divide_double_test);
            // 
            // bt_divide_int
            // 
            this.bt_divide_int.Location = new System.Drawing.Point(3, 190);
            this.bt_divide_int.Name = "bt_divide_int";
            this.bt_divide_int.Size = new System.Drawing.Size(130, 23);
            this.bt_divide_int.TabIndex = 6;
            this.bt_divide_int.Text = "Divide int";
            this.bt_divide_int.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_divide_int.UseVisualStyleBackColor = true;
            this.bt_divide_int.Enter += new System.EventHandler(this.Divide_int_test);
            // 
            // bt_multi_double
            // 
            this.bt_multi_double.Location = new System.Drawing.Point(3, 161);
            this.bt_multi_double.Name = "bt_multi_double";
            this.bt_multi_double.Size = new System.Drawing.Size(130, 23);
            this.bt_multi_double.TabIndex = 5;
            this.bt_multi_double.Text = "Multiply double";
            this.bt_multi_double.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_multi_double.UseVisualStyleBackColor = true;
            this.bt_multi_double.Enter += new System.EventHandler(this.Multi_double_test);
            // 
            // bt_multi_int
            // 
            this.bt_multi_int.Location = new System.Drawing.Point(3, 132);
            this.bt_multi_int.Name = "bt_multi_int";
            this.bt_multi_int.Size = new System.Drawing.Size(130, 23);
            this.bt_multi_int.TabIndex = 4;
            this.bt_multi_int.Text = "Multiply int";
            this.bt_multi_int.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_multi_int.UseVisualStyleBackColor = true;
            this.bt_multi_int.Enter += new System.EventHandler(this.Multi_int_test);
            // 
            // bt_sub_double
            // 
            this.bt_sub_double.Location = new System.Drawing.Point(3, 103);
            this.bt_sub_double.Name = "bt_sub_double";
            this.bt_sub_double.Size = new System.Drawing.Size(130, 23);
            this.bt_sub_double.TabIndex = 3;
            this.bt_sub_double.Text = "Subtract double";
            this.bt_sub_double.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_sub_double.UseVisualStyleBackColor = true;
            this.bt_sub_double.Enter += new System.EventHandler(this.Sub_double_test);
            // 
            // bt_sub_int
            // 
            this.bt_sub_int.Location = new System.Drawing.Point(3, 74);
            this.bt_sub_int.Name = "bt_sub_int";
            this.bt_sub_int.Size = new System.Drawing.Size(130, 23);
            this.bt_sub_int.TabIndex = 2;
            this.bt_sub_int.Text = "Subtract int";
            this.bt_sub_int.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_sub_int.UseVisualStyleBackColor = true;
            this.bt_sub_int.Enter += new System.EventHandler(this.Sub_int_test);
            // 
            // bt_add_double
            // 
            this.bt_add_double.Location = new System.Drawing.Point(3, 45);
            this.bt_add_double.Name = "bt_add_double";
            this.bt_add_double.Size = new System.Drawing.Size(130, 23);
            this.bt_add_double.TabIndex = 1;
            this.bt_add_double.Text = "Add double";
            this.bt_add_double.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_add_double.UseVisualStyleBackColor = true;
            this.bt_add_double.Enter += new System.EventHandler(this.Add_double_test);
            // 
            // bt_add_int
            // 
            this.bt_add_int.CausesValidation = false;
            this.bt_add_int.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_add_int.Location = new System.Drawing.Point(3, 16);
            this.bt_add_int.Name = "bt_add_int";
            this.bt_add_int.Size = new System.Drawing.Size(130, 23);
            this.bt_add_int.TabIndex = 0;
            this.bt_add_int.Text = "Add int";
            this.bt_add_int.UseVisualStyleBackColor = true;
            this.bt_add_int.Enter += new System.EventHandler(this.Add_int_test);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_add_int;
        private System.Windows.Forms.Button bt_add_double;
        private System.Windows.Forms.Button bt_divide_double;
        private System.Windows.Forms.Button bt_divide_int;
        private System.Windows.Forms.Button bt_multi_double;
        private System.Windows.Forms.Button bt_multi_int;
        private System.Windows.Forms.Button bt_sub_double;
        private System.Windows.Forms.Button bt_sub_int;
    }
}

