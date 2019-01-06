namespace Lagerverwaltung.Views
{
    partial class ProduktlisteSuche
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produkt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gewicht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeichnungsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Schliessen
            // 
            this.Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Schliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schliessen.Location = new System.Drawing.Point(599, 685);
            this.Schliessen.Name = "Schliessen";
            this.Schliessen.Size = new System.Drawing.Size(120, 35);
            this.Schliessen.TabIndex = 1;
            this.Schliessen.Text = "Abbrechen";
            this.Schliessen.UseVisualStyleBackColor = true;
            this.Schliessen.Click += new System.EventHandler(this.Schliessen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produkt_id,
            this.name,
            this.gewicht,
            this.preis,
            this.zeichnungsnummer});
            this.dataGridView1.Location = new System.Drawing.Point(29, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 582);
            this.dataGridView1.TabIndex = 5;
            // 
            // produkt_id
            // 
            this.produkt_id.DataPropertyName = "Produkt_ID";
            this.produkt_id.HeaderText = "ID";
            this.produkt_id.Name = "produkt_id";
            this.produkt_id.ReadOnly = true;
            this.produkt_id.Width = 60;
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
            this.zeichnungsnummer.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hinweis: Die Produktliste in der Suche dient dazu alle nicht einem Paket zugeordn" +
    "eten Produkte einzusehen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produktliste";
            // 
            // ProduktlisteSuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 736);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Schliessen);
            this.Name = "ProduktlisteSuche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suche";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Schliessen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gewicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeichnungsnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}