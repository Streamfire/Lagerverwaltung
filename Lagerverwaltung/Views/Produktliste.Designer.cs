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
            this.listView1 = new System.Windows.Forms.ListView();
            this.name_a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gewicht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zeichnungsnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Erstellt_Am = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zuletzt_geaendert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Schliessen = new System.Windows.Forms.Button();
            this.Auswaehlen = new System.Windows.Forms.Button();
            this.Produkt_hinzufuegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_a,
            this.Gewicht,
            this.Preis,
            this.Zeichnungsnummer,
            this.Erstellt_Am,
            this.Zuletzt_geaendert});
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(29, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(949, 639);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name_a
            // 
            this.name_a.Text = "Name";
            this.name_a.Width = 385;
            // 
            // Gewicht
            // 
            this.Gewicht.Text = "Gewicht (kg)";
            this.Gewicht.Width = 100;
            // 
            // Preis
            // 
            this.Preis.Text = "Preis (Euro)";
            this.Preis.Width = 100;
            // 
            // Zeichnungsnummer
            // 
            this.Zeichnungsnummer.Text = "Zeichnungsnummer";
            this.Zeichnungsnummer.Width = 160;
            // 
            // Erstellt_Am
            // 
            this.Erstellt_Am.Text = "Erstellt am";
            this.Erstellt_Am.Width = 100;
            // 
            // Zuletzt_geaendert
            // 
            this.Zuletzt_geaendert.Text = "Zuletzt geändert";
            this.Zuletzt_geaendert.Width = 100;
            // 
            // Schliessen
            // 
            this.Schliessen.Location = new System.Drawing.Point(859, 697);
            this.Schliessen.Name = "Schliessen";
            this.Schliessen.Size = new System.Drawing.Size(120, 35);
            this.Schliessen.TabIndex = 1;
            this.Schliessen.Text = "Schließen";
            this.Schliessen.UseVisualStyleBackColor = true;
            // 
            // Auswaehlen
            // 
            this.Auswaehlen.Location = new System.Drawing.Point(711, 697);
            this.Auswaehlen.Name = "Auswaehlen";
            this.Auswaehlen.Size = new System.Drawing.Size(120, 35);
            this.Auswaehlen.TabIndex = 2;
            this.Auswaehlen.Text = "Auswählen";
            this.Auswaehlen.UseVisualStyleBackColor = true;
            // 
            // Produkt_hinzufuegen
            // 
            this.Produkt_hinzufuegen.Location = new System.Drawing.Point(29, 697);
            this.Produkt_hinzufuegen.Name = "Produkt_hinzufuegen";
            this.Produkt_hinzufuegen.Size = new System.Drawing.Size(120, 35);
            this.Produkt_hinzufuegen.TabIndex = 3;
            this.Produkt_hinzufuegen.Text = "Produkt hinzufügen";
            this.Produkt_hinzufuegen.UseVisualStyleBackColor = true;
            // 
            // Produktliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.Produkt_hinzufuegen);
            this.Controls.Add(this.Auswaehlen);
            this.Controls.Add(this.Schliessen);
            this.Controls.Add(this.listView1);
            this.Name = "Produktliste";
            this.Text = "Produktliste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name_a;
        private System.Windows.Forms.ColumnHeader Gewicht;
        private System.Windows.Forms.ColumnHeader Preis;
        private System.Windows.Forms.ColumnHeader Zeichnungsnummer;
        private System.Windows.Forms.ColumnHeader Erstellt_Am;
        private System.Windows.Forms.ColumnHeader Zuletzt_geaendert;
        private System.Windows.Forms.Button Schliessen;
        private System.Windows.Forms.Button Auswaehlen;
        private System.Windows.Forms.Button Produkt_hinzufuegen;
    }
}