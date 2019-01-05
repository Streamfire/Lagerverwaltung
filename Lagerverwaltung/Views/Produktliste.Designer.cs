namespace Lagerverwaltung.Views
{
    partial class Produktliste
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
            this.Schliessen = new System.Windows.Forms.Button();
            this.Auswaehlen = new System.Windows.Forms.Button();
            this.Produkt_hinzufuegen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gewicht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeichnungsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erstellt_am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zuletzt_geaendert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Schliessen
            // 
            this.Schliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schliessen.Location = new System.Drawing.Point(858, 685);
            this.Schliessen.Name = "Schliessen";
            this.Schliessen.Size = new System.Drawing.Size(120, 35);
            this.Schliessen.TabIndex = 1;
            this.Schliessen.Text = "Abbrechen";
            this.Schliessen.UseVisualStyleBackColor = true;
            this.Schliessen.Click += new System.EventHandler(this.Schliessen_Click);
            // 
            // Auswaehlen
            // 
            this.Auswaehlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auswaehlen.Location = new System.Drawing.Point(708, 685);
            this.Auswaehlen.Name = "Auswaehlen";
            this.Auswaehlen.Size = new System.Drawing.Size(120, 35);
            this.Auswaehlen.TabIndex = 2;
            this.Auswaehlen.Text = "Auswählen";
            this.Auswaehlen.UseVisualStyleBackColor = true;
            this.Auswaehlen.Click += new System.EventHandler(this.Auswaehlen_Click);
            // 
            // Produkt_hinzufuegen
            // 
            this.Produkt_hinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produkt_hinzufuegen.Location = new System.Drawing.Point(29, 685);
            this.Produkt_hinzufuegen.Name = "Produkt_hinzufuegen";
            this.Produkt_hinzufuegen.Size = new System.Drawing.Size(157, 35);
            this.Produkt_hinzufuegen.TabIndex = 3;
            this.Produkt_hinzufuegen.Text = "Produkt hinzufügen";
            this.Produkt_hinzufuegen.UseVisualStyleBackColor = true;
            this.Produkt_hinzufuegen.Click += new System.EventHandler(this.Produkt_hinzufuegen_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Produkt ändern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.gewicht,
            this.preis,
            this.zeichnungsnummer,
            this.erstellt_am,
            this.zuletzt_geaendert});
            this.dataGridView1.Location = new System.Drawing.Point(29, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 637);
            this.dataGridView1.TabIndex = 5;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Produktname";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 240;
            // 
            // gewicht
            // 
            this.gewicht.DataPropertyName = "Gewicht";
            this.gewicht.HeaderText = "Gewicht";
            this.gewicht.Name = "gewicht";
            this.gewicht.ReadOnly = true;
            this.gewicht.Width = 93;
            // 
            // preis
            // 
            this.preis.DataPropertyName = "Preis";
            this.preis.HeaderText = "Preis";
            this.preis.Name = "preis";
            this.preis.ReadOnly = true;
            this.preis.Width = 93;
            // 
            // zeichnungsnummer
            // 
            this.zeichnungsnummer.DataPropertyName = "Zeichnungsnummer";
            this.zeichnungsnummer.HeaderText = "Zeichnungsnummer";
            this.zeichnungsnummer.Name = "zeichnungsnummer";
            this.zeichnungsnummer.ReadOnly = true;
            this.zeichnungsnummer.Width = 180;
            // 
            // erstellt_am
            // 
            this.erstellt_am.DataPropertyName = "ErstelltAm";
            this.erstellt_am.HeaderText = "Erstellt am";
            this.erstellt_am.Name = "erstellt_am";
            this.erstellt_am.ReadOnly = true;
            this.erstellt_am.Width = 150;
            // 
            // zuletzt_geaendert
            // 
            this.zuletzt_geaendert.DataPropertyName = "GeaendertAm";
            this.zuletzt_geaendert.HeaderText = "Zuletzt geändert";
            this.zuletzt_geaendert.Name = "zuletzt_geaendert";
            this.zuletzt_geaendert.ReadOnly = true;
            this.zuletzt_geaendert.Width = 150;
            // 
            // Produktliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 736);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Produkt_hinzufuegen);
            this.Controls.Add(this.Auswaehlen);
            this.Controls.Add(this.Schliessen);
            this.Name = "Produktliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produktliste";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Schliessen;
        private System.Windows.Forms.Button Auswaehlen;
        private System.Windows.Forms.Button Produkt_hinzufuegen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gewicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeichnungsnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn erstellt_am;
        private System.Windows.Forms.DataGridViewTextBoxColumn zuletzt_geaendert;
    }
}