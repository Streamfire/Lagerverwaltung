using Lagerverwaltung.Core;
using Opulos.Core.UI;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Verwaltung
	{
		/// <summary>
		/// verarbeitet die Lageliste aus dem Dash und erstellt dynamisch Tabpages, Akkordions und zusatinfo Panele
		/// </summary>
		/// <param name="lagerListe">die Lagerliste, übergeben vom Dashboard</param>
		public void UpdateForm(List<Lager> lagerListe)
		{
			foreach (Lager l in lagerListe)
			{
				TabPage tp = new TabPage(l.Name);
				Accordion lagerAccordion= new Accordion();
			
				tp.Controls.Add(lagerAccordion);

				tabControl1.TabPages.Add(tp);
				foreach (Regal r in l.Regalliste)
				{
					Accordion nestedRegal = new Accordion();
					lagerAccordion.Add(nestedRegal,r.Name);

					foreach (Regalfach f in r.Regalfachliste)
					{
						Accordion nestedFach = new Accordion();
						Panel infoPanel = new Panel();
						Label name = new Label();
                        if(f.Paketliste.Count>0)
                        {
                            //im Fach ist ein Paketregistriert-> die restlichen Infos zum Paket anzeigen
                            name.Text = "Inhalt: "+ f.Paketliste[0].Produkt.Name;

                            Label Menge = new Label();
							Label Breite = new Label();
							Label Hoehe = new Label();
							Label Laenge = new Label();
							Label Haltbarkeit = new Label();
							Label Erstellt = new Label();
							Label Geaendert = new Label();
							Label Anschaffungsgrund = new Label();

							Menge.Left = 100;
                            Menge.Text ="Menge: "+ f.Paketliste.Count;

							Breite.Left = 200;
							Breite.Text = "Breite: " + f.Paketliste[0].Produkt.Breite;

							Hoehe.Left = 300;
							Hoehe.Text = "Höhe: " + f.Paketliste[0].Produkt.Hoehe;

							Laenge.Left = 400;
							Laenge.Text = "Länge: " + f.Paketliste[0].Produkt.Laenge;

							Haltbarkeit.Left = 500;
							Haltbarkeit.Text = "Haltbarkeit: " + f.Paketliste[0].Haltbarkeit;

							Erstellt.Left = 600;
							Erstellt.Text = "Erstellt: " + f.Paketliste[0].ErstelltAm;

							Geaendert.Left = 700;
							Geaendert.Text = "Geaendert: " + f.Paketliste[0].GeaendertAm;

							Anschaffungsgrund.Top = 25;
							Anschaffungsgrund.Text = "Anschaffungsgrund: " + f.Paketliste[0].Anschaffungsgrund;
							Anschaffungsgrund.Width = Anschaffungsgrund.Width + 400;

							infoPanel.Controls.Add(name);
                            infoPanel.Controls.Add(Menge);
							infoPanel.Controls.Add(Breite);
							infoPanel.Controls.Add(Hoehe);
							infoPanel.Controls.Add(Laenge);
							infoPanel.Controls.Add(Haltbarkeit);
							infoPanel.Controls.Add(Erstellt);
							infoPanel.Controls.Add(Geaendert);
							infoPanel.Controls.Add(Anschaffungsgrund);



							nestedRegal.Add(nestedFach, f.Paketliste[0].PaketBezeichnung+ " | "+f.Paketliste[0].Produkt.Name);
						}
                        else
                        {
                            name.Text = "Leer";
                            infoPanel.Controls.Add(name);


							nestedRegal.Add(nestedFach, f.Name);
						}
						

						nestedFach.Controls.Add(infoPanel);


						
					}

				}
			}
		}


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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonPaketHinzufuegen = new System.Windows.Forms.Button();
            this.buttonPaketEntfernen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(-2, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // buttonPaketHinzufuegen
            // 
            this.buttonPaketHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaketHinzufuegen.Location = new System.Drawing.Point(2, 1);
            this.buttonPaketHinzufuegen.Name = "buttonPaketHinzufuegen";
            this.buttonPaketHinzufuegen.Size = new System.Drawing.Size(110, 46);
            this.buttonPaketHinzufuegen.TabIndex = 1;
            this.buttonPaketHinzufuegen.Text = "Paket Hinzufügen";
            this.buttonPaketHinzufuegen.UseVisualStyleBackColor = true;
            // 
            // buttonPaketEntfernen
            // 
            this.buttonPaketEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaketEntfernen.Location = new System.Drawing.Point(118, 1);
            this.buttonPaketEntfernen.Name = "buttonPaketEntfernen";
            this.buttonPaketEntfernen.Size = new System.Drawing.Size(113, 46);
            this.buttonPaketEntfernen.TabIndex = 2;
            this.buttonPaketEntfernen.Text = "Paket entfernen";
            this.buttonPaketEntfernen.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1006, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Lager Entfernen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(887, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Lager Hinzufügen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(768, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "Lagerung Optimieren";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(237, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Paket umlagern";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(426, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 46);
            this.button7.TabIndex = 8;
            this.button7.Text = "Regal Hinzufügen";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(545, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 46);
            this.button8.TabIndex = 7;
            this.button8.Text = "Regal Entfernen";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 602);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonPaketEntfernen);
            this.Controls.Add(this.buttonPaketHinzufuegen);
            this.Controls.Add(this.tabControl1);
            this.Name = "Verwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerwaltungFormClosing);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button buttonPaketHinzufuegen;
		private System.Windows.Forms.Button buttonPaketEntfernen;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
	}
}