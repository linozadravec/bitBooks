
namespace bitBooks_Project
{
    partial class PregledRecenzijaForm
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
            this.dgvRecenzije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnRecenzijeKnjiznice = new System.Windows.Forms.Button();
            this.btnRecenzijeZaposlenika = new System.Windows.Forms.Button();
            this.grpBoxRecenzije = new System.Windows.Forms.GroupBox();
            this.btnUnosRecenzijeZaZaposlenika = new System.Windows.Forms.Button();
            this.btnUnosRecenzijeZaKnjiznicu = new System.Windows.Forms.Button();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdredeniZaposlenik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).BeginInit();
            this.grpBoxRecenzije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecenzije
            // 
            this.dgvRecenzije.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecenzije.Location = new System.Drawing.Point(12, 68);
            this.dgvRecenzije.Name = "dgvRecenzije";
            this.dgvRecenzije.Size = new System.Drawing.Size(747, 289);
            this.dgvRecenzije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recenzije";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(687, 433);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnRecenzijeKnjiznice
            // 
            this.btnRecenzijeKnjiznice.Location = new System.Drawing.Point(86, 23);
            this.btnRecenzijeKnjiznice.Name = "btnRecenzijeKnjiznice";
            this.btnRecenzijeKnjiznice.Size = new System.Drawing.Size(130, 36);
            this.btnRecenzijeKnjiznice.TabIndex = 4;
            this.btnRecenzijeKnjiznice.Text = "Prikaži recenzije knjižnice";
            this.btnRecenzijeKnjiznice.UseVisualStyleBackColor = true;
            this.btnRecenzijeKnjiznice.Click += new System.EventHandler(this.btnRecenzijeKnjiznice_Click);
            // 
            // btnRecenzijeZaposlenika
            // 
            this.btnRecenzijeZaposlenika.Location = new System.Drawing.Point(231, 23);
            this.btnRecenzijeZaposlenika.Name = "btnRecenzijeZaposlenika";
            this.btnRecenzijeZaposlenika.Size = new System.Drawing.Size(130, 36);
            this.btnRecenzijeZaposlenika.TabIndex = 5;
            this.btnRecenzijeZaposlenika.Text = "Prikaži recenzije zaposlenika knjižnice";
            this.btnRecenzijeZaposlenika.UseVisualStyleBackColor = true;
            this.btnRecenzijeZaposlenika.Click += new System.EventHandler(this.btnRecenzijeZaposlenika_Click);
            // 
            // grpBoxRecenzije
            // 
            this.grpBoxRecenzije.Controls.Add(this.btnUnosRecenzijeZaZaposlenika);
            this.grpBoxRecenzije.Controls.Add(this.btnUnosRecenzijeZaKnjiznicu);
            this.grpBoxRecenzije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxRecenzije.Location = new System.Drawing.Point(15, 364);
            this.grpBoxRecenzije.Name = "grpBoxRecenzije";
            this.grpBoxRecenzije.Size = new System.Drawing.Size(290, 92);
            this.grpBoxRecenzije.TabIndex = 6;
            this.grpBoxRecenzije.TabStop = false;
            this.grpBoxRecenzije.Text = "Moje recenzije";
            // 
            // btnUnosRecenzijeZaZaposlenika
            // 
            this.btnUnosRecenzijeZaZaposlenika.Location = new System.Drawing.Point(154, 19);
            this.btnUnosRecenzijeZaZaposlenika.Name = "btnUnosRecenzijeZaZaposlenika";
            this.btnUnosRecenzijeZaZaposlenika.Size = new System.Drawing.Size(130, 67);
            this.btnUnosRecenzijeZaZaposlenika.TabIndex = 8;
            this.btnUnosRecenzijeZaZaposlenika.Text = "Unesi recenziju za zaposlenika";
            this.btnUnosRecenzijeZaZaposlenika.UseVisualStyleBackColor = true;
            this.btnUnosRecenzijeZaZaposlenika.Click += new System.EventHandler(this.btnUnosRecenzijeZaZaposlenika_Click);
            // 
            // btnUnosRecenzijeZaKnjiznicu
            // 
            this.btnUnosRecenzijeZaKnjiznicu.Location = new System.Drawing.Point(18, 19);
            this.btnUnosRecenzijeZaKnjiznicu.Name = "btnUnosRecenzijeZaKnjiznicu";
            this.btnUnosRecenzijeZaKnjiznicu.Size = new System.Drawing.Size(130, 67);
            this.btnUnosRecenzijeZaKnjiznicu.TabIndex = 7;
            this.btnUnosRecenzijeZaKnjiznicu.Text = "Unesi recenziju za knjižnicu";
            this.btnUnosRecenzijeZaKnjiznicu.UseVisualStyleBackColor = true;
            this.btnUnosRecenzijeZaKnjiznicu.Click += new System.EventHandler(this.btnUnosRecenzijeZaKnjiznicu_Click);
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(457, 32);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(121, 21);
            this.cmbZaposlenik.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zaposlenik:";
            // 
            // btnOdredeniZaposlenik
            // 
            this.btnOdredeniZaposlenik.Location = new System.Drawing.Point(594, 23);
            this.btnOdredeniZaposlenik.Name = "btnOdredeniZaposlenik";
            this.btnOdredeniZaposlenik.Size = new System.Drawing.Size(130, 36);
            this.btnOdredeniZaposlenik.TabIndex = 9;
            this.btnOdredeniZaposlenik.Text = "Prikaži recenzije određenog zaposlenika";
            this.btnOdredeniZaposlenik.UseVisualStyleBackColor = true;
            this.btnOdredeniZaposlenik.Click += new System.EventHandler(this.btnOdredeniZaposlenik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::bitBooks_Project.Properties.Resources._5stars_slika;
            this.pictureBox1.Location = new System.Drawing.Point(274, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PregledRecenzijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(774, 468);
            this.Controls.Add(this.grpBoxRecenzije);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvRecenzije);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdredeniZaposlenik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.btnRecenzijeZaposlenika);
            this.Controls.Add(this.btnRecenzijeKnjiznice);
            this.Controls.Add(this.label1);
            this.Name = "PregledRecenzijaForm";
            this.Text = "PregledRecenzijaForm";
            this.Load += new System.EventHandler(this.PregledRecenzijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).EndInit();
            this.grpBoxRecenzije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecenzije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnRecenzijeKnjiznice;
        private System.Windows.Forms.Button btnRecenzijeZaposlenika;
        private System.Windows.Forms.GroupBox grpBoxRecenzije;
        private System.Windows.Forms.Button btnUnosRecenzijeZaZaposlenika;
        private System.Windows.Forms.Button btnUnosRecenzijeZaKnjiznicu;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdredeniZaposlenik;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}