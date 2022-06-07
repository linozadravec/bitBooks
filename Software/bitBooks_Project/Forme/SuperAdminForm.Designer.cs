namespace bitBooks_Project.Forme
{
    partial class SuperAdminForm
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
            this.dgvKnjiznice = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjiznice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKnjiznice
            // 
            this.dgvKnjiznice.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvKnjiznice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjiznice.Location = new System.Drawing.Point(12, 12);
            this.dgvKnjiznice.Name = "dgvKnjiznice";
            this.dgvKnjiznice.Size = new System.Drawing.Size(381, 345);
            this.dgvKnjiznice.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(274, 441);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(119, 31);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.BtnZatvori_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(26, 387);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(119, 31);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "Ažuriraj knjižnicu";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.BtnAzuriraj_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(274, 387);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(119, 31);
            this.btnUnesi.TabIndex = 4;
            this.btnUnesi.Text = "Unesi novu knjižnicu";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.BtnUnesi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(26, 441);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(119, 31);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši knjižnicu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // SuperAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(412, 484);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvKnjiznice);
            this.Name = "SuperAdminForm";
            this.Text = "Knjižnice";
            this.Load += new System.EventHandler(this.SuperAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjiznice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKnjiznice;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObrisi;
    }
}