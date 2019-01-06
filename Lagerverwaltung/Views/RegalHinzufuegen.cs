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
                long regalID;
                string regalname = textBoxRegalName.Text;
                short spalten = Convert.ToInt16(textBoxSpalten.Text);
                short zeilen = Convert.ToInt16(textBoxZeilen.Text);
                float regalH = Convert.ToSingle(textBoxRegalHoehe.Text);
                float regalB = Convert.ToSingle(textBoxRegalBreite.Text);
                float regalL = Convert.ToSingle(textBoxRegalLaenge.Text);
                float wandH = Convert.ToSingle(textBoxWandStaerkeH.Text);
                float wandV = Convert.ToSingle(textBoxWandStaerkeV.Text);
                float fachH = Convert.ToSingle(textBoxRegalfachHoehe.Text);
                float fachB = Convert.ToSingle(textBoxRegalfachBreite.Text);
                float fachL = Convert.ToSingle(textBoxRegalfachLaenge.Text);



                if (Controller.RegalHinzufuegenController.ValidateGroesse(zeilen, spalten, regalH, regalB, regalL, fachH, fachB, fachL, wandH, wandV))
                {
                    regalID = DB.SqlStatements.ErstelleRegal(regalname, ((LagerModel)comboBoxAuswahlLager.SelectedItem).Lager_ID, zeilen, spalten, regalH, regalB, regalL, wandH, wandV);

                    if(regalID > 0)
                    //Datensatz wurde erfolgreich in die DB gespeichert
                    {

                        //Regalfächer hinzufügen
                        for (int z = 1; z <= zeilen; z++)
                        {
                            for (int s = 1; s <= spalten; s++)
                            {
                                //Name des Regalfachs: Regalname - Spalte - Zeile
                                DB.SqlStatements.ErstelleRegalfach(String.Format("{0}-{1}-{2}", regalname, z, s),
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

                        //Dringend Verwaltung mit SQL Statements ergänzen, sonst kann die Verwaltung nicht aktualisiert werden
                        //Dashboard.Verwaltung.UpdateForm(Model.Lager.HoleListe);

                        Close();

                    }//END IF DB erfolgreich

                    //Datensatz konnte nicht gespeichert werden
                    else
                    {
                        MessageBox.Show("Der Datensatz für das Regal konnte nicht hinzugefügt werden", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                } //END IF Validate Größe 
                else
                {
                    MessageBox.Show("Die Größen der angegebenen Fächer und Wandstärken überschreiten die Gesamtgröße des Regals.", "Fehler beim Hinzufügen des Regals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            //Validierung fehlgeschlagen
            else
            {
                MessageBox.Show("Bitte Überprüfen sie das eingegebene Format der Daten.", "Fehler beim Hinzufügen des Regals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
		}
    }
}
