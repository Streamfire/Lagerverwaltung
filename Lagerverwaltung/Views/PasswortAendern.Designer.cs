﻿namespace Lagerverwaltung.Views
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
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutzername:";
            // 
            // textBoxNutzername
            // 
            this.textBoxNutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNutzername.Location = new System.Drawing.Point(177, 83);
            this.textBoxNutzername.Name = "textBoxNutzername";
            this.textBoxNutzername.Size = new System.Drawing.Size(216, 24);
            this.textBoxNutzername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altes Passwort:";
            // 
            // textBoxAltesPasswort
            // 
            this.textBoxAltesPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAltesPasswort.Location = new System.Drawing.Point(177, 128);
            this.textBoxAltesPasswort.Name = "textBoxAltesPasswort";
            this.textBoxAltesPasswort.Size = new System.Drawing.Size(216, 24);
            this.textBoxAltesPasswort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Neues Passwort:";
            // 
            // textBoxNeuesPasswort
            // 
            this.textBoxNeuesPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNeuesPasswort.Location = new System.Drawing.Point(177, 174);
            this.textBoxNeuesPasswort.Name = "textBoxNeuesPasswort";
            this.textBoxNeuesPasswort.Size = new System.Drawing.Size(216, 24);
            this.textBoxNeuesPasswort.TabIndex = 5;
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeiter.Location = new System.Drawing.Point(191, 239);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(97, 34);
            this.buttonWeiter.TabIndex = 6;
            this.buttonWeiter.Text = "Okay";
            this.buttonWeiter.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbbrechen.Location = new System.Drawing.Point(307, 239);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(97, 34);
            this.buttonAbbrechen.TabIndex = 7;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Passwort ändern";
            // 
            // PasswortAendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonWeiter);
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
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Label label4;
    }
}