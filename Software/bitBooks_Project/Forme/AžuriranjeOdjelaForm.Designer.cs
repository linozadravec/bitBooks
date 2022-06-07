namespace bitBooks_Project.Forme
{
    partial class AžuriranjeOdjelaForm
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
            this.txtPoštanskiBroj = new System.Windows.Forms.TextBox();
            this.txtImeOdjela = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtBrojOdjela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAžuriraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPoštanskiBroj
            // 
            this.txtPoštanskiBroj.Location = new System.Drawing.Point(138, 61);
            this.txtPoštanskiBroj.Name = "txtPoštanskiBroj";
            this.txtPoštanskiBroj.Size = new System.Drawing.Size(159, 20);
            this.txtPoštanskiBroj.TabIndex = 0;
            // 
            // txtImeOdjela
            // 
            this.txtImeOdjela.Location = new System.Drawing.Point(138, 103);
            this.txtImeOdjela.Name = "txtImeOdjela";
            this.txtImeOdjela.Size = new System.Drawing.Size(159, 20);
            this.txtImeOdjela.TabIndex = 1;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(138, 145);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(159, 20);
            this.txtAdresa.TabIndex = 2;
            // 
            // txtBrojOdjela
            // 
            this.txtBrojOdjela.Location = new System.Drawing.Point(138, 186);
            this.txtBrojOdjela.Name = "txtBrojOdjela";
            this.txtBrojOdjela.Size = new System.Drawing.Size(159, 20);
            this.txtBrojOdjela.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Poštanski broj: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime odjela: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj odjela:";
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.Location = new System.Drawing.Point(138, 252);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAžuriraj.TabIndex = 8;
            this.btnAžuriraj.Text = "Ažuriraj";
            this.btnAžuriraj.UseVisualStyleBackColor = true;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id odjela:";
            // 
            // AžuriranjeOdjelaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(340, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojOdjela);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtImeOdjela);
            this.Controls.Add(this.txtPoštanskiBroj);
            this.Name = "AžuriranjeOdjelaForm";
            this.Text = "AžuriranjeOdjelaForm";
            this.Load += new System.EventHandler(this.AžuriranjeOdjelaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoštanskiBroj;
        private System.Windows.Forms.TextBox txtImeOdjela;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtBrojOdjela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAžuriraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
    }
}