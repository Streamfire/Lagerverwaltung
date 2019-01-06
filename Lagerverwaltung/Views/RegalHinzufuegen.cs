using Lagerverwaltung.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class RegalHinzufügen : Form
    {
        private Dictionary<long, Model.LagerModel> _dictLager;

        public RegalHinzufügen()
        {
            InitializeComponent();
        }

        private void RegalHinzufügen_Load(object sender, EventArgs e)
        {
            //TODO: Später in der Verwaltung schon kontrollieren, ob überhaupt ein Lager existiert

            comboBoxAuswahlLager.ValueMember = "Lager_ID";
            comboBoxAuswahlLager.DisplayMember = "Name";

            _dictLager = DB.SqlStatements.HoleLager();

            if (_dictLager.Values.Count > 0)
            {
                comboBoxAuswahlLager.DataSource = new BindingSource().DataSource = _dictLager.Values.ToArray();
            }
            else
            {
                MessageBox.Show("Bitte erstellen Sie zuerst ein Lager, bevor sie ein Regal hinzufügen!", "Kein Lager gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void ButtonRegalHinzufuegen_Click(object sender, EventArgs e)
		{
            if (Controller.RegalHinzufuegenController.ValidateData(textBoxRegalName.Text, textBoxZeilen.Text, textBoxSpalten.Text, textBoxRegalHoehe.Text, textBoxRegalBreite.Text,
                                                                    textBoxRegalLaenge.Text, textBoxRegalfachHoehe.Text, textBoxRegalfachBreite.Text, textBoxRegalfachLaenge.Text,
                                                                    textBoxWandStaerkeH.Text, textBoxWandStaerkeV.Text))
            //Validierung erfolgreich
            {
                short spalten = Convert.ToInt16(textBoxSpalten.Text);
                short zeilen = Convert.ToInt16(textBoxZeilen.Text);
                string regalname = textBoxRegalName.Text;
                long regalID;

                if ((regalID = DB.SqlStatements.ErstelleRegal(regalname,
                                                            ((LagerModel)comboBoxAuswahlLager.SelectedItem).Lager_ID,
                                                            spalten,
                                                            zeilen,
                                                            Convert.ToSingle(textBoxRegalHoehe.Text),
                                                            Convert.ToSingle(textBoxRegalBreite.Text),
                                                            Convert.ToSingle(textBoxRegalLaenge.Text),
                                                            Convert.ToSingle(textBoxWandStaerkeH.Text),
                                                            Convert.ToSingle(textBoxWandStaerkeV.Text))) > 0)

                //Datensatz wurde erfolgreich in die DB gespeichert
                {

                    //Regalfächer hinzufügen
                    for (int z = 1; z <= zeilen; z++)
                    {
                        for (int s = 1; s <= spalten; s++)
                        {
                            //Name des Regalfachs: Regalname - Spalte - Zeile
                            DB.SqlStatements.ErstelleRegalfach( String.Format("{0}-{1}-{2}", regalname, s, z),
                                                                regalID,
                                                                "",
                                                                Convert.ToSingle(textBoxRegalfachHoehe.Text),
                                                                Convert.ToSingle(textBoxRegalfachBreite.Text),
                                                                Convert.ToSingle(textBoxRegalfachLaenge.Text));
                        }
                    }

                    //NL für Anzeige der Regale
                    //TODO: Bei Anpassung der Verwaltung an die SQLStatements anpassen bzw. entfernen
                    DB.RegalSQL.HoleRegal((int)regalID);
                    DB.RegalfachSQL.HoleLastXRegalfach(zeilen * spalten);
                    Dashboard.Verwaltung.UpdateForm(Model.Lager.HoleListe);



                }//END IF DB erfolgreich

                //Datensatz konnte nicht gespeichert werden
                else
                {
                    MessageBox.Show("Der Datensatz für das Regal konnte nicht hinzugefügt werden", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //Validierung fehlgeschlagen
            else
            {
                MessageBox.Show("Bitte Überprüfen sie das eingegebene Format der Daten", "Fehler beim Hinzufügen des Regals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

			Close();
		}
    }
}
