namespace Övning_4._3
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxepost = new System.Windows.Forms.TextBox();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.btnÖppnaFil = new System.Windows.Forms.Button();
            this.btnSparaFil = new System.Windows.Forms.Button();
            this.lbxKontakt = new System.Windows.Forms.ListBox();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefonnummer";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(148, 24);
            this.tbxFörnamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(160, 22);
            this.tbxFörnamn.TabIndex = 4;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(148, 67);
            this.tbxEfternamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(160, 22);
            this.tbxEfternamn.TabIndex = 5;
            // 
            // tbxepost
            // 
            this.tbxepost.Location = new System.Drawing.Point(148, 106);
            this.tbxepost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxepost.Name = "tbxepost";
            this.tbxepost.Size = new System.Drawing.Size(160, 22);
            this.tbxepost.TabIndex = 6;
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(148, 142);
            this.tbxTelefonnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(160, 22);
            this.tbxTelefonnummer.TabIndex = 7;
            // 
            // btnÖppnaFil
            // 
            this.btnÖppnaFil.Location = new System.Drawing.Point(25, 241);
            this.btnÖppnaFil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnÖppnaFil.Name = "btnÖppnaFil";
            this.btnÖppnaFil.Size = new System.Drawing.Size(103, 35);
            this.btnÖppnaFil.TabIndex = 8;
            this.btnÖppnaFil.Text = "Öppna";
            this.btnÖppnaFil.UseVisualStyleBackColor = true;
            this.btnÖppnaFil.Click += new System.EventHandler(this.btnÖppnaFil_Click);
            // 
            // btnSparaFil
            // 
            this.btnSparaFil.Location = new System.Drawing.Point(170, 241);
            this.btnSparaFil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSparaFil.Name = "btnSparaFil";
            this.btnSparaFil.Size = new System.Drawing.Size(103, 35);
            this.btnSparaFil.TabIndex = 9;
            this.btnSparaFil.Text = "Spara som...";
            this.btnSparaFil.UseVisualStyleBackColor = true;
            this.btnSparaFil.Click += new System.EventHandler(this.btnSparaFil_Click);
            // 
            // lbxKontakt
            // 
            this.lbxKontakt.FormattingEnabled = true;
            this.lbxKontakt.ItemHeight = 16;
            this.lbxKontakt.Location = new System.Drawing.Point(367, 24);
            this.lbxKontakt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxKontakt.Name = "lbxKontakt";
            this.lbxKontakt.Size = new System.Drawing.Size(302, 148);
            this.lbxKontakt.TabIndex = 10;
            this.lbxKontakt.SelectedIndexChanged += new System.EventHandler(this.lbxKontakt_SelectedIndexChanged);
            // 
            // dlgÖppnaFil
            // 
            this.dlgÖppnaFil.FileName = "openFileDialog1";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(367, 208);
            this.btnLäggTill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(98, 35);
            this.btnLäggTill.TabIndex = 11;
            this.btnLäggTill.Text = "Lägg Till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(571, 208);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(98, 35);
            this.btnTaBort.TabIndex = 12;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.lbxKontakt);
            this.Controls.Add(this.btnSparaFil);
            this.Controls.Add(this.btnÖppnaFil);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.tbxepost);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxepost;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
        private System.Windows.Forms.Button btnÖppnaFil;
        private System.Windows.Forms.Button btnSparaFil;
        private System.Windows.Forms.ListBox lbxKontakt;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnTaBort;
    }
}

