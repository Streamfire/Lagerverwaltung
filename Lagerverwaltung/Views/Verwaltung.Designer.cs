using Lagerverwaltung.Model;
using Opulos.Core.UI;
using System;
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
		public void UpdateForm(IReadOnlyDictionary<ushort,Model.Lager> lagerListe)
		{
			//Reset Form
			tabControl1.Controls.Clear();
			tabControl1.SelectedIndexChanged += OnChangedTab;

			foreach (Lager l in lagerListe.Values)
			{
				TabPage tp = new TabPage(l.Name);
			
				_lagerAccordion = new Accordion();
				_lagerAccordion.GotFocus += OnFocusedPanel;

				tp.Controls.Add(_lagerAccordion);

				tabControl1.TabPages.Add(tp);
				foreach (Regal r in l.Regalliste)
				{
					Accordion nestedRegal = new Accordion();
					nestedRegal.Name = r.Name;
					nestedRegal.GotFocus += OnFocusedPanel;
					_lagerAccordion.Add(nestedRegal, r.Name);

					foreach (Regalfach f in r.Regalfachliste)
					{
						Accordion nestedFach = new Accordion();
						nestedFach.GotFocus += OnFocusedPanel;
						nestedFach.Name = f.Name;

						Panel infoPanel = new Panel();
						Label name = new Label();
						if (f.Paketliste.Count > 0)
						{
							//im Fach ist ein Paketregistriert-> die restlichen Infos zum Paket anzeigen
							name.Text = "Inhalt: " + f.Paketliste[0].ProduktID;

							Label Menge = new Label();
							Label Breite = new Label();
							Label Hoehe = new Label();
							Label Laenge = new Label();
							Label Haltbarkeit = new Label();
							Label Erstellt = new Label();
							Label Geaendert = new Label();
							Label Anschaffungsgrund = new Label();

							Menge.Left = 100;
							Menge.Text = "Menge: " + f.Paketliste.Count;

							Breite.Left = 200;
							Breite.Text = "Breite: " + f.Paketliste[0].ProduktID;

							Hoehe.Left = 300;
							Hoehe.Text = "Höhe: " + f.Paketliste[0].ProduktID;

							Laenge.Left = 400;
							Laenge.Text = "Länge: " + f.Paketliste[0].ProduktID;

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

							nestedRegal.Add(nestedFach, f.Paketliste[0].Name + " | " + f.Paketliste[0].ProduktID);
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


			_lastFocusedAccordion = _lagerAccordion;
			_lastFocusedPage = tabControl1.TabPages[0];
		}
		 
		private void OnFocusedPanel(Object sender, EventArgs e)
		{
			_lastFocusedAccordion = (Accordion) sender;
            Dashboard.CurrentRegal = _lastFocusedAccordion.Name;
		}

		private void OnChangedTab(Object sender, EventArgs e)
		{
          if(((TabControl)sender).SelectedIndex!=-1)
			{
				_lastFocusedPage = ((TabControl)sender).TabPages[((TabControl)sender).SelectedIndex];
				Dashboard.CurrentLager = ((TabControl)sender).TabPages[((TabControl)sender).SelectedIndex].Text;
			}
			else if (((TabControl)sender).TabPages.Count>0)
			{
				_lastFocusedPage = ((TabControl)sender).TabPages[0];
				Dashboard.CurrentLager = ((TabControl)sender).TabPages[0].Text;
			}
			else
			{

			}
			
        }

		public Accordion getLastFocusedPanel()
		{
			return _lastFocusedAccordion;
		}

		public TabPage getLastFocusedPage()
		{
			return _lastFocusedPage;
		}

		//Don't use
		//NullPointerException bei Aufruf -> Lukas bitte fixen!
		public int getActiveTabIndex()
		{
			return tabControl1.SelectedIndex;
		}

		//Don't use
		//NullPointerException bei Aufruf -> Lukas bitte fixen!
		public string getActiveTabPageName()
        {
            return tabControl1.SelectedTab.Name;
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
			this.buttonLagerEntfernen = new System.Windows.Forms.Button();
			this.buttonLagerHinzufuegen = new System.Windows.Forms.Button();
			this.buttonLagerungOptimieren = new System.Windows.Forms.Button();
			this.buttonPaketUmlagern = new System.Windows.Forms.Button();
			this.buttonRegalHinzufuegen = new System.Windows.Forms.Button();
			this.buttonRegalEntfernen = new System.Windows.Forms.Button();
			this.buttonZurück = new System.Windows.Forms.Button();
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
			this.buttonPaketHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPaketHinzufuegen.Location = new System.Drawing.Point(2, 1);
			this.buttonPaketHinzufuegen.Name = "buttonPaketHinzufuegen";
			this.buttonPaketHinzufuegen.Size = new System.Drawing.Size(110, 46);
			this.buttonPaketHinzufuegen.TabIndex = 1;
			this.buttonPaketHinzufuegen.Text = "Paket hinzufügen";
			this.buttonPaketHinzufuegen.UseVisualStyleBackColor = true;
			this.buttonPaketHinzufuegen.Click += new System.EventHandler(this.buttonPaketHinzufuegen_Click);
			// 
			// buttonPaketEntfernen
			// 
			this.buttonPaketEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPaketEntfernen.Location = new System.Drawing.Point(118, 1);
			this.buttonPaketEntfernen.Name = "buttonPaketEntfernen";
			this.buttonPaketEntfernen.Size = new System.Drawing.Size(113, 46);
			this.buttonPaketEntfernen.TabIndex = 2;
			this.buttonPaketEntfernen.Text = "Paket entfernen";
			this.buttonPaketEntfernen.UseVisualStyleBackColor = true;
			this.buttonPaketEntfernen.Click += new System.EventHandler(this.buttonPaketEntfernen_Click);
			// 
			// buttonLagerEntfernen
			// 
			this.buttonLagerEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLagerEntfernen.Location = new System.Drawing.Point(897, 1);
			this.buttonLagerEntfernen.Name = "buttonLagerEntfernen";
			this.buttonLagerEntfernen.Size = new System.Drawing.Size(113, 46);
			this.buttonLagerEntfernen.TabIndex = 3;
			this.buttonLagerEntfernen.Text = "Lager entfernen";
			this.buttonLagerEntfernen.UseVisualStyleBackColor = true;
			this.buttonLagerEntfernen.Click += new System.EventHandler(this.buttonLagerEntfernen_Click);
			// 
			// buttonLagerHinzufuegen
			// 
			this.buttonLagerHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLagerHinzufuegen.Location = new System.Drawing.Point(778, 1);
			this.buttonLagerHinzufuegen.Name = "buttonLagerHinzufuegen";
			this.buttonLagerHinzufuegen.Size = new System.Drawing.Size(113, 46);
			this.buttonLagerHinzufuegen.TabIndex = 4;
			this.buttonLagerHinzufuegen.Text = "Lager hinzufügen";
			this.buttonLagerHinzufuegen.UseVisualStyleBackColor = true;
			this.buttonLagerHinzufuegen.Click += new System.EventHandler(this.buttonLagerHinzufuegen_Click);
			// 
			// buttonLagerungOptimieren
			// 
			this.buttonLagerungOptimieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLagerungOptimieren.Location = new System.Drawing.Point(659, 1);
			this.buttonLagerungOptimieren.Name = "buttonLagerungOptimieren";
			this.buttonLagerungOptimieren.Size = new System.Drawing.Size(113, 46);
			this.buttonLagerungOptimieren.TabIndex = 5;
			this.buttonLagerungOptimieren.Text = "Lagerung optimieren";
			this.buttonLagerungOptimieren.UseVisualStyleBackColor = true;
			// 
			// buttonPaketUmlagern
			// 
			this.buttonPaketUmlagern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPaketUmlagern.Location = new System.Drawing.Point(237, 1);
			this.buttonPaketUmlagern.Name = "buttonPaketUmlagern";
			this.buttonPaketUmlagern.Size = new System.Drawing.Size(113, 46);
			this.buttonPaketUmlagern.TabIndex = 6;
			this.buttonPaketUmlagern.Text = "Paket umlagern";
			this.buttonPaketUmlagern.UseVisualStyleBackColor = true;
			// 
			// buttonRegalHinzufuegen
			// 
			this.buttonRegalHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegalHinzufuegen.Location = new System.Drawing.Point(393, 1);
			this.buttonRegalHinzufuegen.Name = "buttonRegalHinzufuegen";
			this.buttonRegalHinzufuegen.Size = new System.Drawing.Size(113, 46);
			this.buttonRegalHinzufuegen.TabIndex = 8;
			this.buttonRegalHinzufuegen.Text = "Regal hinzufügen";
			this.buttonRegalHinzufuegen.UseVisualStyleBackColor = true;
			this.buttonRegalHinzufuegen.Click += new System.EventHandler(this.buttonRegalHinzufuegen_Click);
			// 
			// buttonRegalEntfernen
			// 
			this.buttonRegalEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegalEntfernen.Location = new System.Drawing.Point(512, 1);
			this.buttonRegalEntfernen.Name = "buttonRegalEntfernen";
			this.buttonRegalEntfernen.Size = new System.Drawing.Size(113, 46);
			this.buttonRegalEntfernen.TabIndex = 7;
			this.buttonRegalEntfernen.Text = "Regal ändern/ entfernen";
			this.buttonRegalEntfernen.UseVisualStyleBackColor = true;
			this.buttonRegalEntfernen.Click += new System.EventHandler(this.buttonRegalEntfernen_Click);
			// 
			// buttonZurück
			// 
			this.buttonZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonZurück.Location = new System.Drawing.Point(1034, 1);
			this.buttonZurück.Name = "buttonZurück";
			this.buttonZurück.Size = new System.Drawing.Size(91, 46);
			this.buttonZurück.TabIndex = 9;
			this.buttonZurück.Text = "Zurück";
			this.buttonZurück.UseVisualStyleBackColor = true;
			this.buttonZurück.Click += new System.EventHandler(this.buttonZurück_Click);
			// 
			// Verwaltung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1127, 602);
			this.Controls.Add(this.buttonZurück);
			this.Controls.Add(this.buttonRegalHinzufuegen);
			this.Controls.Add(this.buttonRegalEntfernen);
			this.Controls.Add(this.buttonPaketUmlagern);
			this.Controls.Add(this.buttonLagerungOptimieren);
			this.Controls.Add(this.buttonLagerHinzufuegen);
			this.Controls.Add(this.buttonLagerEntfernen);
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

		private Accordion _lagerAccordion;
		private static Accordion _lastFocusedAccordion;
		private static TabPage _lastFocusedPage;

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button buttonPaketHinzufuegen;
		private System.Windows.Forms.Button buttonPaketEntfernen;
		private System.Windows.Forms.Button buttonLagerEntfernen;
		private System.Windows.Forms.Button buttonLagerHinzufuegen;
		private System.Windows.Forms.Button buttonLagerungOptimieren;
		private System.Windows.Forms.Button buttonPaketUmlagern;
		private System.Windows.Forms.Button buttonRegalHinzufuegen;
		private System.Windows.Forms.Button buttonRegalEntfernen;
		private Button buttonZurück;
	}
}