namespace Lagerverwaltung.Views
{
    partial class ProduktAendern
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
            this.ButtonProduktAendern = new System.Windows.Forms.Button();
            this.ButtonAbbrechen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Zeichnungsnummer = new System.Windows.Forms.TextBox();
            this.tb_Gewicht = new System.Windows.Forms.TextBox();
            this.tb_Preis = new System.Windows.Forms.TextBox();
            this.artikeltypBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Breite = new System.Windows.Forms.TextBox();
            this.tb_Hoehe = new System.Windows.Forms.TextBox();
            this.tb_Laenge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonProduktAendern
            // 
            this.ButtonProduktAendern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProduktAendern.Location = new System.Drawing.Point(97, 458);
            this.ButtonProduktAendern.Name = "ButtonProduktAendern";
            this.ButtonProduktAendern.Size = new System.Drawing.Size(151, 35);
            this.ButtonProduktAendern.TabIndex = 0;
            this.ButtonProduktAendern.Text = "Produkt Ändern";
            this.ButtonProduktAendern.UseVisualStyleBackColor = true;
            this.ButtonProduktAendern.Click += new System.EventHandler(this.ButtonProduktAendern_Click);
            // 
            // ButtonAbbrechen
            // 
            this.ButtonAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAbbrechen.Location = new System.Drawing.Point(282, 458);
            this.ButtonAbbrechen.Name = "ButtonAbbrechen";
            this.ButtonAbbrechen.Size = new System.Drawing.Size(120, 35);
            this.ButtonAbbrechen.TabIndex = 1;
            this.ButtonAbbrechen.Text = "Abbrechen";
            this.ButtonAbbrechen.UseVisualStyleBackColor = true;
            this.ButtonAbbrechen.Click += new System.EventHandler(this.ButtonAbbrechen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produkt ändern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zeichnungsnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gewicht:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Artikeltyp:";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(212, 66);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(190, 24);
            this.tb_Name.TabIndex = 8;
            // 
            // tb_Zeichnungsnummer
            // 
            this.tb_Zeichnungsnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Zeichnungsnummer.Location = new System.Drawing.Point(212, 111);
            this.tb_Zeichnungsnummer.Name = "tb_Zeichnungsnummer";
            this.tb_Zeichnungsnummer.Size = new System.Drawing.Size(190, 24);
            this.tb_Zeichnungsnummer.TabIndex = 9;
            // 
            // tb_Gewicht
            // 
            this.tb_Gewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gewicht.Location = new System.Drawing.Point(212, 153);
            this.tb_Gewicht.Name = "tb_Gewicht";
            this.tb_Gewicht.Size = new System.Drawing.Size(190, 24);
            this.tb_Gewicht.TabIndex = 10;
            // 
            // tb_Preis
            // 
            this.tb_Preis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Preis.Location = new System.Drawing.Point(212, 197);
            this.tb_Preis.Name = "tb_Preis";
            this.tb_Preis.Size = new System.Drawing.Size(190, 24);
            this.tb_Preis.TabIndex = 11;
            // 
            // artikeltypBox
            // 
            this.artikeltypBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artikeltypBox.FormattingEnabled = true;
            this.artikeltypBox.Location = new System.Drawing.Point(212, 244);
            this.artikeltypBox.Name = "artikeltypBox";
            this.artikeltypBox.Size = new System.Drawing.Size(190, 26);
            this.artikeltypBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Breite:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Höhe:";
            // 
            // tb_Breite
            // 
            this.tb_Breite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Breite.Location = new System.Drawing.Point(212, 338);
            this.tb_Breite.Name = "tb_Breite";
            this.tb_Breite.Size = new System.Drawing.Size(190, 24);
            this.tb_Breite.TabIndex = 17;
            // 
            // tb_Hoehe
            // 
            this.tb_Hoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hoehe.Location = new System.Drawing.Point(212, 291);
            this.tb_Hoehe.Name = "tb_Hoehe";
            this.tb_Hoehe.Size = new System.Drawing.Size(190, 24);
            this.tb_Hoehe.TabIndex = 16;
            // 
            // tb_Laenge
            // 
            this.tb_Laenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Laenge.Location = new System.Drawing.Point(212, 385);
            this.tb_Laenge.Name = "tb_Laenge";
            this.tb_Laenge.Size = new System.Drawing.Size(190, 24);
            this.tb_Laenge.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Länge:";
            // 
            // ProduktAendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 509);
            this.Controls.Add(this.tb_Laenge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_Breite);
            this.Controls.Add(this.tb_Hoehe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.artikeltypBox);
            this.Controls.Add(this.tb_Preis);
            this.Controls.Add(this.tb_Gewicht);
            this.Controls.Add(this.tb_Zeichnungsnummer);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAbbrechen);
            this.Controls.Add(this.ButtonProduktAendern);
            this.Name = "ProduktAendern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt Ändern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonProduktAendern;
        private System.Windows.Forms.Button ButtonAbbrechen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Zeichnungsnummer;
        private System.Windows.Forms.TextBox tb_Gewicht;
        private System.Windows.Forms.TextBox tb_Preis;
        private System.Windows.Forms.ComboBox artikeltypBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Breite;
        private System.Windows.Forms.TextBox tb_Hoehe;
        private System.Windows.Forms.TextBox tb_Laenge;
        private System.Windows.Forms.Label label9;
    }
}