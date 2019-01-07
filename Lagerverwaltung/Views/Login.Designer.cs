namespace Lagerverwaltung.Views
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
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
            this.NoteLabel = new MetroFramework.Controls.MetroLabel();
            this.ShowPasswordCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.ErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.GastButton = new MetroFramework.Controls.MetroButton();
            this.PasswortAendernButton = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.NoteLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.NoteLabel.Location = new System.Drawing.Point(20, 180);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(357, 15);
            this.NoteLabel.TabIndex = 16;
            this.NoteLabel.Text = "Bitte Nutzername und Passwort eingeben, oder als Gast fortfahren.";
            // 
            // ShowPasswordCheckbox
            // 
            this.ShowPasswordCheckbox.AutoSize = true;
            this.ShowPasswordCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordCheckbox.Location = new System.Drawing.Point(23, 120);
            this.ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            this.ShowPasswordCheckbox.Size = new System.Drawing.Size(112, 15);
            this.ShowPasswordCheckbox.TabIndex = 19;
            this.ShowPasswordCheckbox.Text = "Klartext anzeigen";
            this.ShowPasswordCheckbox.UseSelectable = true;
            this.ShowPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckbox_CheckedChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ErrorLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(23, 136);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(27, 15);
            this.ErrorLabel.TabIndex = 20;
            this.ErrorLabel.Text = "null";
            this.ErrorLabel.UseCustomForeColor = true;
            this.ErrorLabel.Visible = false;
            // 
            // UsernameTextbox
            // 
            // 
            // 
            // 
            this.UsernameTextbox.CustomButton.Image = null;
            this.UsernameTextbox.CustomButton.Location = new System.Drawing.Point(318, 2);
            this.UsernameTextbox.CustomButton.Name = "";
            this.UsernameTextbox.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.UsernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextbox.CustomButton.TabIndex = 1;
            this.UsernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextbox.CustomButton.UseSelectable = true;
            this.UsernameTextbox.CustomButton.Visible = false;
            this.UsernameTextbox.Lines = new string[0];
            this.UsernameTextbox.Location = new System.Drawing.Point(23, 60);
            this.UsernameTextbox.MaxLength = 32767;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.WaterMark = "Nutzername";
            this.UsernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.SelectionLength = 0;
            this.UsernameTextbox.SelectionStart = 0;
            this.UsernameTextbox.ShortcutsEnabled = true;
            this.UsernameTextbox.Size = new System.Drawing.Size(340, 24);
            this.UsernameTextbox.TabIndex = 21;
            this.UsernameTextbox.UseSelectable = true;
            this.UsernameTextbox.WaterMark = "Nutzername";
            this.UsernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTextbox
            // 
            // 
            // 
            // 
            this.PasswordTextbox.CustomButton.Image = null;
            this.PasswordTextbox.CustomButton.Location = new System.Drawing.Point(318, 2);
            this.PasswordTextbox.CustomButton.Name = "";
            this.PasswordTextbox.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.PasswordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextbox.CustomButton.TabIndex = 1;
            this.PasswordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextbox.CustomButton.UseSelectable = true;
            this.PasswordTextbox.CustomButton.Visible = false;
            this.PasswordTextbox.Lines = new string[0];
            this.PasswordTextbox.Location = new System.Drawing.Point(23, 90);
            this.PasswordTextbox.MaxLength = 32767;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '●';
            this.PasswordTextbox.WaterMark = "Passwort";
            this.PasswordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.SelectionLength = 0;
            this.PasswordTextbox.SelectionStart = 0;
            this.PasswordTextbox.ShortcutsEnabled = true;
            this.PasswordTextbox.Size = new System.Drawing.Size(340, 24);
            this.PasswordTextbox.TabIndex = 22;
            this.PasswordTextbox.UseSelectable = true;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.WaterMark = "Passwort";
            this.PasswordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Location = new System.Drawing.Point(207, 154);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 23;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // GastButton
            // 
            this.GastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GastButton.Location = new System.Drawing.Point(288, 154);
            this.GastButton.Name = "GastButton";
            this.GastButton.Size = new System.Drawing.Size(75, 23);
            this.GastButton.TabIndex = 24;
            this.GastButton.Text = "Gast";
            this.GastButton.UseSelectable = true;
            this.GastButton.Click += new System.EventHandler(this.GastButton_Click);
            // 
            // PasswortAendernButton
            // 
            this.PasswortAendernButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswortAendernButton.Location = new System.Drawing.Point(23, 154);
            this.PasswortAendernButton.Name = "PasswortAendernButton";
            this.PasswortAendernButton.Size = new System.Drawing.Size(100, 23);
            this.PasswortAendernButton.TabIndex = 25;
            this.PasswortAendernButton.Text = "Passwort ändern";
            this.PasswortAendernButton.UseSelectable = true;
            this.PasswortAendernButton.Click += new System.EventHandler(this.PasswortAendernButton_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.PasswortAendernButton);
            this.Controls.Add(this.GastButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ShowPasswordCheckbox);
            this.Controls.Add(this.NoteLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NoteLabel;
        private MetroFramework.Controls.MetroCheckBox ShowPasswordCheckbox;
        private MetroFramework.Controls.MetroLabel ErrorLabel;
        private MetroFramework.Controls.MetroTextBox UsernameTextbox;
        private MetroFramework.Controls.MetroTextBox PasswordTextbox;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroButton GastButton;
        private MetroFramework.Controls.MetroButton PasswortAendernButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

