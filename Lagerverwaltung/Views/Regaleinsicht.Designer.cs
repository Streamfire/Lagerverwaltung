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
            this.ZurueckButton = new MetroFramework.Controls.MetroButton();
            this.RegaleinsichtGrid = new System.Windows.Forms.DataGridView();
            this.LadeDatenLabel = new System.Windows.Forms.Label();
            this.LagerLabel = new MetroFramework.Controls.MetroLabel();
            this.RegalLabel = new MetroFramework.Controls.MetroLabel();
            this.LagerCombobox = new MetroFramework.Controls.MetroComboBox();
            this.RegalCombobox = new MetroFramework.Controls.MetroComboBox();
            this.AktualisierenButton = new MetroFramework.Controls.MetroButton();
            this.PaketeinlagernButton = new MetroFramework.Controls.MetroButton();
            this.PaketauslagernButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.RegaleinsichtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ZurueckButton
            // 
            this.ZurueckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZurueckButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ZurueckButton.Location = new System.Drawing.Point(652, 456);
            this.ZurueckButton.Name = "ZurueckButton";
            this.ZurueckButton.Size = new System.Drawing.Size(75, 30);
            this.ZurueckButton.TabIndex = 11;
            this.ZurueckButton.Text = "Zurück";
            this.ZurueckButton.UseSelectable = true;
            this.ZurueckButton.Click += new System.EventHandler(this.ZurueckButton_Click);
            // 
            // RegaleinsichtGrid
            // 
            this.RegaleinsichtGrid.BackgroundColor = System.Drawing.Color.White;
            this.RegaleinsichtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegaleinsichtGrid.Location = new System.Drawing.Point(23, 104);
            this.RegaleinsichtGrid.Name = "RegaleinsichtGrid";
            this.RegaleinsichtGrid.Size = new System.Drawing.Size(704, 346);
            this.RegaleinsichtGrid.TabIndex = 12;
            // 
            // LadeDatenLabel
            // 
            this.LadeDatenLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LadeDatenLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LadeDatenLabel.Location = new System.Drawing.Point(23, 104);
            this.LadeDatenLabel.Name = "LadeDatenLabel";
            this.LadeDatenLabel.Size = new System.Drawing.Size(704, 346);
            this.LadeDatenLabel.TabIndex = 13;
            this.LadeDatenLabel.Text = "Es wurden Daten in der Datenbank geändert. Bitte aktualisieren Sie die Daten!";
            this.LadeDatenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LadeDatenLabel.Visible = false;
            // 
            // LagerLabel
            // 
            this.LagerLabel.AutoSize = true;
            this.LagerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LagerLabel.Location = new System.Drawing.Point(23, 73);
            this.LagerLabel.Name = "LagerLabel";
            this.LagerLabel.Size = new System.Drawing.Size(46, 19);
            this.LagerLabel.TabIndex = 14;
            this.LagerLabel.Text = "Lager:";
            // 
            // RegalLabel
            // 
            this.RegalLabel.AutoSize = true;
            this.RegalLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RegalLabel.Location = new System.Drawing.Point(231, 73);
            this.RegalLabel.Name = "RegalLabel";
            this.RegalLabel.Size = new System.Drawing.Size(45, 19);
            this.RegalLabel.TabIndex = 15;
            this.RegalLabel.Text = "Regal:";
            // 
            // LagerCombobox
            // 
            this.LagerCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LagerCombobox.FormattingEnabled = true;
            this.LagerCombobox.ItemHeight = 23;
            this.LagerCombobox.Location = new System.Drawing.Point(75, 69);
            this.LagerCombobox.Name = "LagerCombobox";
            this.LagerCombobox.Size = new System.Drawing.Size(150, 29);
            this.LagerCombobox.TabIndex = 16;
            this.LagerCombobox.UseSelectable = true;
            // 
            // RegalCombobox
            // 
            this.RegalCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegalCombobox.FormattingEnabled = true;
            this.RegalCombobox.ItemHeight = 23;
            this.RegalCombobox.Location = new System.Drawing.Point(282, 69);
            this.RegalCombobox.Name = "RegalCombobox";
            this.RegalCombobox.Size = new System.Drawing.Size(150, 29);
            this.RegalCombobox.TabIndex = 17;
            this.RegalCombobox.UseSelectable = true;
            // 
            // AktualisierenButton
            // 
            this.AktualisierenButton.Enabled = false;
            this.AktualisierenButton.Location = new System.Drawing.Point(438, 73);
            this.AktualisierenButton.Name = "AktualisierenButton";
            this.AktualisierenButton.Size = new System.Drawing.Size(75, 23);
            this.AktualisierenButton.TabIndex = 18;
            this.AktualisierenButton.Text = "Aktualisieren";
            this.AktualisierenButton.UseSelectable = true;
            this.AktualisierenButton.Click += new System.EventHandler(this.AktualisierenButton_Click);
            // 
            // PaketeinlagernButton
            // 
            this.PaketeinlagernButton.Location = new System.Drawing.Point(23, 453);
            this.PaketeinlagernButton.Name = "PaketeinlagernButton";
            this.PaketeinlagernButton.Size = new System.Drawing.Size(98, 23);
            this.PaketeinlagernButton.TabIndex = 19;
            this.PaketeinlagernButton.Text = "Paket einlagern";
            this.PaketeinlagernButton.UseSelectable = true;
            this.PaketeinlagernButton.Click += new System.EventHandler(this.PaketeinlagernButton_Click);
            // 
            // PaketauslagernButton
            // 
            this.PaketauslagernButton.Location = new System.Drawing.Point(127, 453);
            this.PaketauslagernButton.Name = "PaketauslagernButton";
            this.PaketauslagernButton.Size = new System.Drawing.Size(98, 23);
            this.PaketauslagernButton.TabIndex = 20;
            this.PaketauslagernButton.Text = "Paket auslagern";
            this.PaketauslagernButton.UseSelectable = true;
            this.PaketauslagernButton.Click += new System.EventHandler(this.PaketauslagernButton_Click);
            // 
            // Regaleinsicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 500);
            this.Controls.Add(this.PaketauslagernButton);
            this.Controls.Add(this.PaketeinlagernButton);
            this.Controls.Add(this.AktualisierenButton);
            this.Controls.Add(this.RegalCombobox);
            this.Controls.Add(this.LagerCombobox);
            this.Controls.Add(this.RegalLabel);
            this.Controls.Add(this.LagerLabel);
            this.Controls.Add(this.LadeDatenLabel);
            this.Controls.Add(this.RegaleinsichtGrid);
            this.Controls.Add(this.ZurueckButton);
            this.Name = "Regaleinsicht";
            this.Text = "Regaleinsicht";
            this.Load += new System.EventHandler(this.Regaleinsicht_Load);
            this.Shown += new System.EventHandler(this.Regaleinsicht_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RegaleinsichtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private MetroFramework.Controls.MetroButton ZurueckButton;
        private System.Windows.Forms.DataGridView RegaleinsichtGrid;
        private System.Windows.Forms.Label LadeDatenLabel;
        private MetroFramework.Controls.MetroLabel LagerLabel;
        private MetroFramework.Controls.MetroLabel RegalLabel;
        private MetroFramework.Controls.MetroComboBox LagerCombobox;
        private MetroFramework.Controls.MetroComboBox RegalCombobox;
        private MetroFramework.Controls.MetroButton AktualisierenButton;
        private MetroFramework.Controls.MetroButton PaketeinlagernButton;
        private MetroFramework.Controls.MetroButton PaketauslagernButton;
    }
}