namespace Lagerverwaltung.Views
{
    partial class LagerHinzufuegen
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
			this.textBoxLagerName = new System.Windows.Forms.TextBox();
			this.textBoxBeschreibung = new System.Windows.Forms.TextBox();
			this.buttonLagerHinzufügen = new System.Windows.Forms.Button();
			this.buttonAbbrechen = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxStandort = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxLagertyp = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lager hinzufügen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lagername";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Beschreibung";
			// 
			// textBoxLagerName
			// 
			this.textBoxLagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLagerName.Location = new System.Drawing.Point(150, 85);
			this.textBoxLagerName.Name = "textBoxLagerName";
			this.textBoxLagerName.Size = new System.Drawing.Size(224, 24);
			this.textBoxLagerName.TabIndex = 3;
			// 
			// textBoxBeschreibung
			// 
			this.textBoxBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxBeschreibung.Location = new System.Drawing.Point(150, 221);
			this.textBoxBeschreibung.Multiline = true;
			this.textBoxBeschreibung.Name = "textBoxBeschreibung";
			this.textBoxBeschreibung.Size = new System.Drawing.Size(224, 91);
			this.textBoxBeschreibung.TabIndex = 4;
			// 
			// buttonLagerHinzufügen
			// 
			this.buttonLagerHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLagerHinzufügen.Location = new System.Drawing.Point(134, 343);
			this.buttonLagerHinzufügen.Name = "buttonLagerHinzufügen";
			this.buttonLagerHinzufügen.Size = new System.Drawing.Size(134, 38);
			this.buttonLagerHinzufügen.TabIndex = 5;
			this.buttonLagerHinzufügen.Text = "Lager hinzufügen";
			this.buttonLagerHinzufügen.UseVisualStyleBackColor = true;
			this.buttonLagerHinzufügen.Click += new System.EventHandler(this.buttonLagerHinzufügen_Click);
			// 
			// buttonAbbrechen
			// 
			this.buttonAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAbbrechen.Location = new System.Drawing.Point(298, 344);
			this.buttonAbbrechen.Name = "buttonAbbrechen";
			this.buttonAbbrechen.Size = new System.Drawing.Size(95, 37);
			this.buttonAbbrechen.TabIndex = 6;
			this.buttonAbbrechen.Text = "Abbrechen";
			this.buttonAbbrechen.UseVisualStyleBackColor = true;
			this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Standort";
			// 
			// textBoxStandort
			// 
			this.textBoxStandort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxStandort.Location = new System.Drawing.Point(150, 127);
			this.textBoxStandort.Name = "textBoxStandort";
			this.textBoxStandort.Size = new System.Drawing.Size(224, 24);
			this.textBoxStandort.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Lagertyp";
			// 
			// comboBoxLagertyp
			// 
			this.comboBoxLagertyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxLagertyp.FormattingEnabled = true;
			this.comboBoxLagertyp.Location = new System.Drawing.Point(150, 173);
			this.comboBoxLagertyp.Name = "comboBoxLagertyp";
			this.comboBoxLagertyp.Size = new System.Drawing.Size(224, 26);
			this.comboBoxLagertyp.TabIndex = 10;
			// 
			// LagerHinzufuegen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 401);
			this.Controls.Add(this.comboBoxLagertyp);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxStandort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonAbbrechen);
			this.Controls.Add(this.buttonLagerHinzufügen);
			this.Controls.Add(this.textBoxBeschreibung);
			this.Controls.Add(this.textBoxLagerName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LagerHinzufuegen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LagerHinzufügen";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLagerName;
        private System.Windows.Forms.TextBox textBoxBeschreibung;
        private System.Windows.Forms.Button buttonLagerHinzufügen;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStandort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLagertyp;
    }
}