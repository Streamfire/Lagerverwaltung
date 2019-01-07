namespace Lagerverwaltung.Views
{
    partial class RegalHinzufuegen
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
            this.LagerLabel = new MetroFramework.Controls.MetroLabel();
            this.LagerCombobox = new MetroFramework.Controls.MetroComboBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.StaerkeV = new MetroFramework.Controls.MetroTextBox();
            this.StaerkeH = new MetroFramework.Controls.MetroTextBox();
            this.BezeichnungTextbox = new MetroFramework.Controls.MetroTextBox();
            this.ZeilenTextbox = new MetroFramework.Controls.MetroTextBox();
            this.SpaltenTextbox = new MetroFramework.Controls.MetroTextBox();
            this.HinzufuegenButton = new MetroFramework.Controls.MetroButton();
            this.AbbrechenButton = new MetroFramework.Controls.MetroButton();
            this.RegalhoeheTextbox = new MetroFramework.Controls.MetroTextBox();
            this.RegalbreiteTextbox = new MetroFramework.Controls.MetroTextBox();
            this.RegallaengeTextbox = new MetroFramework.Controls.MetroTextBox();
            this.FachhoeheTextbox = new MetroFramework.Controls.MetroTextBox();
            this.FachbreiteTextbox = new MetroFramework.Controls.MetroTextBox();
            this.FachlaengeTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LagerLabel
            // 
            this.LagerLabel.AutoSize = true;
            this.LagerLabel.Location = new System.Drawing.Point(18, 83);
            this.LagerLabel.Name = "LagerLabel";
            this.LagerLabel.Size = new System.Drawing.Size(45, 19);
            this.LagerLabel.TabIndex = 36;
            this.LagerLabel.Text = "Lager:";
            // 
            // LagerCombobox
            // 
            this.LagerCombobox.FormattingEnabled = true;
            this.LagerCombobox.ItemHeight = 23;
            this.LagerCombobox.Location = new System.Drawing.Point(70, 83);
            this.LagerCombobox.Name = "LagerCombobox";
            this.LagerCombobox.Size = new System.Drawing.Size(175, 29);
            this.LagerCombobox.TabIndex = 37;
            this.LagerCombobox.UseSelectable = true;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.StaerkeV);
            this.GroupBox.Controls.Add(this.StaerkeH);
            this.GroupBox.Location = new System.Drawing.Point(70, 173);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(175, 79);
            this.GroupBox.TabIndex = 38;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Wandstärke festlegen";
            // 
            // StaerkeV
            // 
            // 
            // 
            // 
            this.StaerkeV.CustomButton.Image = null;
            this.StaerkeV.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.StaerkeV.CustomButton.Name = "";
            this.StaerkeV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StaerkeV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StaerkeV.CustomButton.TabIndex = 1;
            this.StaerkeV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StaerkeV.CustomButton.UseSelectable = true;
            this.StaerkeV.CustomButton.Visible = false;
            this.StaerkeV.Lines = new string[0];
            this.StaerkeV.Location = new System.Drawing.Point(6, 19);
            this.StaerkeV.MaxLength = 32767;
            this.StaerkeV.Name = "StaerkeV";
            this.StaerkeV.PasswordChar = '\0';
            this.StaerkeV.PromptText = "Wandstärke horizontal (cm)";
            this.StaerkeV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StaerkeV.SelectedText = "";
            this.StaerkeV.SelectionLength = 0;
            this.StaerkeV.SelectionStart = 0;
            this.StaerkeV.ShortcutsEnabled = true;
            this.StaerkeV.Size = new System.Drawing.Size(163, 23);
            this.StaerkeV.TabIndex = 51;
            this.StaerkeV.UseSelectable = true;
            this.StaerkeV.WaterMark = "Wandstärke horizontal (cm)";
            this.StaerkeV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StaerkeV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StaerkeH
            // 
            // 
            // 
            // 
            this.StaerkeH.CustomButton.Image = null;
            this.StaerkeH.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.StaerkeH.CustomButton.Name = "";
            this.StaerkeH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StaerkeH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StaerkeH.CustomButton.TabIndex = 1;
            this.StaerkeH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StaerkeH.CustomButton.UseSelectable = true;
            this.StaerkeH.CustomButton.Visible = false;
            this.StaerkeH.Lines = new string[0];
            this.StaerkeH.Location = new System.Drawing.Point(6, 48);
            this.StaerkeH.MaxLength = 32767;
            this.StaerkeH.Name = "StaerkeH";
            this.StaerkeH.PasswordChar = '\0';
            this.StaerkeH.PromptText = "Wandstärke vertikal (cm)";
            this.StaerkeH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StaerkeH.SelectedText = "";
            this.StaerkeH.SelectionLength = 0;
            this.StaerkeH.SelectionStart = 0;
            this.StaerkeH.ShortcutsEnabled = true;
            this.StaerkeH.Size = new System.Drawing.Size(163, 23);
            this.StaerkeH.TabIndex = 50;
            this.StaerkeH.UseSelectable = true;
            this.StaerkeH.WaterMark = "Wandstärke vertikal (cm)";
            this.StaerkeH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StaerkeH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BezeichnungTextbox
            // 
            // 
            // 
            // 
            this.BezeichnungTextbox.CustomButton.Image = null;
            this.BezeichnungTextbox.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.BezeichnungTextbox.CustomButton.Name = "";
            this.BezeichnungTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BezeichnungTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BezeichnungTextbox.CustomButton.TabIndex = 1;
            this.BezeichnungTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BezeichnungTextbox.CustomButton.UseSelectable = true;
            this.BezeichnungTextbox.CustomButton.Visible = false;
            this.BezeichnungTextbox.Lines = new string[0];
            this.BezeichnungTextbox.Location = new System.Drawing.Point(70, 118);
            this.BezeichnungTextbox.MaxLength = 32767;
            this.BezeichnungTextbox.Name = "BezeichnungTextbox";
            this.BezeichnungTextbox.PasswordChar = '\0';
            this.BezeichnungTextbox.PromptText = "Regalbezeichnung";
            this.BezeichnungTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BezeichnungTextbox.SelectedText = "";
            this.BezeichnungTextbox.SelectionLength = 0;
            this.BezeichnungTextbox.SelectionStart = 0;
            this.BezeichnungTextbox.ShortcutsEnabled = true;
            this.BezeichnungTextbox.Size = new System.Drawing.Size(175, 23);
            this.BezeichnungTextbox.TabIndex = 39;
            this.BezeichnungTextbox.UseSelectable = true;
            this.BezeichnungTextbox.WaterMark = "Regalbezeichnung";
            this.BezeichnungTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BezeichnungTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ZeilenTextbox
            // 
            // 
            // 
            // 
            this.ZeilenTextbox.CustomButton.Image = null;
            this.ZeilenTextbox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.ZeilenTextbox.CustomButton.Name = "";
            this.ZeilenTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ZeilenTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ZeilenTextbox.CustomButton.TabIndex = 1;
            this.ZeilenTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ZeilenTextbox.CustomButton.UseSelectable = true;
            this.ZeilenTextbox.CustomButton.Visible = false;
            this.ZeilenTextbox.Lines = new string[0];
            this.ZeilenTextbox.Location = new System.Drawing.Point(170, 144);
            this.ZeilenTextbox.MaxLength = 32767;
            this.ZeilenTextbox.Name = "ZeilenTextbox";
            this.ZeilenTextbox.PasswordChar = '\0';
            this.ZeilenTextbox.PromptText = "Zeilen";
            this.ZeilenTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ZeilenTextbox.SelectedText = "";
            this.ZeilenTextbox.SelectionLength = 0;
            this.ZeilenTextbox.SelectionStart = 0;
            this.ZeilenTextbox.ShortcutsEnabled = true;
            this.ZeilenTextbox.Size = new System.Drawing.Size(75, 23);
            this.ZeilenTextbox.TabIndex = 40;
            this.ZeilenTextbox.UseSelectable = true;
            this.ZeilenTextbox.WaterMark = "Zeilen";
            this.ZeilenTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ZeilenTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SpaltenTextbox
            // 
            // 
            // 
            // 
            this.SpaltenTextbox.CustomButton.Image = null;
            this.SpaltenTextbox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.SpaltenTextbox.CustomButton.Name = "";
            this.SpaltenTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SpaltenTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SpaltenTextbox.CustomButton.TabIndex = 1;
            this.SpaltenTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SpaltenTextbox.CustomButton.UseSelectable = true;
            this.SpaltenTextbox.CustomButton.Visible = false;
            this.SpaltenTextbox.Lines = new string[0];
            this.SpaltenTextbox.Location = new System.Drawing.Point(70, 144);
            this.SpaltenTextbox.MaxLength = 32767;
            this.SpaltenTextbox.Name = "SpaltenTextbox";
            this.SpaltenTextbox.PasswordChar = '\0';
            this.SpaltenTextbox.PromptText = "Spalten";
            this.SpaltenTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SpaltenTextbox.SelectedText = "";
            this.SpaltenTextbox.SelectionLength = 0;
            this.SpaltenTextbox.SelectionStart = 0;
            this.SpaltenTextbox.ShortcutsEnabled = true;
            this.SpaltenTextbox.Size = new System.Drawing.Size(75, 23);
            this.SpaltenTextbox.TabIndex = 41;
            this.SpaltenTextbox.UseSelectable = true;
            this.SpaltenTextbox.WaterMark = "Spalten";
            this.SpaltenTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SpaltenTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // HinzufuegenButton
            // 
            this.HinzufuegenButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.HinzufuegenButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.HinzufuegenButton.Location = new System.Drawing.Point(251, 185);
            this.HinzufuegenButton.Name = "HinzufuegenButton";
            this.HinzufuegenButton.Size = new System.Drawing.Size(226, 30);
            this.HinzufuegenButton.TabIndex = 42;
            this.HinzufuegenButton.Text = "Regal hinzufügen";
            this.HinzufuegenButton.UseSelectable = true;
            this.HinzufuegenButton.Click += new System.EventHandler(this.HinzufuegenButton_Click);
            // 
            // AbbrechenButton
            // 
            this.AbbrechenButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AbbrechenButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.AbbrechenButton.Location = new System.Drawing.Point(251, 222);
            this.AbbrechenButton.Name = "AbbrechenButton";
            this.AbbrechenButton.Size = new System.Drawing.Size(226, 30);
            this.AbbrechenButton.TabIndex = 43;
            this.AbbrechenButton.Text = "Abbrechen";
            this.AbbrechenButton.UseSelectable = true;
            this.AbbrechenButton.Click += new System.EventHandler(this.AbbrechenButton_Click);
            // 
            // RegalhoeheTextbox
            // 
            // 
            // 
            // 
            this.RegalhoeheTextbox.CustomButton.Image = null;
            this.RegalhoeheTextbox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.RegalhoeheTextbox.CustomButton.Name = "";
            this.RegalhoeheTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegalhoeheTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegalhoeheTextbox.CustomButton.TabIndex = 1;
            this.RegalhoeheTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegalhoeheTextbox.CustomButton.UseSelectable = true;
            this.RegalhoeheTextbox.CustomButton.Visible = false;
            this.RegalhoeheTextbox.Lines = new string[0];
            this.RegalhoeheTextbox.Location = new System.Drawing.Point(251, 86);
            this.RegalhoeheTextbox.MaxLength = 32767;
            this.RegalhoeheTextbox.Name = "RegalhoeheTextbox";
            this.RegalhoeheTextbox.PasswordChar = '\0';
            this.RegalhoeheTextbox.PromptText = "Regalhöhe (cm)";
            this.RegalhoeheTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegalhoeheTextbox.SelectedText = "";
            this.RegalhoeheTextbox.SelectionLength = 0;
            this.RegalhoeheTextbox.SelectionStart = 0;
            this.RegalhoeheTextbox.ShortcutsEnabled = true;
            this.RegalhoeheTextbox.Size = new System.Drawing.Size(100, 23);
            this.RegalhoeheTextbox.TabIndex = 44;
            this.RegalhoeheTextbox.UseSelectable = true;
            this.RegalhoeheTextbox.WaterMark = "Regalhöhe (cm)";
            this.RegalhoeheTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegalhoeheTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RegalbreiteTextbox
            // 
            // 
            // 
            // 
            this.RegalbreiteTextbox.CustomButton.Image = null;
            this.RegalbreiteTextbox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.RegalbreiteTextbox.CustomButton.Name = "";
            this.RegalbreiteTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegalbreiteTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegalbreiteTextbox.CustomButton.TabIndex = 1;
            this.RegalbreiteTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegalbreiteTextbox.CustomButton.UseSelectable = true;
            this.RegalbreiteTextbox.CustomButton.Visible = false;
            this.RegalbreiteTextbox.Lines = new string[0];
            this.RegalbreiteTextbox.Location = new System.Drawing.Point(251, 115);
            this.RegalbreiteTextbox.MaxLength = 32767;
            this.RegalbreiteTextbox.Name = "RegalbreiteTextbox";
            this.RegalbreiteTextbox.PasswordChar = '\0';
            this.RegalbreiteTextbox.PromptText = "Regalbreite (cm)";
            this.RegalbreiteTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegalbreiteTextbox.SelectedText = "";
            this.RegalbreiteTextbox.SelectionLength = 0;
            this.RegalbreiteTextbox.SelectionStart = 0;
            this.RegalbreiteTextbox.ShortcutsEnabled = true;
            this.RegalbreiteTextbox.Size = new System.Drawing.Size(100, 23);
            this.RegalbreiteTextbox.TabIndex = 45;
            this.RegalbreiteTextbox.UseSelectable = true;
            this.RegalbreiteTextbox.WaterMark = "Regalbreite (cm)";
            this.RegalbreiteTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegalbreiteTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RegallaengeTextbox
            // 
            // 
            // 
            // 
            this.RegallaengeTextbox.CustomButton.Image = null;
            this.RegallaengeTextbox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.RegallaengeTextbox.CustomButton.Name = "";
            this.RegallaengeTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegallaengeTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegallaengeTextbox.CustomButton.TabIndex = 1;
            this.RegallaengeTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegallaengeTextbox.CustomButton.UseSelectable = true;
            this.RegallaengeTextbox.CustomButton.Visible = false;
            this.RegallaengeTextbox.Lines = new string[0];
            this.RegallaengeTextbox.Location = new System.Drawing.Point(251, 144);
            this.RegallaengeTextbox.MaxLength = 32767;
            this.RegallaengeTextbox.Name = "RegallaengeTextbox";
            this.RegallaengeTextbox.PasswordChar = '\0';
            this.RegallaengeTextbox.PromptText = "Regallänge (cm)";
            this.RegallaengeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegallaengeTextbox.SelectedText = "";
            this.RegallaengeTextbox.SelectionLength = 0;
            this.RegallaengeTextbox.SelectionStart = 0;
            this.RegallaengeTextbox.ShortcutsEnabled = true;
            this.RegallaengeTextbox.Size = new System.Drawing.Size(100, 23);
            this.RegallaengeTextbox.TabIndex = 46;
            this.RegallaengeTextbox.UseSelectable = true;
            this.RegallaengeTextbox.WaterMark = "Regallänge (cm)";
            this.RegallaengeTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegallaengeTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FachhoeheTextbox
            // 
            // 
            // 
            // 
            this.FachhoeheTextbox.CustomButton.Image = null;
            this.FachhoeheTextbox.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.FachhoeheTextbox.CustomButton.Name = "";
            this.FachhoeheTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FachhoeheTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FachhoeheTextbox.CustomButton.TabIndex = 1;
            this.FachhoeheTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FachhoeheTextbox.CustomButton.UseSelectable = true;
            this.FachhoeheTextbox.CustomButton.Visible = false;
            this.FachhoeheTextbox.Lines = new string[0];
            this.FachhoeheTextbox.Location = new System.Drawing.Point(357, 86);
            this.FachhoeheTextbox.MaxLength = 32767;
            this.FachhoeheTextbox.Name = "FachhoeheTextbox";
            this.FachhoeheTextbox.PasswordChar = '\0';
            this.FachhoeheTextbox.PromptText = "Regalfachhöhe (cm)";
            this.FachhoeheTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FachhoeheTextbox.SelectedText = "";
            this.FachhoeheTextbox.SelectionLength = 0;
            this.FachhoeheTextbox.SelectionStart = 0;
            this.FachhoeheTextbox.ShortcutsEnabled = true;
            this.FachhoeheTextbox.Size = new System.Drawing.Size(120, 23);
            this.FachhoeheTextbox.TabIndex = 47;
            this.FachhoeheTextbox.UseSelectable = true;
            this.FachhoeheTextbox.WaterMark = "Regalfachhöhe (cm)";
            this.FachhoeheTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FachhoeheTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FachbreiteTextbox
            // 
            // 
            // 
            // 
            this.FachbreiteTextbox.CustomButton.Image = null;
            this.FachbreiteTextbox.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.FachbreiteTextbox.CustomButton.Name = "";
            this.FachbreiteTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FachbreiteTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FachbreiteTextbox.CustomButton.TabIndex = 1;
            this.FachbreiteTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FachbreiteTextbox.CustomButton.UseSelectable = true;
            this.FachbreiteTextbox.CustomButton.Visible = false;
            this.FachbreiteTextbox.Lines = new string[0];
            this.FachbreiteTextbox.Location = new System.Drawing.Point(357, 115);
            this.FachbreiteTextbox.MaxLength = 32767;
            this.FachbreiteTextbox.Name = "FachbreiteTextbox";
            this.FachbreiteTextbox.PasswordChar = '\0';
            this.FachbreiteTextbox.PromptText = "Regalfachbreite (cm)";
            this.FachbreiteTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FachbreiteTextbox.SelectedText = "";
            this.FachbreiteTextbox.SelectionLength = 0;
            this.FachbreiteTextbox.SelectionStart = 0;
            this.FachbreiteTextbox.ShortcutsEnabled = true;
            this.FachbreiteTextbox.Size = new System.Drawing.Size(120, 23);
            this.FachbreiteTextbox.TabIndex = 48;
            this.FachbreiteTextbox.UseSelectable = true;
            this.FachbreiteTextbox.WaterMark = "Regalfachbreite (cm)";
            this.FachbreiteTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FachbreiteTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FachlaengeTextbox
            // 
            // 
            // 
            // 
            this.FachlaengeTextbox.CustomButton.Image = null;
            this.FachlaengeTextbox.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.FachlaengeTextbox.CustomButton.Name = "";
            this.FachlaengeTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FachlaengeTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FachlaengeTextbox.CustomButton.TabIndex = 1;
            this.FachlaengeTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FachlaengeTextbox.CustomButton.UseSelectable = true;
            this.FachlaengeTextbox.CustomButton.Visible = false;
            this.FachlaengeTextbox.Lines = new string[0];
            this.FachlaengeTextbox.Location = new System.Drawing.Point(357, 144);
            this.FachlaengeTextbox.MaxLength = 32767;
            this.FachlaengeTextbox.Name = "FachlaengeTextbox";
            this.FachlaengeTextbox.PasswordChar = '\0';
            this.FachlaengeTextbox.PromptText = "Regalfachlänge (cm)";
            this.FachlaengeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FachlaengeTextbox.SelectedText = "";
            this.FachlaengeTextbox.SelectionLength = 0;
            this.FachlaengeTextbox.SelectionStart = 0;
            this.FachlaengeTextbox.ShortcutsEnabled = true;
            this.FachlaengeTextbox.Size = new System.Drawing.Size(120, 23);
            this.FachlaengeTextbox.TabIndex = 49;
            this.FachlaengeTextbox.UseSelectable = true;
            this.FachlaengeTextbox.WaterMark = "Regalfachlänge (cm)";
            this.FachlaengeTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FachlaengeTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // RegalHinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.FachlaengeTextbox);
            this.Controls.Add(this.FachbreiteTextbox);
            this.Controls.Add(this.FachhoeheTextbox);
            this.Controls.Add(this.RegallaengeTextbox);
            this.Controls.Add(this.RegalbreiteTextbox);
            this.Controls.Add(this.RegalhoeheTextbox);
            this.Controls.Add(this.AbbrechenButton);
            this.Controls.Add(this.HinzufuegenButton);
            this.Controls.Add(this.SpaltenTextbox);
            this.Controls.Add(this.ZeilenTextbox);
            this.Controls.Add(this.BezeichnungTextbox);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.LagerCombobox);
            this.Controls.Add(this.LagerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegalHinzufuegen";
            this.Resizable = false;
            this.Text = "Regal hinzufügen";
            this.Load += new System.EventHandler(this.RegalHinzufuegen_Load);
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LagerLabel;
        private MetroFramework.Controls.MetroComboBox LagerCombobox;
        private System.Windows.Forms.GroupBox GroupBox;
        private MetroFramework.Controls.MetroTextBox BezeichnungTextbox;
        private MetroFramework.Controls.MetroTextBox ZeilenTextbox;
        private MetroFramework.Controls.MetroTextBox SpaltenTextbox;
        private MetroFramework.Controls.MetroButton HinzufuegenButton;
        private MetroFramework.Controls.MetroButton AbbrechenButton;
        private MetroFramework.Controls.MetroTextBox StaerkeV;
        private MetroFramework.Controls.MetroTextBox StaerkeH;
        private MetroFramework.Controls.MetroTextBox RegalhoeheTextbox;
        private MetroFramework.Controls.MetroTextBox RegalbreiteTextbox;
        private MetroFramework.Controls.MetroTextBox RegallaengeTextbox;
        private MetroFramework.Controls.MetroTextBox FachhoeheTextbox;
        private MetroFramework.Controls.MetroTextBox FachbreiteTextbox;
        private MetroFramework.Controls.MetroTextBox FachlaengeTextbox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}