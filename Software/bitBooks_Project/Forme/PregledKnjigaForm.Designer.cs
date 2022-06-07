
namespace bitBooks_Project.Forme
{
    partial class PregledKnjigaForm
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
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpisPos = new System.Windows.Forms.Button();
            this.dgvKnjigPosudbe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigPosudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(18, 19);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.ReadOnly = true;
            this.dgvKnjige.Size = new System.Drawing.Size(428, 265);
            this.dgvKnjige.TabIndex = 0;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(159, 290);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(150, 33);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj knjigu";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(205, 290);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(150, 33);
            this.btnPosudi.TabIndex = 2;
            this.btnPosudi.Text = "Posudi knjigu";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pregled knjiga";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKnjige);
            this.groupBox1.Controls.Add(this.btnRezerviraj);
            this.groupBox1.Location = new System.Drawing.Point(21, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 348);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Knjige dostupne za rezervaciju";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpisPos);
            this.groupBox2.Controls.Add(this.dgvKnjigPosudbe);
            this.groupBox2.Controls.Add(this.btnPosudi);
            this.groupBox2.Location = new System.Drawing.Point(574, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 348);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dostupno za posudbu";
            // 
            // OpisPos
            // 
            this.OpisPos.Location = new System.Drawing.Point(30, 290);
            this.OpisPos.Name = "OpisPos";
            this.OpisPos.Size = new System.Drawing.Size(150, 33);
            this.OpisPos.TabIndex = 3;
            this.OpisPos.Text = "Detaljno o knjizi";
            this.OpisPos.UseVisualStyleBackColor = true;
            this.OpisPos.Click += new System.EventHandler(this.OpisPos_Click);
            // 
            // dgvKnjigPosudbe
            // 
            this.dgvKnjigPosudbe.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvKnjigPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjigPosudbe.Location = new System.Drawing.Point(15, 19);
            this.dgvKnjigPosudbe.Name = "dgvKnjigPosudbe";
            this.dgvKnjigPosudbe.Size = new System.Drawing.Size(423, 265);
            this.dgvKnjigPosudbe.TabIndex = 3;
            // 
            // PregledKnjigaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1065, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PregledKnjigaForm";
            this.Text = "Pregled knjiga";
            this.Load += new System.EventHandler(this.PregledKnjigaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigPosudbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKnjigPosudbe;
        private System.Windows.Forms.CheckBox chkboxDostava;
        private System.Windows.Forms.Button OpisPos;
    }
}