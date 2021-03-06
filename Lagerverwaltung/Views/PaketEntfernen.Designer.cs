﻿namespace Lagerverwaltung.Views
{
    partial class PaketEntfernen
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
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxPaketEntfernen = new System.Windows.Forms.ComboBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.LabelProdukt = new MetroFramework.Controls.MetroLabel();
            this.LabelMenge = new MetroFramework.Controls.MetroLabel();
            this.ButtonAuslagern = new MetroFramework.Controls.MetroButton();
            this.ButtonAbbrechen = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paket:";
            // 
            // ComboBoxPaketEntfernen
            // 
            this.ComboBoxPaketEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPaketEntfernen.FormattingEnabled = true;
            this.ComboBoxPaketEntfernen.Location = new System.Drawing.Point(92, 85);
            this.ComboBoxPaketEntfernen.Name = "ComboBoxPaketEntfernen";
            this.ComboBoxPaketEntfernen.Size = new System.Drawing.Size(198, 26);
            this.ComboBoxPaketEntfernen.TabIndex = 2;
            this.ComboBoxPaketEntfernen.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPaketEntfernen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produkt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label4.Location = new System.Drawing.Point(23, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Menge:";
            // 
            // LabelProdukt
            // 
            this.LabelProdukt.AutoSize = true;
            this.LabelProdukt.Location = new System.Drawing.Point(92, 136);
            this.LabelProdukt.Name = "LabelProdukt";
            this.LabelProdukt.Size = new System.Drawing.Size(63, 19);
            this.LabelProdukt.TabIndex = 7;
            this.LabelProdukt.Text = "[Produkt]";
            // 
            // LabelMenge
            // 
            this.LabelMenge.AutoSize = true;
            this.LabelMenge.Location = new System.Drawing.Point(92, 182);
            this.LabelMenge.Name = "LabelMenge";
            this.LabelMenge.Size = new System.Drawing.Size(58, 19);
            this.LabelMenge.TabIndex = 8;
            this.LabelMenge.Text = "[Menge]";
            // 
            // ButtonAuslagern
            // 
            this.ButtonAuslagern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAuslagern.Location = new System.Drawing.Point(92, 234);
            this.ButtonAuslagern.Name = "ButtonAuslagern";
            this.ButtonAuslagern.Size = new System.Drawing.Size(85, 30);
            this.ButtonAuslagern.TabIndex = 9;
            this.ButtonAuslagern.Text = "Auslagern";
            this.ButtonAuslagern.UseSelectable = true;
            this.ButtonAuslagern.Click += new System.EventHandler(this.ButtonAuslagern_Click);
            // 
            // ButtonAbbrechen
            // 
            this.ButtonAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAbbrechen.Location = new System.Drawing.Point(211, 234);
            this.ButtonAbbrechen.Name = "ButtonAbbrechen";
            this.ButtonAbbrechen.Size = new System.Drawing.Size(85, 30);
            this.ButtonAbbrechen.TabIndex = 10;
            this.ButtonAbbrechen.Text = "Abbrechen";
            this.ButtonAbbrechen.UseSelectable = true;
            this.ButtonAbbrechen.Click += new System.EventHandler(this.ButtonAbbrechen_Click);
            // 
            // PaketEntfernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 287);
            this.Controls.Add(this.ButtonAbbrechen);
            this.Controls.Add(this.ButtonAuslagern);
            this.Controls.Add(this.LabelMenge);
            this.Controls.Add(this.LabelProdukt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxPaketEntfernen);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "PaketEntfernen";
            this.Resizable = false;
            this.Text = "Paket auslagern";
            this.Load += new System.EventHandler(this.PaketEntfernen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label2;
        private System.Windows.Forms.ComboBox ComboBoxPaketEntfernen;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel LabelProdukt;
        private MetroFramework.Controls.MetroLabel LabelMenge;
        private MetroFramework.Controls.MetroButton ButtonAuslagern;
        private MetroFramework.Controls.MetroButton ButtonAbbrechen;
    }
}