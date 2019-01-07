namespace Lagerverwaltung.Views
{
    partial class RegalAendern_Entfernen
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
            this.RegalLabel = new MetroFramework.Controls.MetroLabel();
            this.LagerLabel = new MetroFramework.Controls.MetroLabel();
            this.ZeilenLabel = new MetroFramework.Controls.MetroLabel();
            this.SpaltenLabel = new MetroFramework.Controls.MetroLabel();
            this.AendernButton = new MetroFramework.Controls.MetroButton();
            this.EntfernenButton = new MetroFramework.Controls.MetroButton();
            this.AbbrechenButton = new MetroFramework.Controls.MetroButton();
            this.LagerCombobox = new MetroFramework.Controls.MetroComboBox();
            this.RegalCombobox = new MetroFramework.Controls.MetroComboBox();
            this.SpalteTextbox = new MetroFramework.Controls.MetroTextBox();
            this.ZeilenTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegalLabel
            // 
            this.RegalLabel.AutoSize = true;
            this.RegalLabel.Location = new System.Drawing.Point(24, 107);
            this.RegalLabel.Name = "RegalLabel";
            this.RegalLabel.Size = new System.Drawing.Size(45, 19);
            this.RegalLabel.TabIndex = 12;
            this.RegalLabel.Text = "Regal:";
            // 
            // LagerLabel
            // 
            this.LagerLabel.AutoSize = true;
            this.LagerLabel.Location = new System.Drawing.Point(23, 72);
            this.LagerLabel.Name = "LagerLabel";
            this.LagerLabel.Size = new System.Drawing.Size(46, 19);
            this.LagerLabel.TabIndex = 13;
            this.LagerLabel.Text = "Lager:";
            // 
            // ZeilenLabel
            // 
            this.ZeilenLabel.AutoSize = true;
            this.ZeilenLabel.Location = new System.Drawing.Point(77, 142);
            this.ZeilenLabel.Name = "ZeilenLabel";
            this.ZeilenLabel.Size = new System.Drawing.Size(47, 19);
            this.ZeilenLabel.TabIndex = 14;
            this.ZeilenLabel.Text = "Zeilen:";
            // 
            // SpaltenLabel
            // 
            this.SpaltenLabel.AutoSize = true;
            this.SpaltenLabel.Location = new System.Drawing.Point(69, 171);
            this.SpaltenLabel.Name = "SpaltenLabel";
            this.SpaltenLabel.Size = new System.Drawing.Size(55, 19);
            this.SpaltenLabel.TabIndex = 15;
            this.SpaltenLabel.Text = "Spalten:";
            // 
            // AendernButton
            // 
            this.AendernButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AendernButton.Location = new System.Drawing.Point(90, 204);
            this.AendernButton.Name = "AendernButton";
            this.AendernButton.Size = new System.Drawing.Size(75, 23);
            this.AendernButton.TabIndex = 16;
            this.AendernButton.Text = "Ändern";
            this.AendernButton.UseSelectable = true;
            this.AendernButton.Click += new System.EventHandler(this.AendernButton_Click);
            // 
            // EntfernenButton
            // 
            this.EntfernenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntfernenButton.Location = new System.Drawing.Point(171, 204);
            this.EntfernenButton.Name = "EntfernenButton";
            this.EntfernenButton.Size = new System.Drawing.Size(75, 23);
            this.EntfernenButton.TabIndex = 17;
            this.EntfernenButton.Text = "Entfernen";
            this.EntfernenButton.UseSelectable = true;
            this.EntfernenButton.Click += new System.EventHandler(this.EntfernenButton_Click);
            // 
            // AbbrechenButton
            // 
            this.AbbrechenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbbrechenButton.Location = new System.Drawing.Point(252, 204);
            this.AbbrechenButton.Name = "AbbrechenButton";
            this.AbbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.AbbrechenButton.TabIndex = 18;
            this.AbbrechenButton.Text = "Abbrechen";
            this.AbbrechenButton.UseSelectable = true;
            this.AbbrechenButton.Click += new System.EventHandler(this.AbbrechenButton_Click);
            // 
            // LagerCombobox
            // 
            this.LagerCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LagerCombobox.FormattingEnabled = true;
            this.LagerCombobox.ItemHeight = 23;
            this.LagerCombobox.Location = new System.Drawing.Point(75, 72);
            this.LagerCombobox.Name = "LagerCombobox";
            this.LagerCombobox.Size = new System.Drawing.Size(252, 29);
            this.LagerCombobox.TabIndex = 19;
            this.LagerCombobox.UseSelectable = true;
            // 
            // RegalCombobox
            // 
            this.RegalCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegalCombobox.FormattingEnabled = true;
            this.RegalCombobox.ItemHeight = 23;
            this.RegalCombobox.Location = new System.Drawing.Point(75, 107);
            this.RegalCombobox.Name = "RegalCombobox";
            this.RegalCombobox.Size = new System.Drawing.Size(252, 29);
            this.RegalCombobox.TabIndex = 20;
            this.RegalCombobox.UseSelectable = true;
            // 
            // SpalteTextbox
            // 
            // 
            // 
            // 
            this.SpalteTextbox.CustomButton.Image = null;
            this.SpalteTextbox.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.SpalteTextbox.CustomButton.Name = "";
            this.SpalteTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SpalteTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SpalteTextbox.CustomButton.TabIndex = 1;
            this.SpalteTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SpalteTextbox.CustomButton.UseSelectable = true;
            this.SpalteTextbox.CustomButton.Visible = false;
            this.SpalteTextbox.Lines = new string[0];
            this.SpalteTextbox.Location = new System.Drawing.Point(130, 171);
            this.SpalteTextbox.MaxLength = 32767;
            this.SpalteTextbox.Name = "SpalteTextbox";
            this.SpalteTextbox.PasswordChar = '\0';
            this.SpalteTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SpalteTextbox.SelectedText = "";
            this.SpalteTextbox.SelectionLength = 0;
            this.SpalteTextbox.SelectionStart = 0;
            this.SpalteTextbox.ShortcutsEnabled = true;
            this.SpalteTextbox.Size = new System.Drawing.Size(50, 23);
            this.SpalteTextbox.TabIndex = 21;
            this.SpalteTextbox.UseSelectable = true;
            this.SpalteTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SpalteTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ZeilenTextbox
            // 
            // 
            // 
            // 
            this.ZeilenTextbox.CustomButton.Image = null;
            this.ZeilenTextbox.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.ZeilenTextbox.CustomButton.Name = "";
            this.ZeilenTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ZeilenTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ZeilenTextbox.CustomButton.TabIndex = 1;
            this.ZeilenTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ZeilenTextbox.CustomButton.UseSelectable = true;
            this.ZeilenTextbox.CustomButton.Visible = false;
            this.ZeilenTextbox.Lines = new string[0];
            this.ZeilenTextbox.Location = new System.Drawing.Point(130, 142);
            this.ZeilenTextbox.MaxLength = 32767;
            this.ZeilenTextbox.Name = "ZeilenTextbox";
            this.ZeilenTextbox.PasswordChar = '\0';
            this.ZeilenTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ZeilenTextbox.SelectedText = "";
            this.ZeilenTextbox.SelectionLength = 0;
            this.ZeilenTextbox.SelectionStart = 0;
            this.ZeilenTextbox.ShortcutsEnabled = true;
            this.ZeilenTextbox.Size = new System.Drawing.Size(50, 23);
            this.ZeilenTextbox.TabIndex = 22;
            this.ZeilenTextbox.UseSelectable = true;
            this.ZeilenTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ZeilenTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // RegalAendern_Entfernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.ZeilenTextbox);
            this.Controls.Add(this.SpalteTextbox);
            this.Controls.Add(this.RegalCombobox);
            this.Controls.Add(this.LagerCombobox);
            this.Controls.Add(this.AbbrechenButton);
            this.Controls.Add(this.EntfernenButton);
            this.Controls.Add(this.AendernButton);
            this.Controls.Add(this.SpaltenLabel);
            this.Controls.Add(this.ZeilenLabel);
            this.Controls.Add(this.LagerLabel);
            this.Controls.Add(this.RegalLabel);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "RegalAendern_Entfernen";
            this.Resizable = false;
            this.Text = "Regal ändern oder entfernen";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel RegalLabel;
        private MetroFramework.Controls.MetroLabel LagerLabel;
        private MetroFramework.Controls.MetroLabel ZeilenLabel;
        private MetroFramework.Controls.MetroLabel SpaltenLabel;
        private MetroFramework.Controls.MetroButton AendernButton;
        private MetroFramework.Controls.MetroButton EntfernenButton;
        private MetroFramework.Controls.MetroButton AbbrechenButton;
        private MetroFramework.Controls.MetroComboBox LagerCombobox;
        private MetroFramework.Controls.MetroComboBox RegalCombobox;
        private MetroFramework.Controls.MetroTextBox SpalteTextbox;
        private MetroFramework.Controls.MetroTextBox ZeilenTextbox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}