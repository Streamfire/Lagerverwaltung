namespace Lagerverwaltung.Views
{
    partial class RegalAendern
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
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.AendernButton = new MetroFramework.Controls.MetroButton();
            this.EntfernenButton = new MetroFramework.Controls.MetroButton();
            this.AbbrechenButton = new MetroFramework.Controls.MetroButton();
            this.LagerCombobox = new MetroFramework.Controls.MetroComboBox();
            this.RegalCombobox = new MetroFramework.Controls.MetroComboBox();
            this.NameTextbox = new MetroFramework.Controls.MetroTextBox();
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
            this.LagerLabel.Size = new System.Drawing.Size(45, 19);
            this.LagerLabel.TabIndex = 13;
            this.LagerLabel.Text = "Lager:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(23, 144);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(118, 19);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Neuer Regalname:";
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
            this.LagerCombobox.SelectedIndexChanged += new System.EventHandler(this.LagerCombobox_SelectedIndexChanged);
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
            this.RegalCombobox.SelectedIndexChanged += new System.EventHandler(this.RegalCombobox_SelectedIndexChanged);
            // 
            // NameTextbox
            // 
            // 
            // 
            // 
            this.NameTextbox.CustomButton.Image = null;
            this.NameTextbox.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.NameTextbox.CustomButton.Name = "";
            this.NameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextbox.CustomButton.TabIndex = 1;
            this.NameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextbox.CustomButton.UseSelectable = true;
            this.NameTextbox.CustomButton.Visible = false;
            this.NameTextbox.Lines = new string[0];
            this.NameTextbox.Location = new System.Drawing.Point(147, 144);
            this.NameTextbox.MaxLength = 15;
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.PasswordChar = '\0';
            this.NameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextbox.SelectedText = "";
            this.NameTextbox.SelectionLength = 0;
            this.NameTextbox.SelectionStart = 0;
            this.NameTextbox.ShortcutsEnabled = true;
            this.NameTextbox.Size = new System.Drawing.Size(180, 23);
            this.NameTextbox.TabIndex = 22;
            this.NameTextbox.UseSelectable = true;
            this.NameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // RegalAendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.RegalCombobox);
            this.Controls.Add(this.LagerCombobox);
            this.Controls.Add(this.AbbrechenButton);
            this.Controls.Add(this.EntfernenButton);
            this.Controls.Add(this.AendernButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LagerLabel);
            this.Controls.Add(this.RegalLabel);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "RegalAendern";
            this.Resizable = false;
            this.Text = "Regal ändern oder entfernen";
            this.Load += new System.EventHandler(this.RegalAendern_Entfernen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel RegalLabel;
        private MetroFramework.Controls.MetroLabel LagerLabel;
        private MetroFramework.Controls.MetroLabel NameLabel;
        private MetroFramework.Controls.MetroButton AendernButton;
        private MetroFramework.Controls.MetroButton EntfernenButton;
        private MetroFramework.Controls.MetroButton AbbrechenButton;
        private MetroFramework.Controls.MetroComboBox LagerCombobox;
        private MetroFramework.Controls.MetroComboBox RegalCombobox;
        private MetroFramework.Controls.MetroTextBox NameTextbox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}