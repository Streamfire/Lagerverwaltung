namespace Lagerverwaltung.Views
{
	partial class Suche
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerHaltbarBis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerErstelltAm = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerZueltztGeaendert = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxLager = new System.Windows.Forms.CheckBox();
            this.checkBoxRegal = new System.Windows.Forms.CheckBox();
            this.checkBoxPaket = new System.Windows.Forms.CheckBox();
            this.checkBoxProdukt = new System.Windows.Forms.CheckBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(171, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 24);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bezeichnung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Haltbar bis:";
            // 
            // dateTimePickerHaltbarBis
            // 
            this.dateTimePickerHaltbarBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHaltbarBis.Location = new System.Drawing.Point(171, 118);
            this.dateTimePickerHaltbarBis.Name = "dateTimePickerHaltbarBis";
            this.dateTimePickerHaltbarBis.Size = new System.Drawing.Size(317, 24);
            this.dateTimePickerHaltbarBis.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ertsellt am:";
            // 
            // dateTimePickerErstelltAm
            // 
            this.dateTimePickerErstelltAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerErstelltAm.Location = new System.Drawing.Point(171, 159);
            this.dateTimePickerErstelltAm.Name = "dateTimePickerErstelltAm";
            this.dateTimePickerErstelltAm.Size = new System.Drawing.Size(317, 24);
            this.dateTimePickerErstelltAm.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zuletzt geändert:";
            // 
            // dateTimePickerZueltztGeaendert
            // 
            this.dateTimePickerZueltztGeaendert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerZueltztGeaendert.Location = new System.Drawing.Point(171, 200);
            this.dateTimePickerZueltztGeaendert.Name = "dateTimePickerZueltztGeaendert";
            this.dateTimePickerZueltztGeaendert.Size = new System.Drawing.Size(317, 24);
            this.dateTimePickerZueltztGeaendert.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 352);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lager";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Regalbezeichnung";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Paketbezeichnung";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Produktbezeichnung";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Haltbar bis";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "erstellt am";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "zuletzt geändert";
            this.Column7.Name = "Column7";
            // 
            // checkBoxLager
            // 
            this.checkBoxLager.AutoSize = true;
            this.checkBoxLager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLager.Location = new System.Drawing.Point(171, 41);
            this.checkBoxLager.Name = "checkBoxLager";
            this.checkBoxLager.Size = new System.Drawing.Size(64, 22);
            this.checkBoxLager.TabIndex = 11;
            this.checkBoxLager.Text = "Lager";
            this.checkBoxLager.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegal
            // 
            this.checkBoxRegal.AutoSize = true;
            this.checkBoxRegal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRegal.Location = new System.Drawing.Point(251, 41);
            this.checkBoxRegal.Name = "checkBoxRegal";
            this.checkBoxRegal.Size = new System.Drawing.Size(65, 22);
            this.checkBoxRegal.TabIndex = 12;
            this.checkBoxRegal.Text = "Regal";
            this.checkBoxRegal.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaket
            // 
            this.checkBoxPaket.AutoSize = true;
            this.checkBoxPaket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPaket.Location = new System.Drawing.Point(331, 41);
            this.checkBoxPaket.Name = "checkBoxPaket";
            this.checkBoxPaket.Size = new System.Drawing.Size(65, 22);
            this.checkBoxPaket.TabIndex = 13;
            this.checkBoxPaket.Text = "Paket";
            this.checkBoxPaket.UseVisualStyleBackColor = true;
            // 
            // checkBoxProdukt
            // 
            this.checkBoxProdukt.AutoSize = true;
            this.checkBoxProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProdukt.Location = new System.Drawing.Point(409, 41);
            this.checkBoxProdukt.Name = "checkBoxProdukt";
            this.checkBoxProdukt.Size = new System.Drawing.Size(79, 22);
            this.checkBoxProdukt.TabIndex = 14;
            this.checkBoxProdukt.Text = "Produkt";
            this.checkBoxProdukt.UseVisualStyleBackColor = true;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuchen.Location = new System.Drawing.Point(558, 81);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(125, 46);
            this.buttonSuchen.TabIndex = 15;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbbrechen.Location = new System.Drawing.Point(558, 150);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(125, 46);
            this.buttonAbbrechen.TabIndex = 16;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // Suche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 617);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonSuchen);
            this.Controls.Add(this.checkBoxProdukt);
            this.Controls.Add(this.checkBoxPaket);
            this.Controls.Add(this.checkBoxRegal);
            this.Controls.Add(this.checkBoxLager);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerZueltztGeaendert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerErstelltAm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerHaltbarBis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Suche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SucheFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerHaltbarBis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerErstelltAm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerZueltztGeaendert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox checkBoxLager;
        private System.Windows.Forms.CheckBox checkBoxRegal;
        private System.Windows.Forms.CheckBox checkBoxPaket;
        private System.Windows.Forms.CheckBox checkBoxProdukt;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}