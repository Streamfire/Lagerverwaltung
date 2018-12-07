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
            this.dataGridViewRegaleinsicht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRegaleinsicht.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRegaleinsicht.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRegaleinsicht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRegaleinsicht.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewRegaleinsicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegaleinsicht.ColumnHeadersVisible = false;
            this.dataGridViewRegaleinsicht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewRegaleinsicht.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewRegaleinsicht.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewRegaleinsicht.Name = "dataGridViewRegaleinsicht";
            this.dataGridViewRegaleinsicht.RowHeadersVisible = false;
            this.dataGridViewRegaleinsicht.ShowEditingIcon = false;
            this.dataGridViewRegaleinsicht.Size = new System.Drawing.Size(898, 405);
            this.dataGridViewRegaleinsicht.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regal ";
            // 
            // comboBoxRegal
            // 
            this.comboBoxRegal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegal.FormattingEnabled = true;
            this.comboBoxRegal.Location = new System.Drawing.Point(353, 11);
            this.comboBoxRegal.Name = "comboBoxRegal";
            this.comboBoxRegal.Size = new System.Drawing.Size(194, 21);
            this.comboBoxRegal.TabIndex = 2;
            // 
            // comboBoxLager
            // 
            this.comboBoxLager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLager.FormattingEnabled = true;
            this.comboBoxLager.Location = new System.Drawing.Point(68, 11);
            this.comboBoxLager.Name = "comboBoxLager";
            this.comboBoxLager.Size = new System.Drawing.Size(194, 21);
            this.comboBoxLager.TabIndex = 4;
            this.comboBoxLager.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLager_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lager";
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZurueck.Location = new System.Drawing.Point(831, 504);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Size = new System.Drawing.Size(91, 46);
            this.ButtonZurueck.TabIndex = 5;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = true;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            // 
            // lagerBindingSource
            // 
            this.lagerBindingSource.DataSource = typeof(Lagerverwaltung.Model.Lager);
            // 
            // Regaleinsicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.ButtonZurueck);
            this.Controls.Add(this.comboBoxLager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRegal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRegaleinsicht);
            this.Name = "Regaleinsicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regaleinsicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegalFormClosing);
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
    }
}