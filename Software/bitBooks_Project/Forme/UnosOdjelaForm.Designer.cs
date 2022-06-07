namespace bitBooks_Project.Forme
{
    partial class UnosOdjelaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbKnjižnica = new System.Windows.Forms.ComboBox();
            this.txtPoštanskiBroj = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtImeOdjela = new System.Windows.Forms.TextBox();
            this.txtBrojOdjela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKnjižnica
            // 
            this.cmbKnjižnica.FormattingEnabled = true;
            this.cmbKnjižnica.Location = new System.Drawing.Point(122, 29);
            this.cmbKnjižnica.Name = "cmbKnjižnica";
            this.cmbKnjižnica.Size = new System.Drawing.Size(187, 21);
            this.cmbKnjižnica.TabIndex = 0;
            // 
            // txtPoštanskiBroj
            // 
            this.txtPoštanskiBroj.Location = new System.Drawing.Point(122, 66);
            this.txtPoštanskiBroj.Name = "txtPoštanskiBroj";
            this.txtPoštanskiBroj.Size = new System.Drawing.Size(187, 20);
            this.txtPoštanskiBroj.TabIndex = 1;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(122, 106);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(187, 20);
            this.txtAdresa.TabIndex = 2;
            // 
            // txtImeOdjela
            // 
            this.txtImeOdjela.Location = new System.Drawing.Point(122, 148);
            this.txtImeOdjela.Name = "txtImeOdjela";
            this.txtImeOdjela.Size = new System.Drawing.Size(187, 20);
            this.txtImeOdjela.TabIndex = 3;
            // 
            // txtBrojOdjela
            // 
            this.txtBrojOdjela.Location = new System.Drawing.Point(122, 192);
            this.txtBrojOdjela.Name = "txtBrojOdjela";
            this.txtBrojOdjela.Size = new System.Drawing.Size(187, 20);
            this.txtBrojOdjela.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Knjižnica: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Poštanski broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ime odjela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Broj odjela:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(234, 243);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 10;
            this.btnUnesi.Text = "Unesi odjel";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // UnosOdjelaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(332, 309);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojOdjela);
            this.Controls.Add(this.txtImeOdjela);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPoštanskiBroj);
            this.Controls.Add(this.cmbKnjižnica);
            this.Name = "UnosOdjelaForm";
            this.Text = "UnosOdjelaForm";
            this.Load += new System.EventHandler(this.UnosOdjelaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKnjižnica;
        private System.Windows.Forms.TextBox txtPoštanskiBroj;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtImeOdjela;
        private System.Windows.Forms.TextBox txtBrojOdjela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnesi;
    }
}