namespace Lagerverwaltung.Views
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxPaketEntfernen = new System.Windows.Forms.ComboBox();
            this.ButtonAuslagern = new System.Windows.Forms.Button();
            this.ButtonAbbrechen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelProdukt = new System.Windows.Forms.Label();
            this.LabelMenge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paket auslagern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paket:";
            // 
            // ComboBoxPaketEntfernen
            // 
            this.ComboBoxPaketEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPaketEntfernen.FormattingEnabled = true;
            this.ComboBoxPaketEntfernen.Location = new System.Drawing.Point(116, 85);
            this.ComboBoxPaketEntfernen.Name = "ComboBoxPaketEntfernen";
            this.ComboBoxPaketEntfernen.Size = new System.Drawing.Size(198, 26);
            this.ComboBoxPaketEntfernen.TabIndex = 2;
            this.ComboBoxPaketEntfernen.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPaketEntfernen_SelectedIndexChanged);
            // 
            // ButtonAuslagern
            // 
            this.ButtonAuslagern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAuslagern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAuslagern.Location = new System.Drawing.Point(97, 289);
            this.ButtonAuslagern.Name = "ButtonAuslagern";
            this.ButtonAuslagern.Size = new System.Drawing.Size(97, 35);
            this.ButtonAuslagern.TabIndex = 3;
            this.ButtonAuslagern.Text = "Auslagern";
            this.ButtonAuslagern.UseVisualStyleBackColor = true;
            this.ButtonAuslagern.Click += new System.EventHandler(this.ButtonAuslagern_Click);
            // 
            // ButtonAbbrechen
            // 
            this.ButtonAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAbbrechen.Location = new System.Drawing.Point(224, 289);
            this.ButtonAbbrechen.Name = "ButtonAbbrechen";
            this.ButtonAbbrechen.Size = new System.Drawing.Size(97, 35);
            this.ButtonAbbrechen.TabIndex = 4;
            this.ButtonAbbrechen.Text = "Abbrechen";
            this.ButtonAbbrechen.UseVisualStyleBackColor = true;
            this.ButtonAbbrechen.Click += new System.EventHandler(this.ButtonAbbrechen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produkt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Menge:";
            // 
            // LabelProdukt
            // 
            this.LabelProdukt.AutoSize = true;
            this.LabelProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProdukt.Location = new System.Drawing.Point(113, 145);
            this.LabelProdukt.Name = "LabelProdukt";
            this.LabelProdukt.Size = new System.Drawing.Size(68, 18);
            this.LabelProdukt.TabIndex = 7;
            this.LabelProdukt.Text = "[Produkt]";
            // 
            // LabelMenge
            // 
            this.LabelMenge.AutoSize = true;
            this.LabelMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMenge.Location = new System.Drawing.Point(113, 201);
            this.LabelMenge.Name = "LabelMenge";
            this.LabelMenge.Size = new System.Drawing.Size(61, 18);
            this.LabelMenge.TabIndex = 8;
            this.LabelMenge.Text = "[Menge]";
            // 
            // PaketEntfernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 340);
            this.Controls.Add(this.LabelMenge);
            this.Controls.Add(this.LabelProdukt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonAbbrechen);
            this.Controls.Add(this.ButtonAuslagern);
            this.Controls.Add(this.ComboBoxPaketEntfernen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaketEntfernen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaketEntfernen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxPaketEntfernen;
        private System.Windows.Forms.Button ButtonAuslagern;
        private System.Windows.Forms.Button ButtonAbbrechen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelProdukt;
        private System.Windows.Forms.Label LabelMenge;
    }
}