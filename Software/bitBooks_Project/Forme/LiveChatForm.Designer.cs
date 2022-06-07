namespace bitBooks_Project.Forme
{
    partial class LiveChatForm
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
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.btnPošalji = new System.Windows.Forms.Button();
            this.listPoruka = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(46, 267);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(572, 20);
            this.txtPoruka.TabIndex = 3;
            // 
            // btnPošalji
            // 
            this.btnPošalji.Location = new System.Drawing.Point(625, 267);
            this.btnPošalji.Name = "btnPošalji";
            this.btnPošalji.Size = new System.Drawing.Size(75, 23);
            this.btnPošalji.TabIndex = 5;
            this.btnPošalji.Text = "Pošalji";
            this.btnPošalji.UseVisualStyleBackColor = true;
            this.btnPošalji.Click += new System.EventHandler(this.btnPošalji_Click);
            // 
            // listPoruka
            // 
            this.listPoruka.FormattingEnabled = true;
            this.listPoruka.Location = new System.Drawing.Point(46, 67);
            this.listPoruka.Name = "listPoruka";
            this.listPoruka.Size = new System.Drawing.Size(572, 186);
            this.listPoruka.TabIndex = 6;
            // 
            // LiveChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(733, 316);
            this.Controls.Add(this.listPoruka);
            this.Controls.Add(this.btnPošalji);
            this.Controls.Add(this.txtPoruka);
            this.Name = "LiveChatForm";
            this.Text = "LiveChatForm";
            this.Load += new System.EventHandler(this.LiveChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.Button btnPošalji;
        private System.Windows.Forms.ListBox listPoruka;
    }
}