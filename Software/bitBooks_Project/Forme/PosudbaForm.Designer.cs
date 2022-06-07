
namespace bitBooks_Project.Forme
{
    partial class PosudbaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.Label();
            this.txtNapisana = new System.Windows.Forms.Label();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkboxDostava = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Napisana:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Location = new System.Drawing.Point(124, 253);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(35, 13);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.Text = "label4";
            // 
            // txtISBN
            // 
            this.txtISBN.AutoSize = true;
            this.txtISBN.Location = new System.Drawing.Point(124, 282);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(35, 13);
            this.txtISBN.TabIndex = 4;
            this.txtISBN.Text = "label5";
            // 
            // txtNapisana
            // 
            this.txtNapisana.AutoSize = true;
            this.txtNapisana.Location = new System.Drawing.Point(124, 311);
            this.txtNapisana.Name = "txtNapisana";
            this.txtNapisana.Size = new System.Drawing.Size(35, 13);
            this.txtNapisana.TabIndex = 5;
            this.txtNapisana.Text = "label6";
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(65, 356);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(75, 23);
            this.btnPosudi.TabIndex = 6;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtNapisana);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 338);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o knjizi";
            // 
            // chkboxDostava
            // 
            this.chkboxDostava.AutoSize = true;
            this.chkboxDostava.Location = new System.Drawing.Point(175, 360);
            this.chkboxDostava.Name = "chkboxDostava";
            this.chkboxDostava.Size = new System.Drawing.Size(66, 17);
            this.chkboxDostava.TabIndex = 9;
            this.chkboxDostava.Text = "Dostava";
            this.chkboxDostava.UseVisualStyleBackColor = true;
            // 
            // PosudbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(281, 391);
            this.Controls.Add(this.chkboxDostava);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.groupBox1);
            this.Name = "PosudbaForm";
            this.Text = "PosudbaForm";
            this.Load += new System.EventHandler(this.PosudbaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.Label txtISBN;
        private System.Windows.Forms.Label txtNapisana;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkboxDostava;
    }
}