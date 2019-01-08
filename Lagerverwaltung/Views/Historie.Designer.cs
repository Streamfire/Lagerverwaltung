namespace Lagerverwaltung.Views
{
    partial class Historie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LadeDatenLabel = new MetroFramework.Controls.MetroLabel();
            this.CustomCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.AktualisierenButton = new MetroFramework.Controls.MetroButton();
            this.LademehrButton = new MetroFramework.Controls.MetroButton();
            this.SucheTextBox = new MetroFramework.Controls.MetroTextBox();
            this.HistorieGrid = new MetroFramework.Controls.MetroGrid();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.PanelHelper = new System.Windows.Forms.Panel();
            this.LadeDatenProgressspinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SchließenButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.HistorieGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.PanelHelper.SuspendLayout();
            this.SuspendLayout();
            // 
            // LadeDatenLabel
            // 
            this.LadeDatenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadeDatenLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LadeDatenLabel.Location = new System.Drawing.Point(0, 0);
            this.LadeDatenLabel.Name = "LadeDatenLabel";
            this.LadeDatenLabel.Size = new System.Drawing.Size(656, 289);
            this.LadeDatenLabel.TabIndex = 6;
            this.LadeDatenLabel.Text = "Lade Daten...";
            this.LadeDatenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LadeDatenLabel.UseCustomBackColor = true;
            // 
            // CustomCheckbox
            // 
            this.CustomCheckbox.AutoSize = true;
            this.CustomCheckbox.Location = new System.Drawing.Point(23, 92);
            this.CustomCheckbox.Name = "CustomCheckbox";
            this.CustomCheckbox.Size = new System.Drawing.Size(103, 15);
            this.CustomCheckbox.TabIndex = 8;
            this.CustomCheckbox.Text = "Zeige nur mich";
            this.CustomCheckbox.UseSelectable = true;
            this.CustomCheckbox.CheckedChanged += new System.EventHandler(this.CustomCheckbox_CheckedChanged);
            // 
            // AktualisierenButton
            // 
            this.AktualisierenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AktualisierenButton.Enabled = false;
            this.AktualisierenButton.Location = new System.Drawing.Point(497, 92);
            this.AktualisierenButton.Name = "AktualisierenButton";
            this.AktualisierenButton.Size = new System.Drawing.Size(75, 23);
            this.AktualisierenButton.TabIndex = 9;
            this.AktualisierenButton.Text = "Aktualisieren";
            this.AktualisierenButton.UseSelectable = true;
            this.AktualisierenButton.Click += new System.EventHandler(this.AktualisierenButton_Click);
            // 
            // LademehrButton
            // 
            this.LademehrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LademehrButton.Enabled = false;
            this.LademehrButton.Location = new System.Drawing.Point(578, 92);
            this.LademehrButton.Name = "LademehrButton";
            this.LademehrButton.Size = new System.Drawing.Size(100, 23);
            this.LademehrButton.TabIndex = 10;
            this.LademehrButton.Text = "Lade mehr Daten";
            this.LademehrButton.UseSelectable = true;
            this.LademehrButton.Click += new System.EventHandler(this.LademehrButton_Click);
            // 
            // SucheTextBox
            // 
            // 
            // 
            // 
            this.SucheTextBox.CustomButton.Image = null;
            this.SucheTextBox.CustomButton.Location = new System.Drawing.Point(633, 1);
            this.SucheTextBox.CustomButton.Name = "";
            this.SucheTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SucheTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SucheTextBox.CustomButton.TabIndex = 1;
            this.SucheTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SucheTextBox.CustomButton.UseSelectable = true;
            this.SucheTextBox.CustomButton.Visible = false;
            this.SucheTextBox.Lines = new string[0];
            this.SucheTextBox.Location = new System.Drawing.Point(23, 63);
            this.SucheTextBox.MaxLength = 32767;
            this.SucheTextBox.Name = "SucheTextBox";
            this.SucheTextBox.PasswordChar = '\0';
            this.SucheTextBox.PromptText = "Suche";
            this.SucheTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SucheTextBox.SelectedText = "";
            this.SucheTextBox.SelectionLength = 0;
            this.SucheTextBox.SelectionStart = 0;
            this.SucheTextBox.ShortcutsEnabled = true;
            this.SucheTextBox.Size = new System.Drawing.Size(655, 23);
            this.SucheTextBox.TabIndex = 11;
            this.SucheTextBox.UseSelectable = true;
            this.SucheTextBox.WaterMark = "Suche";
            this.SucheTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SucheTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // HistorieGrid
            // 
            this.HistorieGrid.AllowUserToAddRows = false;
            this.HistorieGrid.AllowUserToDeleteRows = false;
            this.HistorieGrid.AllowUserToOrderColumns = true;
            this.HistorieGrid.AllowUserToResizeRows = false;
            this.HistorieGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistorieGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.HistorieGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HistorieGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HistorieGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistorieGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.HistorieGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistorieGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HistorieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HistorieGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.HistorieGrid.EnableHeadersVisualStyles = false;
            this.HistorieGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HistorieGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HistorieGrid.Location = new System.Drawing.Point(23, 121);
            this.HistorieGrid.Name = "HistorieGrid";
            this.HistorieGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistorieGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.HistorieGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.HistorieGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.HistorieGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistorieGrid.Size = new System.Drawing.Size(654, 289);
            this.HistorieGrid.TabIndex = 12;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // PanelHelper
            // 
            this.PanelHelper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHelper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelHelper.Controls.Add(this.LadeDatenProgressspinner);
            this.PanelHelper.Controls.Add(this.LadeDatenLabel);
            this.PanelHelper.Location = new System.Drawing.Point(23, 121);
            this.PanelHelper.Name = "PanelHelper";
            this.PanelHelper.Size = new System.Drawing.Size(655, 289);
            this.PanelHelper.TabIndex = 13;
            // 
            // LadeDatenProgressspinner
            // 
            this.LadeDatenProgressspinner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LadeDatenProgressspinner.Location = new System.Drawing.Point(303, 87);
            this.LadeDatenProgressspinner.Maximum = 100;
            this.LadeDatenProgressspinner.Name = "LadeDatenProgressspinner";
            this.LadeDatenProgressspinner.Size = new System.Drawing.Size(43, 47);
            this.LadeDatenProgressspinner.TabIndex = 7;
            this.LadeDatenProgressspinner.UseCustomBackColor = true;
            this.LadeDatenProgressspinner.UseSelectable = true;
            // 
            // SchließenButton
            // 
            this.SchließenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SchließenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SchließenButton.Location = new System.Drawing.Point(602, 416);
            this.SchließenButton.Name = "SchließenButton";
            this.SchließenButton.Size = new System.Drawing.Size(75, 23);
            this.SchließenButton.TabIndex = 14;
            this.SchließenButton.Text = "Schließen";
            this.SchließenButton.UseSelectable = true;
            this.SchließenButton.Click += new System.EventHandler(this.SchließenButton_Click);
            // 
            // Historie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.PanelHelper);
            this.Controls.Add(this.SchließenButton);
            this.Controls.Add(this.SucheTextBox);
            this.Controls.Add(this.LademehrButton);
            this.Controls.Add(this.AktualisierenButton);
            this.Controls.Add(this.CustomCheckbox);
            this.Controls.Add(this.HistorieGrid);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Historie";
            this.Text = "Historie";
            ((System.ComponentModel.ISupportInitialize)(this.HistorieGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.PanelHelper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LadeDatenLabel;
        private MetroFramework.Controls.MetroCheckBox CustomCheckbox;
        private MetroFramework.Controls.MetroButton AktualisierenButton;
        private MetroFramework.Controls.MetroButton LademehrButton;
        private MetroFramework.Controls.MetroTextBox SucheTextBox;
        private MetroFramework.Controls.MetroGrid HistorieGrid;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Panel PanelHelper;
        private MetroFramework.Controls.MetroProgressSpinner LadeDatenProgressspinner;
        private MetroFramework.Controls.MetroButton SchließenButton;
    }
}