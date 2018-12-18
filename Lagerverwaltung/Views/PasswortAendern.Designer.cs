namespace Lagerverwaltung.Views
{
    partial class PasswortAendern
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
            this.textBoxNutzername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAltesPasswort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNeuesPasswort = new System.Windows.Forms.TextBox();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNeuesPasswortBestaetigen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.show_cleartext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutzername:";
            // 
            // textBoxNutzername
            // 
            this.textBoxNutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNutzername.Location = new System.Drawing.Point(158, 65);
            this.textBoxNutzername.Name = "textBoxNutzername";
            this.textBoxNutzername.Size = new System.Drawing.Size(216, 24);
            this.textBoxNutzername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altes Passwort:";
            // 
            // textBoxAltesPasswort
            // 
            this.textBoxAltesPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAltesPasswort.Location = new System.Drawing.Point(158, 107);
            this.textBoxAltesPasswort.Name = "textBoxAltesPasswort";
            this.textBoxAltesPasswort.Size = new System.Drawing.Size(216, 24);
            this.textBoxAltesPasswort.TabIndex = 3;
            this.textBoxAltesPasswort.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Neues Passwort:";
            // 
            // textBoxNeuesPasswort
            // 
            this.textBoxNeuesPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNeuesPasswort.Location = new System.Drawing.Point(158, 151);
            this.textBoxNeuesPasswort.Name = "textBoxNeuesPasswort";
            this.textBoxNeuesPasswort.Size = new System.Drawing.Size(216, 24);
            this.textBoxNeuesPasswort.TabIndex = 5;
            this.textBoxNeuesPasswort.UseSystemPasswordChar = true;
            // 
            // buttonOkay
            // 
            this.buttonOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkay.Location = new System.Drawing.Point(158, 252);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(97, 34);
            this.buttonOkay.TabIndex = 7;
            this.buttonOkay.Text = "Okay";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.ButtonOkay_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbbrechen.Location = new System.Drawing.Point(277, 252);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(97, 34);
            this.buttonAbbrechen.TabIndex = 8;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.ButtonAbbrechen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Passwort ändern";
            // 
            // textBoxNeuesPasswortBestaetigen
            // 
            this.textBoxNeuesPasswortBestaetigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNeuesPasswortBestaetigen.Location = new System.Drawing.Point(158, 208);
            this.textBoxNeuesPasswortBestaetigen.Name = "textBoxNeuesPasswortBestaetigen";
            this.textBoxNeuesPasswortBestaetigen.Size = new System.Drawing.Size(216, 24);
            this.textBoxNeuesPasswortBestaetigen.TabIndex = 6;
            this.textBoxNeuesPasswortBestaetigen.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Neues Passwort\r\nBestätigen:\r\n";
            // 
            // show_cleartext
            // 
            this.show_cleartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_cleartext.Location = new System.Drawing.Point(36, 252);
            this.show_cleartext.Name = "show_cleartext";
            this.show_cleartext.Size = new System.Drawing.Size(64, 34);
            this.show_cleartext.TabIndex = 7;
            this.show_cleartext.UseVisualStyleBackColor = true;
            this.show_cleartext.Click += new System.EventHandler(this.show_cleartext_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(26, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Klartext anzeigen";
            // 
            // PasswortAendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.show_cleartext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNeuesPasswortBestaetigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.textBoxNeuesPasswort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAltesPasswort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNutzername);
            this.Controls.Add(this.label1);
            this.Name = "PasswortAendern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswortAendern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNutzername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAltesPasswort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNeuesPasswort;
        private System.Windows.Forms.Button buttonOkay;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNeuesPasswortBestaetigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button show_cleartext;
        private System.Windows.Forms.Label label6;
    }
}