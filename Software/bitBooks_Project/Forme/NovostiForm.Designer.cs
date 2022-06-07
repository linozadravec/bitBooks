namespace bitBooks_Project.Forme
{
    partial class NovostiForm
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
            this.txtNovost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnIza = new System.Windows.Forms.Button();
            this.btnDalje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNovost
            // 
            this.txtNovost.Location = new System.Drawing.Point(62, 33);
            this.txtNovost.Name = "txtNovost";
            this.txtNovost.Size = new System.Drawing.Size(489, 20);
            this.txtNovost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(558, 283);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 41);
            this.btnZatvori.TabIndex = 16;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.BtnZatvori_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(477, 283);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 41);
            this.btnSpremi.TabIndex = 19;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(558, 32);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 41);
            this.btnUredi.TabIndex = 22;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(61, 60);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(490, 172);
            this.txtOpis.TabIndex = 26;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(15, 283);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 41);
            this.btnNovo.TabIndex = 29;
            this.btnNovo.Text = "Unesi novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnIza
            // 
            this.btnIza.Location = new System.Drawing.Point(188, 238);
            this.btnIza.Name = "btnIza";
            this.btnIza.Size = new System.Drawing.Size(89, 24);
            this.btnIza.TabIndex = 30;
            this.btnIza.Text = "<<";
            this.btnIza.UseVisualStyleBackColor = true;
            this.btnIza.Click += new System.EventHandler(this.BtnIza_Click);
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(347, 238);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(89, 24);
            this.btnDalje.TabIndex = 31;
            this.btnDalje.Text = ">>";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.BtnDalje_Click);
            // 
            // NovostiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(642, 336);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnIza);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNovost);
            this.Name = "NovostiForm";
            this.Text = "NovostiForm";
            this.Load += new System.EventHandler(this.NovostiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNovost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnIza;
        private System.Windows.Forms.Button btnDalje;
    }
}