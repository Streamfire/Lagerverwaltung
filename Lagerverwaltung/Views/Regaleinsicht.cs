using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Lagerverwaltung.Views
{
	public partial class Regaleinsicht : Form
	{
        private Dictionary<int , List<Model.Regalfach>> _regalfachMap;

		public Regaleinsicht()
		{
			InitializeComponent();
        }

        /// <summary>
        /// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegalFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Regaleinsicht = null;
		}

        private void Regaleinsicht_Load(object sender, System.EventArgs e)
        {
            //Daten initialisieren

            comboBoxLager.ValueMember = "LagerID";
            comboBoxLager.DisplayMember = "Name";

            comboBoxRegal.ValueMember = "RegalID";
            comboBoxRegal.DisplayMember = "Name";

            //DB Daten laden



            comboBoxLager.DataSource = new BindingSource(Model.Lager.HoleListe.Values, null);
            

        }

        private void UpdateComboboxRegal()
        {
            comboBoxRegal.DataSource = new BindingSource(((Model.Lager)comboBoxLager.SelectedItem).Regalliste, null);

            string currentRegal;

            //Eventuell Fehler, falls das ausgewählte Regal nicht in dem Lager enthalten ist
            if ((currentRegal = Dashboard.CurrentRegal) != null) comboBoxRegal.SelectedValue = (ushort)(Model.Regal.GetIDByName(currentRegal));
            else if (comboBoxRegal.Items.Count != 0) comboBoxRegal.SelectedIndex = 0;
            else comboBoxRegal.SelectedIndex = -1;
        }

        private void ButtonZurueck_Click(object sender, System.EventArgs e)
        {
            Hide();
        }

        private void Regaleinsicht_Shown(object sender, System.EventArgs e)
        {
            
            //Auswahl Lager 1, Regal 1 oder bei Auswahl in Lagerverwaltung -> Auswahl des bereits ausgewählten Regals
            string currentLager;

            if ((currentLager = Dashboard.CurrentLager) != null) comboBoxLager.SelectedValue = Model.Lager.HoleNamensliste[currentLager];
            else if (comboBoxLager.Items.Count != 0) comboBoxLager.SelectedIndex = 0;
            else comboBoxLager.SelectedIndex = -1;

            UpdateComboboxRegal();
            
        }

        private void ComboBoxLager_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            comboBoxRegal.DataSource = new BindingSource(((Model.Lager)comboBoxLager.SelectedItem).Regalliste, null);
            if (comboBoxRegal.Items.Count <= 0)
            {
                dataGridViewRegaleinsicht.Rows.Clear();
                dataGridViewRegaleinsicht.Columns.Clear();
            }
        }

        private void ComboBoxRegal_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            dataGridViewRegaleinsicht.Rows.Clear();

            if (((Model.Regal)comboBoxRegal.SelectedItem) != null)
            {
                InitRegalfachMap();


                //Standartaussehen für die einzelnen Cells im DGV
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.LightGreen
                };


                //Spalten einfügen
                dataGridViewRegaleinsicht.ColumnCount = ((Model.Regal)comboBoxRegal.SelectedItem).Spalten;

                for (int i = 0; i < ((Model.Regal)comboBoxRegal.SelectedItem).Spalten; i++)
                {
                    dataGridViewRegaleinsicht.Columns[i].Width =100;
                }


                //Zeilen erstellen
                dataGridViewRegaleinsicht.RowCount = ((Model.Regal)comboBoxRegal.SelectedItem).Zeilen;

                for (int i = ((Model.Regal)comboBoxRegal.SelectedItem).Zeilen; i >= 1; i--)
                {

                    dataGridViewRegaleinsicht.Rows[((Model.Regal)comboBoxRegal.SelectedItem).Zeilen - i].DefaultCellStyle = cellStyle;
                    dataGridViewRegaleinsicht.Rows[((Model.Regal)comboBoxRegal.SelectedItem).Zeilen - i].Height = 100;
                    
                    //Text in Zellen schreiben (z.B. Name des Fachs + eingelagertes Produkt usw.)
                    int z = 0;
                    foreach (Model.Regalfach regalfach in _regalfachMap[i])
                    {
                        dataGridViewRegaleinsicht.Rows[((Model.Regal)comboBoxRegal.SelectedItem).Zeilen - i].Cells[z].Value = String.Format("Fach [{0},{1}}", z, i);
                        z++;
                    }

                }

            } //END IF (kein Regal)
        }

        /// <summary>
        /// Erstellt eine Map mit den Zeilen als 
        /// </summary>
        private void InitRegalfachMap() {
            _regalfachMap = new Dictionary<int, List<Model.Regalfach>>();

            //Zeilen und Spalten vorbereiten
            for (int i = 1; i <= ((Model.Regal)comboBoxRegal.SelectedItem).Zeilen; i++)
            {
                _regalfachMap.Add(i, new List<Model.Regalfach>());
            }

            //Regalfächer einordnen
            foreach (Model.Regalfach regalfach in ((Model.Regal)comboBoxRegal.SelectedItem).Regalfachliste)
            {
                int[] pos = ParseRegalfachname(regalfach.Name);
                _regalfachMap[pos[0]].Insert(pos[1], regalfach);
            }
        }

        /// <summary>
        /// Gibt die Zeile und Spalte eines Regalfachs in Abhängigkeit des Namens zurück
        /// </summary>
        /// <param name="regalfachname">Name des zu interpretierenden Regalfachs</param>
        /// <returns>Array mit int[0] = Zeile, int[1] = Spalte, sofern im Namen richtig initialisiert</returns>
        private int[] ParseRegalfachname(string regalfachname) {
            int[] erg = new int[2];
            string[] val = regalfachname.Split('-');

            //Alle führenden 0en entfernen (zur Sicherheit)
            val[0].TrimStart('0');
            val[1].TrimStart('0');
            try
            {
                erg[0] = Convert.ToInt32(val[1]);
                erg[1] = Convert.ToInt32(val[2]);
            }
            //Fehler in Name von Regalfach -> Falsches Format
            catch
            {
                MessageBox.Show("Ungültiger Name des Regalfachs", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return erg;
        }


    }
}
