using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lagerverwaltung.Views
{
	public partial class Regaleinsicht : MetroFramework.Forms.MetroForm
	{
        private Dictionary<int , List<Model.RegalfachModel>> _regalfachMap;
        private Dictionary<long, Model.LagerModel> _dictLager;
        private Dictionary<long, Model.RegalModel> _dictRegal;
        private Dictionary<long, Model.RegalfachModel> _dictRegalfach;
        private Dictionary<long, Model.PaketModel> _dictPaket;
        private Dictionary<long, Model.ProduktModel> _dictProdukt;

        private Dictionary<string, long> _regalfachIDMap;

        /// <summary>
        /// Klasse zur Zusammenfassung der Pakete aus der Datenbank in die jeweiligen Produkte 
        /// </summary>
        class AusgabeParameter {
            public int _paketanzahl { get; set; }
            public int _stueckzahlGesamt { get; set; }

            public AusgabeParameter(int paketanzahl, int stueckzahlGesamt)
            {
                _paketanzahl = paketanzahl;
                _stueckzahlGesamt = stueckzahlGesamt;
            }
        }

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
                AktualisierenButton.Enabled = true;
                PaketeinlagernButton.Enabled = false;
                PaketauslagernButton.Enabled = false;
                LagerCombobox.Enabled = false;
                RegalCombobox.Enabled = false;

                RegaleinsichtGrid.Rows.Clear();
                RegaleinsichtGrid.Columns.Clear();

                LagerCombobox.SelectedIndex = -1;
                RegalCombobox.SelectedIndex = -1;

                LadeDatenLabel.Visible = true;
            }
            else
            {
                UpdateGridView();
            }


        }

        private void Regaleinsicht_Load(object sender, System.EventArgs e)
        {
            //Daten initialisieren

            LagerCombobox.ValueMember = "Lager_ID";
            LagerCombobox.DisplayMember = "Name";

            RegalCombobox.ValueMember = "Regal_ID";
            RegalCombobox.DisplayMember = "Name";

            //DB Daten laden
            _dictLager = DB.SqlStatements.HoleLager();

            if (_dictLager.Values.Count > 0)
                LagerCombobox.DataSource = new BindingSource().DataSource = _dictLager.Values.ToArray();

        }

        private void Regaleinsicht_Shown(object sender, System.EventArgs e)
        {

            //Auswahl Lager 1, Regal 1 oder bei Auswahl in Lagerverwaltung -> Auswahl des bereits ausgewählten Regals
            if (Dashboard.CurrentLagerID > 0) LagerCombobox.SelectedValue = Dashboard.CurrentLagerID;
            else if (LagerCombobox.Items.Count > 0) LagerCombobox.SelectedIndex = 0;
            else LagerCombobox.SelectedIndex = -1;

            UpdateComboboxRegal();

        }

        private void UpdateComboboxRegal()
        {
            if(LagerCombobox.Items.Count>0)
            {
                _dictRegal = DB.SqlStatements.HoleRegal(-1, (long)LagerCombobox.SelectedValue,"",-1);
                RegalCombobox.DataSource = new BindingSource().DataSource = _dictRegal.Values.ToArray();
            }

            //Auf ausgewähltes Regal prüfen
            if ((Dashboard.CurrentRegalID > 0) && _dictRegal.ContainsKey(Dashboard.CurrentRegalID) && (_dictRegal[Dashboard.CurrentRegalID].Lager_ID == (long)LagerCombobox.SelectedValue)) RegalCombobox.SelectedValue = Dashboard.CurrentRegalID;
            else if (RegalCombobox.Items.Count > 0) RegalCombobox.SelectedIndex = 0;
            else RegalCombobox.SelectedIndex = -1;
        }

        private void ComboBoxLager_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (LagerCombobox.SelectedIndex >= 0)
            {
                _dictRegal = DB.SqlStatements.HoleRegal(-1, (long)LagerCombobox.SelectedValue, "", -1);
                RegalCombobox.DataSource = new BindingSource().DataSource = _dictRegal.Values.ToArray();
            }

            if (RegalCombobox.Items.Count <= 0 || LagerCombobox.SelectedIndex < 0)
            {
                RegaleinsichtGrid.Rows.Clear();
                RegaleinsichtGrid.Columns.Clear();

                RegalCombobox.SelectedIndex = -1;
            }
            else
                RegalCombobox.SelectedIndex = 0;

        }

        private void ComboBoxRegal_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            RegaleinsichtGrid.Rows.Clear();
            _regalfachIDMap = new Dictionary<string, long>();

            if (((Model.RegalModel)RegalCombobox.SelectedItem) != null)
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
                RegaleinsichtGrid.ColumnCount = ((Model.RegalModel)RegalCombobox.SelectedItem).Spalten;

                for (int i = 0; i < ((Model.RegalModel)RegalCombobox.SelectedItem).Spalten; i++)
                {
                    RegaleinsichtGrid.Columns[i].Width =150;
                }


                //Zeilen erstellen
                RegaleinsichtGrid.RowCount = ((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen;

                for (int z = ((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen; z >= 1; z--)
                {

                    RegaleinsichtGrid.Rows[((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen - z].DefaultCellStyle = cellStyle;
                    RegaleinsichtGrid.Rows[((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen - z].Height = 150;

                    //Text in Zellen schreiben (z.B. Name des Fachs + eingelagertes Produkt usw.)

                    int s = 0;
                    foreach (Model.RegalfachModel regalfach in _regalfachMap[z])
                    {
                        if (regalfach != null)
                        {
                            //Eintragen der IDs eines Regalfachs mit der entsprechenden Zellenposition als Key
                            _regalfachIDMap.Add((((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen - z).ToString() + "-" +  s , regalfach.Regalfach_ID);

                            _dictPaket = DB.SqlStatements.HolePaket(-1, regalfach.Regalfach_ID, "", -1);
                        }
                        string Ausgabe = "";
                        Ausgabe += string.Format("Fach [{0},{1}] \n", s + 1, z);

                        if (regalfach != null && _dictPaket != null  && _dictPaket.Keys.Count > 0) 
                        {
                            Dictionary<long, AusgabeParameter> _dictAusgabe = new Dictionary<long, AusgabeParameter>();

                            //Werte des AusgabeDictionary vorbereiten
                            foreach (Model.PaketModel paket in _dictPaket.Values)
                            {
                                if(!_dictAusgabe.ContainsKey(paket.Produkt_ID))
                                {
                                    _dictAusgabe.Add(paket.Produkt_ID, new AusgabeParameter(1, paket.Menge));
                                }
                                else
                                {
                                    _dictAusgabe[paket.Produkt_ID]._paketanzahl++;
                                    _dictAusgabe[paket.Produkt_ID]._stueckzahlGesamt += paket.Menge;
                                }
                            }

                            //benötigte Produkte abrufen
                            _dictProdukt = DB.SqlStatements.HoleProdukt(_dictAusgabe.Keys.ToArray());

                            foreach (KeyValuePair<long,AusgabeParameter> parameter in _dictAusgabe)
                            {
                                Ausgabe += "Produkt: " + _dictProdukt[parameter.Key].Name + "\n";
                                Ausgabe += "Anzahl Pakete: " + parameter.Value._paketanzahl + "\n";
                                Ausgabe += "Stückzahl Gesamt: " + parameter.Value._stueckzahlGesamt + "\n\n";
                            }

                            RegaleinsichtGrid.Rows[((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen - z].Cells[s].Style.BackColor = Color.LightPink;
                        }

                        RegaleinsichtGrid.Rows[((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen - z].Cells[s].Value = Ausgabe; 
                        s++;

                        //if (regalfach.)
                    }

                }

            } //END IF (kein Regal)

            RegaleinsichtGrid.ClearSelection();
        }

        /// <summary>
        /// Erstellt eine Map mit den Zeilen als Key und den Spalten/Daten als Values
        /// </summary>
        private void InitRegalfachMap() {
            _regalfachMap = new Dictionary<int, List<Model.RegalfachModel>>();

            //Zeilen und Spalten vorbereiten
            //Key = Zeilen, Values = Liste mit Spalten
            for (int i = 1; i <= ((Model.RegalModel)RegalCombobox.SelectedItem).Zeilen; i++)
            {
                _regalfachMap.Add(i, new List<Model.RegalfachModel>(((Model.RegalModel)RegalCombobox.SelectedItem).Spalten));

                for (int j = 0; j < ((Model.RegalModel)RegalCombobox.SelectedItem).Spalten; j++)
                {
                    _regalfachMap[i].Add(null);
                }
            }

            //Regalfächer einordnen
            _dictRegalfach = DB.SqlStatements.HoleRegalfach(-1, (long)RegalCombobox.SelectedValue,"",-1);

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
            val[1].TrimStart('0');
            val[2].TrimStart('0');
            try
            {
                erg[0] = Convert.ToInt32(val[1]);
                erg[1] = Convert.ToInt32(val[2]);
            }
            //Fehler in Name von Regalfach -> Falsches Format
            catch
            {
                MetroFramework.MetroMessageBox.Show(this,"Ungültiger Name des Regalfachs", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return erg;
        }

        private void ZurueckButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PaketeinlagernButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var pakethinzufuegen = new PaketHinzufuegen())
                {
                    string key = RegaleinsichtGrid.CurrentCell.RowIndex.ToString() + "-" + RegaleinsichtGrid.CurrentCell.ColumnIndex.ToString();

                    pakethinzufuegen.Besitzer = this;
                    if (_regalfachIDMap.ContainsKey(key))
                    {
                        pakethinzufuegen.RegalfachID = _regalfachIDMap[key];
                        pakethinzufuegen.ShowDialog();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Es wurde kein Regalfach ausgewählt", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Es exisitiert kein Regalfach!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PaketauslagernButton_Click(object sender, EventArgs e)
        {
            try
            {
                string key = RegaleinsichtGrid.CurrentCell.RowIndex.ToString() + "-" + RegaleinsichtGrid.CurrentCell.ColumnIndex.ToString();

                if (_regalfachIDMap.ContainsKey(key))
                {
                    if (RegaleinsichtGrid.CurrentCell.Style.BackColor == Color.LightPink)
                    {
                        using (var paketentfernen = new PaketEntfernen())
                        {
                            paketentfernen.Owner = this;
                            paketentfernen.RegalfachID = _regalfachIDMap[key];
                            paketentfernen.ShowDialog();
                        }
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Das ausgewählte Regalfach besitzt keine Pakete", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Es wurde kein Regalfach ausgewählt", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Es existiert kein Regalfach!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AktualisierenButton_Click(object sender, EventArgs e)
        {
            AktualisierenButton.Enabled = false;
            PaketeinlagernButton.Enabled = true;
            PaketauslagernButton.Enabled = true;
            LagerCombobox.Enabled = true;
            RegalCombobox.Enabled = true;

            LadeDatenLabel.Visible = false;

            _dictLager = DB.SqlStatements.HoleLager();

            if (_dictLager.Values.Count > 0)
            {
                LagerCombobox.DataSource = new BindingSource().DataSource = _dictLager.Values.ToArray();
                LagerCombobox.SelectedIndex = 0;
            }
            else
                LagerCombobox.SelectedIndex = -1;

            UpdateComboboxRegal();
        }
    }
}
