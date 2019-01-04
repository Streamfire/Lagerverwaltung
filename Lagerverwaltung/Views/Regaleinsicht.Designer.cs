namespace Lagerverwaltung.Views
{
	partial class Regaleinsicht
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewRegaleinsicht = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRegal = new System.Windows.Forms.ComboBox();
            this.comboBoxLager = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonZurueck = new System.Windows.Forms.Button();
            this.ButtonAktualisieren = new System.Windows.Forms.Button();
            this.ButtonHinzufuegen = new System.Windows.Forms.Button();
            this.ButtonEntfernen = new System.Windows.Forms.Button();
            this.labelAktualisieren = new System.Windows.Forms.Label();
            this.lagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegaleinsicht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRegaleinsicht
            // 
            this.dataGridViewRegaleinsicht.AllowUserToAddRows = false;
            this.dataGridViewRegaleinsicht.AllowUserToDeleteRows = false;
            this.dataGridViewRegaleinsicht.AllowUserToResizeColumns = false;
            this.dataGridViewRegaleinsicht.AllowUserToResizeRows = false;
            this.dataGridViewRegaleinsicht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRegaleinsicht.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRegaleinsicht.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewRegaleinsicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegaleinsicht.ColumnHeadersVisible = false;
            this.dataGridViewRegaleinsicht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewRegaleinsicht.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewRegaleinsicht.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewRegaleinsicht.MultiSelect = false;
            this.dataGridViewRegaleinsicht.Name = "dataGridViewRegaleinsicht";
            this.dataGridViewRegaleinsicht.ReadOnly = true;
            this.dataGridViewRegaleinsicht.RowHeadersVisible = false;
            this.dataGridViewRegaleinsicht.ShowEditingIcon = false;
            this.dataGridViewRegaleinsicht.Size = new System.Drawing.Size(970, 450);
            this.dataGridViewRegaleinsicht.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regal ";
            // 
            // comboBoxRegal
            // 
            this.comboBoxRegal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegal.FormattingEnabled = true;
            this.comboBoxRegal.Location = new System.Drawing.Point(345, 9);
            this.comboBoxRegal.Name = "comboBoxRegal";
            this.comboBoxRegal.Size = new System.Drawing.Size(194, 21);
            this.comboBoxRegal.TabIndex = 2;
            this.comboBoxRegal.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRegal_SelectedIndexChanged);
            // 
            // comboBoxLager
            // 
            this.comboBoxLager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLager.FormattingEnabled = true;
            this.comboBoxLager.Location = new System.Drawing.Point(68, 9);
            this.comboBoxLager.Name = "comboBoxLager";
            this.comboBoxLager.Size = new System.Drawing.Size(194, 21);
            this.comboBoxLager.TabIndex = 4;
            this.comboBoxLager.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLager_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lager";
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZurueck.Location = new System.Drawing.Point(893, 506);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Size = new System.Drawing.Size(91, 46);
            this.ButtonZurueck.TabIndex = 5;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = true;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            // 
            // ButtonAktualisieren
            // 
            this.ButtonAktualisieren.Enabled = false;
            this.ButtonAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ButtonAktualisieren.Location = new System.Drawing.Point(565, 5);
            this.ButtonAktualisieren.Name = "ButtonAktualisieren";
            this.ButtonAktualisieren.Size = new System.Drawing.Size(100, 28);
            this.ButtonAktualisieren.TabIndex = 6;
            this.ButtonAktualisieren.Text = "Aktualisieren";
            this.ButtonAktualisieren.UseVisualStyleBackColor = true;
            this.ButtonAktualisieren.Click += new System.EventHandler(this.ButtonAktualisieren_Click);
            // 
            // ButtonHinzufuegen
            // 
            this.ButtonHinzufuegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ButtonHinzufuegen.Location = new System.Drawing.Point(12, 506);
            this.ButtonHinzufuegen.Name = "ButtonHinzufuegen";
            this.ButtonHinzufuegen.Size = new System.Drawing.Size(132, 46);
            this.ButtonHinzufuegen.TabIndex = 7;
            this.ButtonHinzufuegen.Text = "Paket Einlagern";
            this.ButtonHinzufuegen.UseVisualStyleBackColor = true;
            this.ButtonHinzufuegen.Click += new System.EventHandler(this.ButtonHinzufuegen_Click);
            // 
            // ButtonEntfernen
            // 
            this.ButtonEntfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ButtonEntfernen.Location = new System.Drawing.Point(160, 506);
            this.ButtonEntfernen.Name = "ButtonEntfernen";
            this.ButtonEntfernen.Size = new System.Drawing.Size(132, 46);
            this.ButtonEntfernen.TabIndex = 8;
            this.ButtonEntfernen.Text = "Paket Auslagern";
            this.ButtonEntfernen.UseVisualStyleBackColor = true;
            // 
            // labelAktualisieren
            // 
            this.labelAktualisieren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAktualisieren.AutoSize = true;
            this.labelAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAktualisieren.ForeColor = System.Drawing.Color.Red;
            this.labelAktualisieren.Location = new System.Drawing.Point(242, 256);
            this.labelAktualisieren.Name = "labelAktualisieren";
            this.labelAktualisieren.Size = new System.Drawing.Size(564, 20);
            this.labelAktualisieren.TabIndex = 9;
            this.labelAktualisieren.Text = "Es wurden Daten in der Datenbank geändert. Bitte aktualisieren Sie die Daten!";
            this.labelAktualisieren.Visible = false;
            // 
            // lagerBindingSource
            // 
            this.lagerBindingSource.DataSource = typeof(Lagerverwaltung.Model.Lager);
            // 
            // Regaleinsicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 563);
            this.Controls.Add(this.labelAktualisieren);
            this.Controls.Add(this.ButtonEntfernen);
            this.Controls.Add(this.ButtonHinzufuegen);
            this.Controls.Add(this.ButtonAktualisieren);
            this.Controls.Add(this.ButtonZurueck);
            this.Controls.Add(this.comboBoxLager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRegal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRegaleinsicht);
            this.Name = "Regaleinsicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regaleinsicht";
            this.Load += new System.EventHandler(this.Regaleinsicht_Load);
            this.Shown += new System.EventHandler(this.Regaleinsicht_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegaleinsicht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewRegaleinsicht;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxRegal;
		private System.Windows.Forms.ComboBox comboBoxLager;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource lagerBindingSource;
        private System.Windows.Forms.Button ButtonZurueck;
        private System.Windows.Forms.Button ButtonAktualisieren;
        private System.Windows.Forms.Button ButtonHinzufuegen;
        private System.Windows.Forms.Button ButtonEntfernen;
        private System.Windows.Forms.Label labelAktualisieren;
    }
}