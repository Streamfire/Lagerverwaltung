﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class ProduktHinzufuegen : Form
    {
        private List<Model.ArtikeltypModel> _artikeltypListe;
		private Produktliste _parent;

        public ProduktHinzufuegen()
        {
            InitializeComponent();
            artikeltypBox.ValueMember = "artikeltyp_id";
            artikeltypBox.DisplayMember = "name";

            _artikeltypListe = DB.SqlStatements.HoleAlleArtikeltypen();
                
                //Dashboard.ArtikeltypListe;            
            //TEST

            //TODO:Artikeltypen aus Datenbank laden


            //in ComboBox eintragen (eventuell auch ohne Zwischengespeicherte Liste)
            foreach (Model.ArtikeltypModel artikeltyp in _artikeltypListe)
            {
                artikeltypBox.Items.Add(artikeltyp);
            }


            artikeltypBox.SelectedIndex = 0;

			_parent = PaketHinzufuegen.Produktliste;

		}

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonProduktHinzufuegen_Click(object sender, EventArgs e)
        {
            if (Controller.ProduktHinzufuegenController.ValidateData(tb_Name.Text, tb_Zeichnungsnummer.Text, tb_Gewicht.Text, tb_Preis.Text))
            
            //Validierung erfolgreich
            {
                //TODO:Produkt der Produktliste hinzufügen
                Dashboard.ProduktListe.Add(new Model.Produkt(0, tb_Name.Text, tb_Zeichnungsnummer.Text, Convert.ToSingle(tb_Gewicht.Text), Convert.ToSingle(tb_Preis.Text), new DateTime(), new DateTime(), 0,0f,0f,0f));
				_parent.UpdateForm();
                Close();
            }

            //Validierung nicht erfolgreich
            else
            {

            }
        }
    }
}
