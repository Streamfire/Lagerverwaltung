namespace Lagerverwaltung.Views
{
    partial class AboutBox
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionTextbox = new MetroFramework.Controls.MetroTextBox();
            this.OkButton = new MetroFramework.Controls.MetroButton();
            this.ProductLabel = new MetroFramework.Controls.MetroLabel();
            this.VersionLabel = new MetroFramework.Controls.MetroLabel();
            this.CopyrightLabel = new MetroFramework.Controls.MetroLabel();
            this.CompanynameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.DescriptionTextbox, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.OkButton, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.ProductLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.VersionLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.CopyrightLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.CompanynameLabel, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 60);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 214);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // DescriptionTextbox
            // 
            // 
            // 
            // 
            this.DescriptionTextbox.CustomButton.Image = null;
            this.DescriptionTextbox.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.DescriptionTextbox.CustomButton.Name = "";
            this.DescriptionTextbox.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.DescriptionTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescriptionTextbox.CustomButton.TabIndex = 1;
            this.DescriptionTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescriptionTextbox.CustomButton.UseSelectable = true;
            this.DescriptionTextbox.CustomButton.Visible = false;
            this.DescriptionTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTextbox.Lines = new string[0];
            this.DescriptionTextbox.Location = new System.Drawing.Point(140, 87);
            this.DescriptionTextbox.MaxLength = 32767;
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.PasswordChar = '\0';
            this.DescriptionTextbox.WaterMark = "Beschreibung";
            this.DescriptionTextbox.ReadOnly = true;
            this.DescriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionTextbox.SelectedText = "";
            this.DescriptionTextbox.SelectionLength = 0;
            this.DescriptionTextbox.SelectionStart = 0;
            this.DescriptionTextbox.ShortcutsEnabled = true;
            this.DescriptionTextbox.Size = new System.Drawing.Size(274, 101);
            this.DescriptionTextbox.TabIndex = 1;
            this.DescriptionTextbox.UseSelectable = true;
            this.DescriptionTextbox.WaterMark = "Beschreibung";
            this.DescriptionTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescriptionTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Location = new System.Drawing.Point(339, 194);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 17);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseSelectable = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ProductLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ProductLabel.Location = new System.Drawing.Point(140, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(274, 21);
            this.ProductLabel.TabIndex = 24;
            this.ProductLabel.Text = "Product";
            this.ProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.VersionLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.VersionLabel.Location = new System.Drawing.Point(140, 21);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(274, 21);
            this.VersionLabel.TabIndex = 25;
            this.VersionLabel.Text = "Version";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyrightLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.CopyrightLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CopyrightLabel.Location = new System.Drawing.Point(140, 42);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(274, 21);
            this.CopyrightLabel.TabIndex = 26;
            this.CopyrightLabel.Text = "Copyright";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanynameLabel
            // 
            this.CompanynameLabel.AutoSize = true;
            this.CompanynameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanynameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.CompanynameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CompanynameLabel.Location = new System.Drawing.Point(140, 63);
            this.CompanynameLabel.Name = "CompanynameLabel";
            this.CompanynameLabel.Size = new System.Drawing.Size(274, 21);
            this.CompanynameLabel.TabIndex = 27;
            this.CompanynameLabel.Text = "Firmenname";
            this.CompanynameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // AboutBox
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9, 60, 9, 9);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AboutBox";
            this.TopMost = true;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MetroFramework.Controls.MetroTextBox DescriptionTextbox;
        private MetroFramework.Controls.MetroButton OkButton;
        private MetroFramework.Controls.MetroLabel ProductLabel;
        private MetroFramework.Controls.MetroLabel VersionLabel;
        private MetroFramework.Controls.MetroLabel CopyrightLabel;
        private MetroFramework.Controls.MetroLabel CompanynameLabel;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}
