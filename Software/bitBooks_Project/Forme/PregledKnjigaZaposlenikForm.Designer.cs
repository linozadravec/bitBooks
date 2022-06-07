namespace bitBooks_Project.Forme
{
    partial class PregledKnjigaZaposlenikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledKnjigaZaposlenikForm));
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoriLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSkeniraj = new System.Windows.Forms.Button();
            this.cmbPretrazivanje = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVrati = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOtkaziRez = new System.Windows.Forms.Button();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnNaljepnica = new System.Windows.Forms.Button();
            this.dgvIzdanja = new System.Windows.Forms.DataGridView();
            this.printNaljepnica = new System.Drawing.Printing.PrintDocument();
            this.printPreviewNaljepnica = new System.Windows.Forms.PrintPreviewDialog();
            this.cmbBrojNaljepnica = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(22, 67);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.Size = new System.Drawing.Size(298, 209);
            this.dgvKnjige.TabIndex = 0;
            this.dgvKnjige.SelectionChanged += new System.EventHandler(this.dgvKnjige_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoriLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(356, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije";
            // 
            // autoriLabel
            // 
            this.autoriLabel.AutoSize = true;
            this.autoriLabel.Location = new System.Drawing.Point(241, 221);
            this.autoriLabel.Name = "autoriLabel";
            this.autoriLabel.Size = new System.Drawing.Size(33, 13);
            this.autoriLabel.TabIndex = 10;
            this.autoriLabel.Text = "autori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(241, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Autori:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(17, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 298);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bitBooks_Project.Properties.Resources._9780064404990;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "tekst";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "zanr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(241, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Žanr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(241, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "izdanaj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(241, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Godina izdanja:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(22, 40);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(298, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pretraživanje:";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(22, 31);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(551, 180);
            this.dgvKorisnici.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnSkeniraj);
            this.groupBox3.Controls.Add(this.cmbPretrazivanje);
            this.groupBox3.Controls.Add(this.dgvKnjige);
            this.groupBox3.Controls.Add(this.searchBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 334);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odabir knjige";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // btnSkeniraj
            // 
            this.btnSkeniraj.Location = new System.Drawing.Point(193, 282);
            this.btnSkeniraj.Name = "btnSkeniraj";
            this.btnSkeniraj.Size = new System.Drawing.Size(127, 25);
            this.btnSkeniraj.TabIndex = 9;
            this.btnSkeniraj.Text = "Skeniraj";
            this.btnSkeniraj.UseVisualStyleBackColor = true;
            this.btnSkeniraj.Click += new System.EventHandler(this.btnSkeniraj_Click);
            // 
            // cmbPretrazivanje
            // 
            this.cmbPretrazivanje.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPretrazivanje.FormattingEnabled = true;
            this.cmbPretrazivanje.Location = new System.Drawing.Point(105, 13);
            this.cmbPretrazivanje.Name = "cmbPretrazivanje";
            this.cmbPretrazivanje.Size = new System.Drawing.Size(215, 21);
            this.cmbPretrazivanje.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVrati);
            this.groupBox4.Controls.Add(this.dgvKorisnici);
            this.groupBox4.Location = new System.Drawing.Point(12, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(588, 257);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Posudbe";
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(22, 218);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(75, 23);
            this.btnVrati.TabIndex = 5;
            this.btnVrati.Text = "Vraćena";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOtkaziRez);
            this.groupBox5.Controls.Add(this.dgvRezervacije);
            this.groupBox5.Location = new System.Drawing.Point(606, 387);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(581, 257);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rezervacije";
            // 
            // btnOtkaziRez
            // 
            this.btnOtkaziRez.Location = new System.Drawing.Point(11, 217);
            this.btnOtkaziRez.Name = "btnOtkaziRez";
            this.btnOtkaziRez.Size = new System.Drawing.Size(139, 23);
            this.btnOtkaziRez.TabIndex = 1;
            this.btnOtkaziRez.Text = "Otkaži rezervaciju";
            this.btnOtkaziRez.UseVisualStyleBackColor = true;
            this.btnOtkaziRez.Click += new System.EventHandler(this.btnOtkaziRez_Click);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(11, 31);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.Size = new System.Drawing.Size(553, 180);
            this.dgvRezervacije.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.cmbBrojNaljepnica);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.cmbKorisnici);
            this.groupBox6.Controls.Add(this.btnPosudi);
            this.groupBox6.Controls.Add(this.btnNaljepnica);
            this.groupBox6.Controls.Add(this.dgvIzdanja);
            this.groupBox6.Location = new System.Drawing.Point(795, 35);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(391, 334);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Izdanja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Korisničko ime:";
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbKorisnici.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(19, 267);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(220, 21);
            this.cmbKorisnici.TabIndex = 4;
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(19, 294);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(220, 23);
            this.btnPosudi.TabIndex = 3;
            this.btnPosudi.Text = "Posudi izdanje korisniku";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnNaljepnica
            // 
            this.btnNaljepnica.Location = new System.Drawing.Point(257, 294);
            this.btnNaljepnica.Name = "btnNaljepnica";
            this.btnNaljepnica.Size = new System.Drawing.Size(117, 23);
            this.btnNaljepnica.TabIndex = 1;
            this.btnNaljepnica.Text = "Generiraj naljepnice";
            this.btnNaljepnica.UseVisualStyleBackColor = true;
            this.btnNaljepnica.Click += new System.EventHandler(this.btnNaljepnica_Click);
            // 
            // dgvIzdanja
            // 
            this.dgvIzdanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdanja.Location = new System.Drawing.Point(19, 19);
            this.dgvIzdanja.Name = "dgvIzdanja";
            this.dgvIzdanja.Size = new System.Drawing.Size(355, 228);
            this.dgvIzdanja.TabIndex = 0;
            // 
            // printNaljepnica
            // 
            this.printNaljepnica.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printNaljepnica_PrintPage);
            // 
            // printPreviewNaljepnica
            // 
            this.printPreviewNaljepnica.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewNaljepnica.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewNaljepnica.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewNaljepnica.Document = this.printNaljepnica;
            this.printPreviewNaljepnica.Enabled = true;
            this.printPreviewNaljepnica.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewNaljepnica.Icon")));
            this.printPreviewNaljepnica.Name = "printPreviewNaljepnica";
            this.printPreviewNaljepnica.Visible = false;
            // 
            // cmbBrojNaljepnica
            // 
            this.cmbBrojNaljepnica.FormattingEnabled = true;
            this.cmbBrojNaljepnica.Location = new System.Drawing.Point(257, 267);
            this.cmbBrojNaljepnica.Name = "cmbBrojNaljepnica";
            this.cmbBrojNaljepnica.Size = new System.Drawing.Size(117, 21);
            this.cmbBrojNaljepnica.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Broj naljepnica:";
            // 
            // PregledKnjigaZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1199, 659);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "PregledKnjigaZaposlenikForm";
            this.Text = "PregledKnjigaZaposlenikForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PregledKnjigaZaposlenikForm_FormClosed);
            this.Load += new System.EventHandler(this.PregledKnjigaZaposlenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label autoriLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.ComboBox cmbPretrazivanje;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvIzdanja;
        private System.Windows.Forms.Button btnNaljepnica;
        private System.Drawing.Printing.PrintDocument printNaljepnica;
        private System.Windows.Forms.PrintPreviewDialog printPreviewNaljepnica;
        private System.Windows.Forms.Button btnSkeniraj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Button btnOtkaziRez;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBrojNaljepnica;
    }
}