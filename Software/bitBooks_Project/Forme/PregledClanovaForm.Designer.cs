
namespace bitBooks_Project
{
    partial class PregledClanovaForm
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnPregledaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnAžuriraj = new System.Windows.Forms.Button();
            this.btnIskaznica = new System.Windows.Forms.Button();
            this.btnSkener = new System.Windows.Forms.Button();
            this.cmbSkener = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 130);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(777, 361);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(578, 24);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(75, 78);
            this.btnPrikaziSve.TabIndex = 1;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(474, 24);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 78);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(285, 24);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(162, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(285, 50);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(162, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime člana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime člana:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(714, 525);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 29);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnPregledaj
            // 
            this.btnPregledaj.Location = new System.Drawing.Point(158, 83);
            this.btnPregledaj.Name = "btnPregledaj";
            this.btnPregledaj.Size = new System.Drawing.Size(107, 41);
            this.btnPregledaj.TabIndex = 9;
            this.btnPregledaj.Text = "Pregledaj posudbe i rezervacije";
            this.btnPregledaj.UseVisualStyleBackColor = true;
            this.btnPregledaj.Click += new System.EventHandler(this.BtnPregledaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bitBooks_Project.Properties.Resources.korisnici_slika;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnObrisi.Location = new System.Drawing.Point(684, 83);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 25);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši člana";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(684, 12);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(105, 25);
            this.btnUnos.TabIndex = 12;
            this.btnUnos.Text = "Unesi korisnika";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.Location = new System.Drawing.Point(684, 48);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(105, 23);
            this.btnAžuriraj.TabIndex = 13;
            this.btnAžuriraj.Text = "Ažuriraj korisnika";
            this.btnAžuriraj.UseVisualStyleBackColor = true;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // btnIskaznica
            // 
            this.btnIskaznica.Location = new System.Drawing.Point(12, 497);
            this.btnIskaznica.Name = "btnIskaznica";
            this.btnIskaznica.Size = new System.Drawing.Size(105, 31);
            this.btnIskaznica.TabIndex = 12;
            this.btnIskaznica.Text = "Napravi iskaznicu";
            this.btnIskaznica.UseVisualStyleBackColor = true;
            this.btnIskaznica.Click += new System.EventHandler(this.btnIskaznica_Click);
            // 
            // btnSkener
            // 
            this.btnSkener.Location = new System.Drawing.Point(390, 497);
            this.btnSkener.Name = "btnSkener";
            this.btnSkener.Size = new System.Drawing.Size(105, 31);
            this.btnSkener.TabIndex = 14;
            this.btnSkener.Text = "Skeniraj karticu";
            this.btnSkener.UseVisualStyleBackColor = true;
            this.btnSkener.Click += new System.EventHandler(this.BtnSkener_Click);
            // 
            // cmbSkener
            // 
            this.cmbSkener.FormattingEnabled = true;
            this.cmbSkener.Location = new System.Drawing.Point(254, 500);
            this.cmbSkener.Name = "cmbSkener";
            this.cmbSkener.Size = new System.Drawing.Size(121, 21);
            this.cmbSkener.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Uređaj za skeniranje:";
            // 
            // PregledClanovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(801, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSkener);
            this.Controls.Add(this.btnSkener);
            this.Controls.Add(this.btnIskaznica);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPregledaj);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "PregledClanovaForm";
            this.Text = "Pregled članova";
            this.Load += new System.EventHandler(this.PregledClanovaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnPregledaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIskaznica;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnAžuriraj;
        private System.Windows.Forms.Button btnSkener;
        private System.Windows.Forms.ComboBox cmbSkener;
        private System.Windows.Forms.Label label3;
    }
}