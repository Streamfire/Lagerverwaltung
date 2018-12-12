using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lagerverwaltung.Views
{
	public partial class Regaleinsicht : Form
	{
        private Dictionary<int , List<Model.Regalfach>> _regalfachMap;

		public Regaleinsicht()
		{
			InitializeComponent();
        }

        private void Regaleinsicht_Load(object sender, System.EventArgs e)
        {
            //Daten initialisieren

            comboBoxLager.ValueMember = "LagerID";
            comboBoxLager.DisplayMember = "Name";

            comboBoxRegal.ValueMember = "RegalID";
            comboBoxRegal.DisplayMember = "Name";

            //DB Daten laden


            DB.LagerSQL.HoleAlleLager(); // testweise!
            DB.RegalSQL.HoleAlleRegale(); // testweise!
            comboBoxLager.DataSource = new BindingSource().DataSource = Model.Lager.HoleListe.Values.ToList();

        }

        private void UpdateComboboxRegal()
        {
            if(comboBoxLager.Items.Count>0)
            {
                comboBoxRegal.DataSource = new BindingSource().DataSource = ((Model.Lager)comboBoxLager.SelectedItem).Regalliste.ToList();
            }

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
            
            if (comboBoxRegal.Items.Count <= 0)
            {
                dataGridViewRegaleinsicht.Rows.Clear();
                dataGridViewRegaleinsicht.Columns.Clear();
            }
            comboBoxRegal.DataSource = new BindingSource().DataSource = ((Model.Lager)comboBoxLager.SelectedItem).Regalliste.ToList();
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
                    BackColor = Color.LightGreen,
                    Alignment = DataGridViewContentAlignment.TopLeft,
                    WrapMode = DataGridViewTriState.True,
                    SelectionBackColor = Color.FromArgb(0),
                    SelectionForeColor = Color.Black


                };


                //Spalten einfügen
                dataGridViewRegaleinsicht.ColumnCount = ((Model.Regal)comboBoxRegal.SelectedItem).Spalten;

                for (int i = 0; i < ((Model.Regal)comboBoxRegal.SelectedItem).Spalten; i++)
                {
                    dataGridViewRegaleinsicht.Columns[i].Width =150;
                }


                //Zeilen erstellen
                dataGridViewRegaleinsicht.RowCount = ((Model.Regal)comboBoxRegal.SelectedItem).Zeilen;

                for (int z = ((Model.Regal)comboBoxRegal.SelectedItem).Zeilen; z >= 1; z--)
                {

                    dataGridViewRegaleinsicht.Rows[((Model.Regal)comboBoxRegal.SelectedItem).Zeilen - z].DefaultCellStyle = cellStyle;
                    dataGridViewRegaleinsicht.Rows[((Model.Regal)comboBoxRegal.SelectedItem).Zeilen - z].Height = 150;
                    
                    //Text in Zellen schreiben (z.B. Name des Fachs + eingelagertes Produkt usw.)
                    int s = 0;
                    foreach (Model.Regalfach regalfach in _regalfachMap[z])
                    {
                        string Ausgabe = "";
                        Ausgabe += string.Format("Fach [{0},{1}] \n", s + 1, z);
                        if (regalfach != null && regalfach.Paketliste.Count > 0)
                        {
                            Ausgabe += "Paketmenge: " + regalfach.Paketliste.Count + "\n";
                            Ausgabe += "Produkt: " + Model.Produkt.HoleListe[regalfach.Paketliste[0].PaketID].Name + "\n";
                            Ausgabe += "Stückzahl je Paket: " + regalfach.Paketliste[0].Menge + "\n";

                            dataGridViewRegaleinsicht.Rows[((Model.Regal)comboBoxRegal.SelectedItem).Zeilen - z].Cells[s].Style.BackColor = Color.LightPink;


                        }


                        dataGridViewRegaleinsicht.Rows[((Model.Regal)comboBoxRegal.SelectedItem).Zeilen - z].Cells[s].Value = Ausgabe; 
                        s++;

                        //if (regalfach.)
                    }

                }

            } //END IF (kein Regal)

            dataGridViewRegaleinsicht.ClearSelection();
        }

        /// <summary>
        /// Erstellt eine Map mit den Zeilen als 
        /// </summary>
        private void InitRegalfachMap() {
            _regalfachMap = new Dictionary<int, List<Model.Regalfach>>();

            //Zeilen und Spalten vorbereiten
            //Key = Zeilen, Values = Liste mit Spalten
            for (int i = 1; i <= ((Model.Regal)comboBoxRegal.SelectedItem).Zeilen; i++)
            {
                _regalfachMap.Add(i, new List<Model.Regalfach>(((Model.Regal)comboBoxRegal.SelectedItem).Spalten));

                for (int j = 0; j < ((Model.Regal)comboBoxRegal.SelectedItem).Spalten; j++)
                {
                    _regalfachMap[i].Add(null);
                }
            }

            //Regalfächer einordnen
            foreach (Model.Regalfach regalfach in ((Model.Regal)comboBoxRegal.SelectedItem).Regalfachliste)
            {
                int[] pos = ParseRegalfachname(regalfach.Name);
                List<Model.Regalfach> list = _regalfachMap[pos[0]];
                list[pos[1] - 1] = regalfach;
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

        private void DataGridViewRegaleinsicht_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //eventuell für später, falls Teile splitten und umlagern in der Regaleinsicht implementiert werden soll
            /*
            DataGridViewAdvancedBorderStyle borderStyle = dataGridViewRegaleinsicht.AdvancedCellBorderStyle;
            borderStyle.Top = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
            borderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
            borderStyle.Left = DataGridViewAdvancedCellBorderStyle.OutsetDouble;



            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].AdjustCellBorderStyle(borderStyle, dataGridViewRegaleinsicht.AdvancedCellBorderStyle, false, false, false, false);

            */
        }
    }
}
