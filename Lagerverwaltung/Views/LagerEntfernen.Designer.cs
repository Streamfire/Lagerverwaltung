namespace Lagerverwaltung.Views
{
    partial class LagerEntfernen
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
            this.HinzufuegenButton = new MetroFramework.Controls.MetroButton();
            this.AbbrechenButton = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LagerLabel
            // 
            this.LagerLabel.AutoSize = true;
            this.LagerLabel.Location = new System.Drawing.Point(23, 82);
            this.LagerLabel.Name = "LagerLabel";
            this.LagerLabel.Size = new System.Drawing.Size(104, 19);
            this.LagerLabel.TabIndex = 0;
            this.LagerLabel.Text = "Lager entfernen:";
            // 
            // LagerCombobox
            // 
            this.LagerCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LagerCombobox.FormattingEnabled = true;
            this.LagerCombobox.ItemHeight = 23;
            this.LagerCombobox.Location = new System.Drawing.Point(133, 82);
            this.LagerCombobox.Name = "LagerCombobox";
            this.LagerCombobox.Size = new System.Drawing.Size(201, 29);
            this.LagerCombobox.TabIndex = 1;
            this.LagerCombobox.UseSelectable = true;
            // 
            // HinzufuegenButton
            // 
            this.HinzufuegenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HinzufuegenButton.Location = new System.Drawing.Point(178, 144);
            this.HinzufuegenButton.Name = "HinzufuegenButton";
            this.HinzufuegenButton.Size = new System.Drawing.Size(75, 23);
            this.HinzufuegenButton.TabIndex = 2;
            this.HinzufuegenButton.Text = "Entfernen";
            this.HinzufuegenButton.UseSelectable = true;
            this.HinzufuegenButton.Click += new System.EventHandler(this.HinzufuegenButton_Click);
            // 
            // AbbrechenButton
            // 
            this.AbbrechenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbbrechenButton.Location = new System.Drawing.Point(259, 144);
            this.AbbrechenButton.Name = "AbbrechenButton";
            this.AbbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.AbbrechenButton.TabIndex = 3;
            this.AbbrechenButton.Text = "Abbrechen";
            this.AbbrechenButton.UseSelectable = true;
            this.AbbrechenButton.Click += new System.EventHandler(this.AbbrechenButton_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // LagerEntfernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 190);
            this.Controls.Add(this.AbbrechenButton);
            this.Controls.Add(this.HinzufuegenButton);
            this.Controls.Add(this.LagerCombobox);
            this.Controls.Add(this.LagerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LagerEntfernen";
            this.Resizable = false;
            this.Text = "Lager entfernen";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LagerLabel;
        private MetroFramework.Controls.MetroComboBox LagerCombobox;
        private MetroFramework.Controls.MetroButton HinzufuegenButton;
        private MetroFramework.Controls.MetroButton AbbrechenButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}