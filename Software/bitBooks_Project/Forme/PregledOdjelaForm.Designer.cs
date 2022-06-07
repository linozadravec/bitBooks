namespace bitBooks_Project.Forme
{
    partial class PregledOdjelaForm
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
            this.dgvOdjeli = new System.Windows.Forms.DataGridView();
            this.btnUnesiOdjel = new System.Windows.Forms.Button();
            this.btnObrišiOdjel = new System.Windows.Forms.Button();
            this.btnAžuriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjeli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdjeli
            // 
            this.dgvOdjeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdjeli.Location = new System.Drawing.Point(40, 108);
            this.dgvOdjeli.Name = "dgvOdjeli";
            this.dgvOdjeli.Size = new System.Drawing.Size(667, 290);
            this.dgvOdjeli.TabIndex = 0;
            // 
            // btnUnesiOdjel
            // 
            this.btnUnesiOdjel.Location = new System.Drawing.Point(618, 67);
            this.btnUnesiOdjel.Name = "btnUnesiOdjel";
            this.btnUnesiOdjel.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiOdjel.TabIndex = 1;
            this.btnUnesiOdjel.Text = "Unesi odjel";
            this.btnUnesiOdjel.UseVisualStyleBackColor = true;
            this.btnUnesiOdjel.Click += new System.EventHandler(this.btnUnesiOdjel_Click);
            // 
            // btnObrišiOdjel
            // 
            this.btnObrišiOdjel.Location = new System.Drawing.Point(632, 415);
            this.btnObrišiOdjel.Name = "btnObrišiOdjel";
            this.btnObrišiOdjel.Size = new System.Drawing.Size(75, 23);
            this.btnObrišiOdjel.TabIndex = 2;
            this.btnObrišiOdjel.Text = "Obriši odjel";
            this.btnObrišiOdjel.UseVisualStyleBackColor = true;
            this.btnObrišiOdjel.Click += new System.EventHandler(this.btnObrišiOdjel_Click);
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.Location = new System.Drawing.Point(618, 22);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAžuriraj.TabIndex = 3;
            this.btnAžuriraj.Text = "Ažuriraj odjel";
            this.btnAžuriraj.UseVisualStyleBackColor = true;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // PregledOdjelaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.btnObrišiOdjel);
            this.Controls.Add(this.btnUnesiOdjel);
            this.Controls.Add(this.dgvOdjeli);
            this.Name = "PregledOdjelaForm";
            this.Text = "PregledOdjelaForm";
            this.Load += new System.EventHandler(this.PregledOdjelaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdjeli;
        private System.Windows.Forms.Button btnUnesiOdjel;
        private System.Windows.Forms.Button btnObrišiOdjel;
        private System.Windows.Forms.Button btnAžuriraj;
    }
}