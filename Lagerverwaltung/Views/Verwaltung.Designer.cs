using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lagerverwaltung.Model;
using Opulos.Core.UI;

namespace Lagerverwaltung.Views
{
    public partial class Verwaltung
	{
        private Accordion _lagerAccordion;
        private static Accordion _lastFocusedAccordion;
        private static TabPage _lastFocusedPage;

        /// <summary>
        /// verarbeitet die Lageliste aus dem Dash und erstellt dynamisch Tabpages, Akkordions und zusatinfo Panele
        /// </summary>
        /// <param name="lagerListe">die Lagerliste, übergeben vom Dashboard</param>
        public void UpdateForm()
		{
			//Reset Form
			VerwaltungTabcontrol.Controls.Clear();
            VerwaltungTabcontrol.SelectedIndexChanged += OnChangedTab;

			//expand wenn checkbox
			if (ForceCheckbox.Checked == true)
			{
				Opulos.Core.UI.Accordion.OpenOnAdd = true;
			}
			else
			{
				Opulos.Core.UI.Accordion.OpenOnAdd = false;
			}

			var lagerListe = DB.SqlStatements.HoleLager();
			foreach (LagerModel l in lagerListe.Values)
			{
				TabPage tp = new TabPage(l.Name);
			
				_lagerAccordion = new Accordion();
				_lagerAccordion.GotFocus += OnFocusedPanel;

				tp.Controls.Add(_lagerAccordion);

                VerwaltungTabcontrol.TabPages.Add(tp);

				var regalListe = DB.SqlStatements.HoleRegal(-1, l.Lager_ID);

				foreach (RegalModel r in regalListe.Values)
				{
					Accordion nestedRegal = new Accordion();
					nestedRegal.Name = r.Name;
					nestedRegal.Tag = r.Regal_ID;
					
					nestedRegal.GotFocus += OnFocusedPanel;
					_lagerAccordion.Add(nestedRegal, r.Name);

					var regalFachListe = DB.SqlStatements.HoleRegalfach(-1, r.Regal_ID);

					foreach (RegalfachModel f in regalFachListe.Values)
					{
						Accordion nestedFach = new Accordion();
						nestedFach.GotFocus += OnFocusedPanel;
						nestedFach.Name = f.Name;
						nestedFach.Tag = f.Regalfach_ID;

						Panel infoPanel = new Panel();
						Label name = new Label();

						var paketListe = DB.SqlStatements.HolePaket(-1, f.Regalfach_ID);

						if (paketListe.Count > 0)
						{
							//im Fach ist ein Paketregistriert-> die restlichen Infos zum Paket anzeigen
							name.Text = "Inhalt: " + paketListe[0].Produkt_ID;

							Label Menge = new Label();
							Label Breite = new Label();
							Label Hoehe = new Label();
							Label Laenge = new Label();
							Label Haltbarkeit = new Label();
							Label Erstellt = new Label();
							Label Geaendert = new Label();
							Label Anschaffungsgrund = new Label();

							Menge.Left = 100;
							Menge.Text = "Menge: " + paketListe.Count;

							Breite.Left = 200;
							Breite.Text = "Breite: " + paketListe[0].Breite;

							Hoehe.Left = 300;
							Hoehe.Text = "Höhe: " + paketListe[0].Hoehe;

							Laenge.Left = 400;
							Laenge.Text = "Länge: " + paketListe[0].Laenge;

							Haltbarkeit.Left = 500;
							Haltbarkeit.Text = "Haltbarkeit: " + paketListe[0].Haltbarkeit;

							Erstellt.Left = 600;
							Erstellt.Text = "Erstellt: " + paketListe[0].Erstellt_Am;

							Geaendert.Left = 700;
							Geaendert.Text = "Geaendert: " + paketListe[0].Zuletzt_Geaendert;

							Anschaffungsgrund.Top = 25;
							Anschaffungsgrund.Text = "Anschaffungsgrund: " + paketListe[0].Anschaffungsgrund;
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

							nestedRegal.Add(nestedFach, paketListe[0].Name + " | " + paketListe[0].Produkt_ID);
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
            if(VerwaltungTabcontrol.TabPages.Count > 0)
            {
                _lastFocusedPage = VerwaltungTabcontrol.TabPages[0];
            }
            else
            {
                _lastFocusedPage = null;
            }
		}

		private void DataChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}


		private void OnFocusedPanel(Object sender, EventArgs e)
		{
            //TODO: bitte ändern
            //TODO: Zuletzt ausgewähltes Element kann durch die SQLStatements nur noch mit der ID gespeichert werden
            /*
			_lastFocusedAccordion = (Accordion) sender;
            Dashboard.CurrentRegalID = _lastFocusedAccordion.Name;
            */
        }

        private void OnChangedTab(Object sender, EventArgs e)
		{
            //TODO: bitte ändern
            //TODO: Zuletzt ausgewähltes Element kann durch die SQLStatements nur noch mit der ID gespeichert werden
            /*
          if(((TabControl)sender).SelectedIndex!=-1)
			{
				_lastFocusedPage = ((TabControl)sender).TabPages[((TabControl)sender).SelectedIndex];
				Dashboard.CurrentLagerID = ((TabControl)sender).TabPages[((TabControl)sender).SelectedIndex].Text;
			}
			else if (((TabControl)sender).TabPages.Count>0)
			{
				_lastFocusedPage = ((TabControl)sender).TabPages[0];
				Dashboard.CurrentLagerID = ((TabControl)sender).TabPages[0].Text;
			}
			else
			{

			}
            */
			
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
			return VerwaltungTabcontrol.SelectedIndex;
		}

		//Don't use
		//NullPointerException bei Aufruf -> Lukas bitte fixen!
		public string getActiveTabPageName()
        {
            return VerwaltungTabcontrol.SelectedTab.Name;
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
            this.VerwaltungTabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.LagerEntfernen = new MetroFramework.Controls.MetroButton();
            this.LagerHinzufuegenButton = new MetroFramework.Controls.MetroButton();
            this.LagerOptimierenButton = new MetroFramework.Controls.MetroButton();
            this.RegalAnpassenButton = new MetroFramework.Controls.MetroButton();
            this.RegalHinzufuegenButton = new MetroFramework.Controls.MetroButton();
            this.PaketUmlagernButton = new MetroFramework.Controls.MetroButton();
            this.PaketEntfernenButton = new MetroFramework.Controls.MetroButton();
            this.PaketHinzufuegenButton = new MetroFramework.Controls.MetroButton();
            this.ZurueckButton = new MetroFramework.Controls.MetroButton();
            this.ForceCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // VerwaltungTabcontrol
            // 
            this.VerwaltungTabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerwaltungTabcontrol.Location = new System.Drawing.Point(32, 99);
            this.VerwaltungTabcontrol.Name = "VerwaltungTabcontrol";
            this.VerwaltungTabcontrol.Size = new System.Drawing.Size(1095, 442);
            this.VerwaltungTabcontrol.TabIndex = 11;
            this.VerwaltungTabcontrol.UseSelectable = true;
            // 
            // LagerEntfernen
            // 
            this.LagerEntfernen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LagerEntfernen.Location = new System.Drawing.Point(899, 63);
            this.LagerEntfernen.Name = "LagerEntfernen";
            this.LagerEntfernen.Size = new System.Drawing.Size(106, 30);
            this.LagerEntfernen.TabIndex = 27;
            this.LagerEntfernen.Text = "Lager entfernen";
            this.LagerEntfernen.UseSelectable = true;
            this.LagerEntfernen.Click += new System.EventHandler(this.LagerEntfernen_Click);
            // 
            // LagerHinzufuegenButton
            // 
            this.LagerHinzufuegenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LagerHinzufuegenButton.Location = new System.Drawing.Point(777, 63);
            this.LagerHinzufuegenButton.Name = "LagerHinzufuegenButton";
            this.LagerHinzufuegenButton.Size = new System.Drawing.Size(116, 30);
            this.LagerHinzufuegenButton.TabIndex = 26;
            this.LagerHinzufuegenButton.Text = "Lager hinzufügen";
            this.LagerHinzufuegenButton.UseSelectable = true;
            this.LagerHinzufuegenButton.Click += new System.EventHandler(this.LagerHinzufuegenButton_Click);
            // 
            // LagerOptimierenButton
            // 
            this.LagerOptimierenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LagerOptimierenButton.Location = new System.Drawing.Point(657, 63);
            this.LagerOptimierenButton.Name = "LagerOptimierenButton";
            this.LagerOptimierenButton.Size = new System.Drawing.Size(114, 30);
            this.LagerOptimierenButton.TabIndex = 25;
            this.LagerOptimierenButton.Text = "Lager optimieren";
            this.LagerOptimierenButton.UseSelectable = true;
            this.LagerOptimierenButton.Click += new System.EventHandler(this.LagerOptimierenButton_Click);
            // 
            // RegalAnpassenButton
            // 
            this.RegalAnpassenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegalAnpassenButton.Location = new System.Drawing.Point(490, 63);
            this.RegalAnpassenButton.Name = "RegalAnpassenButton";
            this.RegalAnpassenButton.Size = new System.Drawing.Size(161, 30);
            this.RegalAnpassenButton.TabIndex = 24;
            this.RegalAnpassenButton.Text = "Regal ändern/ entfernen";
            this.RegalAnpassenButton.UseSelectable = true;
            this.RegalAnpassenButton.Click += new System.EventHandler(this.RegalAnpassenButton_Click);
            // 
            // RegalHinzufuegenButton
            // 
            this.RegalHinzufuegenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegalHinzufuegenButton.Location = new System.Drawing.Point(368, 63);
            this.RegalHinzufuegenButton.Name = "RegalHinzufuegenButton";
            this.RegalHinzufuegenButton.Size = new System.Drawing.Size(116, 30);
            this.RegalHinzufuegenButton.TabIndex = 23;
            this.RegalHinzufuegenButton.Text = "Regal hinzufügen";
            this.RegalHinzufuegenButton.UseSelectable = true;
            this.RegalHinzufuegenButton.Click += new System.EventHandler(this.RegalHinzufuegenButton_Click);
            // 
            // PaketUmlagernButton
            // 
            this.PaketUmlagernButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaketUmlagernButton.Location = new System.Drawing.Point(257, 63);
            this.PaketUmlagernButton.Name = "PaketUmlagernButton";
            this.PaketUmlagernButton.Size = new System.Drawing.Size(105, 30);
            this.PaketUmlagernButton.TabIndex = 22;
            this.PaketUmlagernButton.Text = "Paket umlagern";
            this.PaketUmlagernButton.UseSelectable = true;
            this.PaketUmlagernButton.Click += new System.EventHandler(this.PaketUmlagernButton_Click);
            // 
            // PaketEntfernenButton
            // 
            this.PaketEntfernenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaketEntfernenButton.Location = new System.Drawing.Point(145, 63);
            this.PaketEntfernenButton.Name = "PaketEntfernenButton";
            this.PaketEntfernenButton.Size = new System.Drawing.Size(106, 30);
            this.PaketEntfernenButton.TabIndex = 21;
            this.PaketEntfernenButton.Text = "Paket auslagern";
            this.PaketEntfernenButton.UseSelectable = true;
            this.PaketEntfernenButton.Click += new System.EventHandler(this.PaketEntfernenButton_Click);
            // 
            // PaketHinzufuegenButton
            // 
            this.PaketHinzufuegenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaketHinzufuegenButton.Location = new System.Drawing.Point(23, 63);
            this.PaketHinzufuegenButton.Name = "PaketHinzufuegenButton";
            this.PaketHinzufuegenButton.Size = new System.Drawing.Size(116, 30);
            this.PaketHinzufuegenButton.TabIndex = 20;
            this.PaketHinzufuegenButton.Text = "Paket einlagern";
            this.PaketHinzufuegenButton.UseSelectable = true;
            this.PaketHinzufuegenButton.Click += new System.EventHandler(this.PaketHinzufuegenButton_Click);
            // 
            // ZurueckButton
            // 
            this.ZurueckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZurueckButton.Location = new System.Drawing.Point(1042, 547);
            this.ZurueckButton.Name = "ZurueckButton";
            this.ZurueckButton.Size = new System.Drawing.Size(85, 30);
            this.ZurueckButton.TabIndex = 28;
            this.ZurueckButton.Text = "Zurück";
            this.ZurueckButton.UseSelectable = true;
            this.ZurueckButton.Click += new System.EventHandler(this.ZurueckButton_Click);
            // 
            // ForceCheckbox
            // 
            this.ForceCheckbox.AutoSize = true;
            this.ForceCheckbox.Location = new System.Drawing.Point(1011, 78);
            this.ForceCheckbox.Name = "ForceCheckbox";
            this.ForceCheckbox.Size = new System.Drawing.Size(93, 15);
            this.ForceCheckbox.TabIndex = 29;
            this.ForceCheckbox.Text = "Force Expand";
            this.ForceCheckbox.UseSelectable = true;
            this.ForceCheckbox.CheckedChanged += new System.EventHandler(this.ForceCheckbox_CheckedChanged);
            // 
            // Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.ForceCheckbox);
            this.Controls.Add(this.ZurueckButton);
            this.Controls.Add(this.LagerEntfernen);
            this.Controls.Add(this.LagerHinzufuegenButton);
            this.Controls.Add(this.LagerOptimierenButton);
            this.Controls.Add(this.RegalAnpassenButton);
            this.Controls.Add(this.RegalHinzufuegenButton);
            this.Controls.Add(this.PaketUmlagernButton);
            this.Controls.Add(this.PaketEntfernenButton);
            this.Controls.Add(this.PaketHinzufuegenButton);
            this.Controls.Add(this.VerwaltungTabcontrol);
            this.Name = "Verwaltung";
            this.Text = "Verwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private MetroFramework.Controls.MetroTabControl VerwaltungTabcontrol;
        private MetroFramework.Controls.MetroButton LagerEntfernen;
        private MetroFramework.Controls.MetroButton LagerHinzufuegenButton;
        private MetroFramework.Controls.MetroButton LagerOptimierenButton;
        private MetroFramework.Controls.MetroButton RegalAnpassenButton;
        private MetroFramework.Controls.MetroButton RegalHinzufuegenButton;
        private MetroFramework.Controls.MetroButton PaketUmlagernButton;
        private MetroFramework.Controls.MetroButton PaketEntfernenButton;
        private MetroFramework.Controls.MetroButton PaketHinzufuegenButton;
        private MetroFramework.Controls.MetroButton ZurueckButton;
        private MetroFramework.Controls.MetroCheckBox ForceCheckbox;
    }
}