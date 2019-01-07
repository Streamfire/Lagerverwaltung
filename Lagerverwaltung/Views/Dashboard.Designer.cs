namespace Lagerverwaltung.Views
{
    partial class Dashboard
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutzerHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerwaltungKachel = new MetroFramework.Controls.MetroTile();
            this.SucheKachel = new MetroFramework.Controls.MetroTile();
            this.RegaleinsichtKachel = new MetroFramework.Controls.MetroTile();
            this.HistorieKachel = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lagertypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regaltypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(20, 60);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(410, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lagertypToolStripMenuItem,
            this.regaltypToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nutzerHinzufügenToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // nutzerHinzufügenToolStripMenuItem
            // 
            this.nutzerHinzufügenToolStripMenuItem.Name = "nutzerHinzufügenToolStripMenuItem";
            this.nutzerHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nutzerHinzufügenToolStripMenuItem.Text = "Nutzer hinzufügen";
            this.nutzerHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.NutzerHinzufügenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // VerwaltungKachel
            // 
            this.VerwaltungKachel.ActiveControl = null;
            this.VerwaltungKachel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerwaltungKachel.Location = new System.Drawing.Point(20, 87);
            this.VerwaltungKachel.Name = "VerwaltungKachel";
            this.VerwaltungKachel.Size = new System.Drawing.Size(200, 150);
            this.VerwaltungKachel.TabIndex = 5;
            this.VerwaltungKachel.Text = "Verwaltung";
            this.VerwaltungKachel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VerwaltungKachel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.VerwaltungKachel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.VerwaltungKachel.UseSelectable = true;
            this.VerwaltungKachel.Click += new System.EventHandler(this.VerwaltungKachel_Click);
            // 
            // SucheKachel
            // 
            this.SucheKachel.ActiveControl = null;
            this.SucheKachel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SucheKachel.Location = new System.Drawing.Point(230, 87);
            this.SucheKachel.Name = "SucheKachel";
            this.SucheKachel.Size = new System.Drawing.Size(200, 150);
            this.SucheKachel.TabIndex = 6;
            this.SucheKachel.Text = "Suche";
            this.SucheKachel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SucheKachel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SucheKachel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SucheKachel.UseSelectable = true;
            this.SucheKachel.Click += new System.EventHandler(this.SucheKachel_Click);
            // 
            // RegaleinsichtKachel
            // 
            this.RegaleinsichtKachel.ActiveControl = null;
            this.RegaleinsichtKachel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegaleinsichtKachel.Location = new System.Drawing.Point(20, 243);
            this.RegaleinsichtKachel.Name = "RegaleinsichtKachel";
            this.RegaleinsichtKachel.Size = new System.Drawing.Size(200, 150);
            this.RegaleinsichtKachel.TabIndex = 7;
            this.RegaleinsichtKachel.Text = "Regaleinsicht";
            this.RegaleinsichtKachel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegaleinsichtKachel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.RegaleinsichtKachel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.RegaleinsichtKachel.UseSelectable = true;
            this.RegaleinsichtKachel.Click += new System.EventHandler(this.RegaleinsichtKachel_Click);
            // 
            // HistorieKachel
            // 
            this.HistorieKachel.ActiveControl = null;
            this.HistorieKachel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistorieKachel.Location = new System.Drawing.Point(230, 243);
            this.HistorieKachel.Name = "HistorieKachel";
            this.HistorieKachel.Size = new System.Drawing.Size(200, 150);
            this.HistorieKachel.TabIndex = 8;
            this.HistorieKachel.Text = "Historie";
            this.HistorieKachel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HistorieKachel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.HistorieKachel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.HistorieKachel.UseSelectable = true;
            this.HistorieKachel.Click += new System.EventHandler(this.HistorieKachel_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // lagertypToolStripMenuItem
            // 
            this.lagertypToolStripMenuItem.Name = "lagertypToolStripMenuItem";
            this.lagertypToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lagertypToolStripMenuItem.Text = "Lagertyp";
            // 
            // regaltypToolStripMenuItem
            // 
            this.regaltypToolStripMenuItem.Name = "regaltypToolStripMenuItem";
            this.regaltypToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regaltypToolStripMenuItem.Text = "Regaltyp";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.HistorieKachel);
            this.Controls.Add(this.RegaleinsichtKachel);
            this.Controls.Add(this.SucheKachel);
            this.Controls.Add(this.VerwaltungKachel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutzerHinzufügenToolStripMenuItem;
        private MetroFramework.Controls.MetroTile VerwaltungKachel;
        private MetroFramework.Controls.MetroTile SucheKachel;
        private MetroFramework.Controls.MetroTile RegaleinsichtKachel;
        private MetroFramework.Controls.MetroTile HistorieKachel;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ToolStripMenuItem lagertypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regaltypToolStripMenuItem;
    }
}