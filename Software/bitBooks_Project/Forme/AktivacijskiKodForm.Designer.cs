namespace bitBooks_Project.Forme
{
    partial class AktivacijskiKodForm
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
            this.txtAktivacijskiKod = new System.Windows.Forms.TextBox();
            this.btnZavršiRegistraciju = new System.Windows.Forms.Button();
            this.lblGreška = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Na vaš email poslan je aktivacijski kod i vaše korisničko ime.";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite aktivacijski kod: ";
            // 
            // txtAktivacijskiKod
            // 
            this.txtAktivacijskiKod.Location = new System.Drawing.Point(155, 60);
            this.txtAktivacijskiKod.Name = "txtAktivacijskiKod";
            this.txtAktivacijskiKod.Size = new System.Drawing.Size(117, 20);
            this.txtAktivacijskiKod.TabIndex = 2;
            // 
            // btnZavršiRegistraciju
            // 
            this.btnZavršiRegistraciju.Location = new System.Drawing.Point(287, 52);
            this.btnZavršiRegistraciju.Name = "btnZavršiRegistraciju";
            this.btnZavršiRegistraciju.Size = new System.Drawing.Size(75, 35);
            this.btnZavršiRegistraciju.TabIndex = 3;
            this.btnZavršiRegistraciju.Text = "Završi Registraciju";
            this.btnZavršiRegistraciju.UseVisualStyleBackColor = true;
            this.btnZavršiRegistraciju.Click += new System.EventHandler(this.btnZavršiRegistraciju_Click);
            // 
            // lblGreška
            // 
            this.lblGreška.AutoSize = true;
            this.lblGreška.ForeColor = System.Drawing.Color.Red;
            this.lblGreška.Location = new System.Drawing.Point(152, 96);
            this.lblGreška.Name = "lblGreška";
            this.lblGreška.Size = new System.Drawing.Size(0, 13);
            this.lblGreška.TabIndex = 4;
            // 
            // AktivacijskiKodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(374, 118);
            this.Controls.Add(this.lblGreška);
            this.Controls.Add(this.btnZavršiRegistraciju);
            this.Controls.Add(this.txtAktivacijskiKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AktivacijskiKodForm";
            this.Text = "AktivacijskiKodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAktivacijskiKod;
        private System.Windows.Forms.Button btnZavršiRegistraciju;
        private System.Windows.Forms.Label lblGreška;
    }
}