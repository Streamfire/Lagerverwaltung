using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lagerverwaltung.Views
{
	public partial class Regaleinsicht : Form
	{
        private Dictionary<int , List<Model.RegalfachModel>> _regalfachMap;
        private Dictionary<long, Model.LagerModel> _dictLager;
        private Dictionary<long, Model.RegalModel> _dictRegal;
        private Dictionary<long, Model.RegalfachModel> _dictRegalfach;
        private Dictionary<long, Model.PaketModel> _dictPaket;
        private Dictionary<long, Model.ProduktModel> _dictProdukt;

        private Dictionary<string, long> _regalfachIDMap;

        public Regaleinsicht()
		{
			InitializeComponent();
            DB.SqlStatements.DatabaseChanged += DataChanged;

        }

        private void DataChanged(object sender, EventArgs e)
        {
            var type = (DB.SqlStatements.ModeltypEnum)sender;

            //Eventuell später noch genauer definieren
            if (type == DB.SqlStatements.ModeltypEnum.LagerModel || type == DB.SqlStatements.ModeltypEnum.RegalModel)
            {
                ButtonAktualisieren.Enabled = true;
                ButtonHinzufuegen.Enabled = false;
                ButtonEntfernen.Enabled = false;
                comboBoxLager.Enabled = false;
                comboBoxRegal.Enabled = false;

                dataGridViewRegaleinsicht.Rows.Clear();
                dataGridViewRegaleinsicht.Columns.Clear();

                comboBoxLager.SelectedIndex = -1;
                comboBoxRegal.SelectedIndex = -1;

                labelAktualisieren.Visible = true;
            }
            else
            {
                UpdateGridView();
            }


        }

        private void Regaleinsicht_Load(object sender, System.EventArgs e)
        {
            //Daten initialisieren

            comboBoxLager.ValueMember = "Lager_ID";
            comboBoxLager.DisplayMember = "Name";

            comboBoxRegal.ValueMember = "Regal_ID";
            comboBoxRegal.DisplayMember = "Name";

            //DB Daten laden
            _dictLager = DB.SqlStatements.HoleLager();

            if (_dictLager.Values.Count > 0)
            comboBoxLager.DataSource = new BindingSource().DataSource = _dictLager.Values.ToArray();

        }

        private void Regaleinsicht_Shown(object sender, System.EventArgs e)
        {

            //Auswahl Lager 1, Regal 1 oder bei Auswahl in Lagerverwaltung -> Auswahl des bereits ausgewählten Regals
            if (Dashboard.CurrentLagerID > 0) comboBoxLager.SelectedValue = Dashboard.CurrentLagerID;
            else if (comboBoxLager.Items.Count > 0) comboBoxLager.SelectedIndex = 0;
            else comboBoxLager.SelectedIndex = -1;

            UpdateComboboxRegal();

        }

        private void UpdateComboboxRegal()
        {
            if(comboBoxLager.Items.Count>0)
            {
                _dictRegal = DB.SqlStatements.HoleRegal(-1, (long)comboBoxLager.SelectedValue,"",-1);
                comboBoxRegal.DataSource = new BindingSource().DataSource = _dictRegal.Values.ToArray();
            }

            //Auf ausgewähltes Regal prüfen
            if ((Dashboard.CurrentRegalID > 0) && _dictRegal.ContainsKey(Dashboard.CurrentRegalID) && (_dictRegal[Dashboard.CurrentRegalID].Lager_ID == (long)comboBoxLager.SelectedValue)) comboBoxRegal.SelectedValue = Dashboard.CurrentRegalID;
            else if (comboBoxRegal.Items.Count > 0) comboBoxRegal.SelectedIndex = 0;
            else comboBoxRegal.SelectedIndex = -1;
        }

        private void ButtonZurueck_Click(object sender, System.EventArgs e)
        {
            //evt. Fix für Speicherleck 

            Close();
        }

        private void ComboBoxLager_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxLager.SelectedIndex >= 0)
            {
                _dictRegal = DB.SqlStatements.HoleRegal(-1, (long)comboBoxLager.SelectedValue, "", -1);
                comboBoxRegal.DataSource = new BindingSource().DataSource = _dictRegal.Values.ToArray();
            }

            if (comboBoxRegal.Items.Count <= 0 || comboBoxLager.SelectedIndex < 0)
            {
                dataGridViewRegaleinsicht.Rows.Clear();
                dataGridViewRegaleinsicht.Columns.Clear();

                comboBoxRegal.SelectedIndex = -1;
            }
            else
                comboBoxRegal.SelectedIndex = 0;

        }

        private void ComboBoxRegal_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            dataGridViewRegaleinsicht.Rows.Clear();
            _regalfachIDMap = new Dictionary<string, long>();

            if (((Model.RegalModel)comboBoxRegal.SelectedItem) != null)
            {
                InitRegalfachMap();


                //Standartaussehen für die einzelnen Cells im DGV
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.LightGreen,
                    Alignment = DataGridViewContentAlignment.TopLeft,
                    WrapMode = DataGridViewTriState.True,
                    //SelectionBackColor = Color.FromArgb(0),
                    //SelectionForeColor = Color.Black


                };


                //Spalten einfügen
                dataGridViewRegaleinsicht.ColumnCount = ((Model.RegalModel)comboBoxRegal.SelectedItem).Spalten;

                for (int i = 0; i < ((Model.RegalModel)comboBoxRegal.SelectedItem).Spalten; i++)
                {
                    dataGridViewRegaleinsicht.Columns[i].Width =150;
                }


                //Zeilen erstellen
                dataGridViewRegaleinsicht.RowCount = ((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen;

                for (int z = ((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen; z >= 1; z--)
                {

                    dataGridViewRegaleinsicht.Rows[((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen - z].DefaultCellStyle = cellStyle;
                    dataGridViewRegaleinsicht.Rows[((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen - z].Height = 150;

                    //Text in Zellen schreiben (z.B. Name des Fachs + eingelagertes Produkt usw.)

                    int s = 0;
                    foreach (Model.RegalfachModel regalfach in _regalfachMap[z])
                    {
                        if (regalfach != null)
                        {
                            //Eintragen der IDs eines Regalfachs mit der entsprechenden Zellenposition als Key
                            _regalfachIDMap.Add((((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen - z).ToString() + "-" +  s , regalfach.Regalfach_ID);

                            _dictPaket = DB.SqlStatements.HolePaket(-1, regalfach.Regalfach_ID, "", -1);
                        }
                        string Ausgabe = "";
                        Ausgabe += string.Format("Fach [{0},{1}] \n", s + 1, z);
                        if (regalfach != null && _dictPaket != null  && _dictPaket.Keys.Count > 0) 
                        {
                            _dictProdukt = DB.SqlStatements.HoleProdukt((_dictPaket.Values.First().Produkt_ID), "", 1); 

                            Ausgabe += "Paketmenge: " + _dictPaket.Keys.Count + "\n";
                            Ausgabe += "Produkt: " + _dictProdukt.Values.First().Name + "\n";

                            int gesamt = 0;
                            foreach (Model.PaketModel paket in _dictPaket.Values)
                                gesamt += paket.Menge; 

                            Ausgabe += "Gesamtmenge: " + gesamt + "\n";

                            dataGridViewRegaleinsicht.Rows[((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen - z].Cells[s].Style.BackColor = Color.LightPink;
                        }

                        dataGridViewRegaleinsicht.Rows[((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen - z].Cells[s].Value = Ausgabe; 
                        s++;

                        //if (regalfach.)
                    }

                }

            } //END IF (kein Regal)

            dataGridViewRegaleinsicht.ClearSelection();
        }

        /// <summary>
        /// Erstellt eine Map mit den Zeilen als Key und den Spalten/Daten als Values
        /// </summary>
        private void InitRegalfachMap() {
            _regalfachMap = new Dictionary<int, List<Model.RegalfachModel>>();

            //Zeilen und Spalten vorbereiten
            //Key = Zeilen, Values = Liste mit Spalten
            for (int i = 1; i <= ((Model.RegalModel)comboBoxRegal.SelectedItem).Zeilen; i++)
            {
                _regalfachMap.Add(i, new List<Model.RegalfachModel>(((Model.RegalModel)comboBoxRegal.SelectedItem).Spalten));

                for (int j = 0; j < ((Model.RegalModel)comboBoxRegal.SelectedItem).Spalten; j++)
                {
                    _regalfachMap[i].Add(null);
                }
            }

            //Regalfächer einordnen
            _dictRegalfach = DB.SqlStatements.HoleRegalfach(-1, (long)comboBoxRegal.SelectedValue,"",-1);

            foreach (Model.RegalfachModel regalfach in _dictRegalfach.Values)
            {
                int[] pos = ParseRegalfachname(regalfach.Name);
                List<Model.RegalfachModel> list = _regalfachMap[pos[0]];
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

        private void ButtonAktualisieren_Click(object sender, EventArgs e)
        {
            ButtonAktualisieren.Enabled = false;
            ButtonHinzufuegen.Enabled = true;
            ButtonEntfernen.Enabled = true;
            comboBoxLager.Enabled = true;
            comboBoxRegal.Enabled = true;


            labelAktualisieren.Visible = false;

            _dictLager = DB.SqlStatements.HoleLager();

            if (_dictLager.Values.Count > 0)
            {
                comboBoxLager.DataSource = new BindingSource().DataSource = _dictLager.Values.ToArray();
                comboBoxLager.SelectedIndex = 0;
            }
            else
                comboBoxLager.SelectedIndex = -1;

            UpdateComboboxRegal();

        }

        private void ButtonHinzufuegen_Click(object sender, EventArgs e)
        {
            using (var pakethinzufuegen = new PaketHinzufuegen())
            {
                string key = dataGridViewRegaleinsicht.CurrentCell.RowIndex.ToString() + "-" + dataGridViewRegaleinsicht.CurrentCell.ColumnIndex.ToString();

                pakethinzufuegen.Owner = this;
                if (_regalfachIDMap.ContainsKey(key))
                {
                    pakethinzufuegen.RegalfachID = _regalfachIDMap[key];
                    pakethinzufuegen.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Es wurde kein Regalfach ausgewählt", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ButtonEntfernen_Click(object sender, EventArgs e)
        {
            string key = dataGridViewRegaleinsicht.CurrentCell.RowIndex.ToString() + "-" + dataGridViewRegaleinsicht.CurrentCell.ColumnIndex.ToString();

            if (_regalfachIDMap.ContainsKey(key))
            {
                if (dataGridViewRegaleinsicht.CurrentCell.Style.BackColor == Color.LightPink)
                {
                    using (var paketentfernen = new PaketEntfernen())
                    {
                        paketentfernen.Owner = this;
                        paketentfernen.RegalfachID = _regalfachIDMap[key];
                        paketentfernen.ShowDialog();

                    

                    }
                }
                else
                    MessageBox.Show("Das ausgewählte Regalfach besitzt keine Pakete", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Es wurde kein Regalfach ausgewählt", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
