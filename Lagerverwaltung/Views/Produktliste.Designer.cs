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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.Produkt_hinzufuegen = new MetroFramework.Controls.MetroButton();
            this.Button1 = new MetroFramework.Controls.MetroButton();
            this.Auswaehlen = new MetroFramework.Controls.MetroButton();
            this.Schliessen = new MetroFramework.Controls.MetroButton();
            this.produkt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gewicht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeichnungsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produkt_id,
            this.name,
            this.gewicht,
            this.preis,
            this.zeichnungsnummer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(29, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(689, 582);
            this.dataGridView1.TabIndex = 6;
            // 
            // Produkt_hinzufuegen
            // 
            this.Produkt_hinzufuegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Produkt_hinzufuegen.Location = new System.Drawing.Point(29, 624);
            this.Produkt_hinzufuegen.Name = "Produkt_hinzufuegen";
            this.Produkt_hinzufuegen.Size = new System.Drawing.Size(130, 30);
            this.Produkt_hinzufuegen.TabIndex = 7;
            this.Produkt_hinzufuegen.Text = "Produkt hinzufügen";
            this.Produkt_hinzufuegen.UseSelectable = true;
            this.Produkt_hinzufuegen.Click += new System.EventHandler(this.Produkt_hinzufuegen_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button1.Location = new System.Drawing.Point(201, 624);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 30);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Produkt ändern";
            this.Button1.UseSelectable = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Auswaehlen
            // 
            this.Auswaehlen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Auswaehlen.Location = new System.Drawing.Point(511, 624);
            this.Auswaehlen.Name = "Auswaehlen";
            this.Auswaehlen.Size = new System.Drawing.Size(85, 30);
            this.Auswaehlen.TabIndex = 9;
            this.Auswaehlen.Text = "Auswählen";
            this.Auswaehlen.UseSelectable = true;
            this.Auswaehlen.Click += new System.EventHandler(this.Auswaehlen_Click);
            // 
            // Schliessen
            // 
            this.Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Schliessen.Location = new System.Drawing.Point(633, 624);
            this.Schliessen.Name = "Schliessen";
            this.Schliessen.Size = new System.Drawing.Size(85, 30);
            this.Schliessen.TabIndex = 10;
            this.Schliessen.Text = "Abbrechen";
            this.Schliessen.UseSelectable = true;
            this.Schliessen.Click += new System.EventHandler(this.Schliessen_Click);
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
            // Produktliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 677);
            this.Controls.Add(this.Schliessen);
            this.Controls.Add(this.Auswaehlen);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Produkt_hinzufuegen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Produktliste";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private MetroFramework.Controls.MetroButton Produkt_hinzufuegen;
        private MetroFramework.Controls.MetroButton Button1;
        private MetroFramework.Controls.MetroButton Auswaehlen;
        private MetroFramework.Controls.MetroButton Schliessen;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gewicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeichnungsnummer;
    }
}