namespace Lagerverwaltung.Views
{
    partial class NutzerHinzufuegen
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
            this.textBoxNutzername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.buttonNutzerAnlegen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutzer hinzufügen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nutzername:";
            // 
            // textBoxNutzername
            // 
            this.textBoxNutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNutzername.Location = new System.Drawing.Point(148, 90);
            this.textBoxNutzername.Name = "textBoxNutzername";
            this.textBoxNutzername.Size = new System.Drawing.Size(237, 24);
            this.textBoxNutzername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passwort:";
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswort.Location = new System.Drawing.Point(148, 139);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(237, 24);
            this.textBoxPasswort.TabIndex = 4;
            // 
            // buttonNutzerAnlegen
            // 
            this.buttonNutzerAnlegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNutzerAnlegen.Location = new System.Drawing.Point(110, 188);
            this.buttonNutzerAnlegen.Name = "buttonNutzerAnlegen";
            this.buttonNutzerAnlegen.Size = new System.Drawing.Size(124, 40);
            this.buttonNutzerAnlegen.TabIndex = 5;
            this.buttonNutzerAnlegen.Text = "Nutzer anlegen";
            this.buttonNutzerAnlegen.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbbrechen.Location = new System.Drawing.Point(261, 188);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(124, 40);
            this.buttonAbbrechen.TabIndex = 6;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // NutzerHinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 254);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonNutzerAnlegen);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNutzername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NutzerHinzufuegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NutzerHinzufuegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNutzername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.Button buttonNutzerAnlegen;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}