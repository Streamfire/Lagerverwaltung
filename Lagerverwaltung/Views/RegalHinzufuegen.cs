using Lagerverwaltung.Model;
using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class RegalHinzufügen : Form
    {
        public RegalHinzufügen()
        {
            InitializeComponent();
            comboBoxAuswahlLager.ValueMember = "LagerID";
            comboBoxAuswahlLager.DisplayMember = "Name";

            comboBoxAuswahlLager.DataSource = new BindingSource(Model.Lager.HoleListe.Values, null);

        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int regalID;

                if ((regalID = DB.RegalSQL.ErstelleRegal(regalname,
                                             (short)((Lager)comboBoxAuswahlLager.SelectedItem).LagerID,
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
                            if (DB.RegalfachSQL.ErstelleRegalfach(String.Format("{0}-{1}-{2}", regalname, s, z),
                                                                 (short)regalID,
                                                                 "",
                                                                 Convert.ToSingle(textBoxRegalfachHoehe.Text),
                                                                 Convert.ToSingle(textBoxRegalfachBreite.Text),
                                                                 Convert.ToSingle(textBoxRegalfachLaenge.Text)) == false)
                            {
                                MessageBox.Show("Der Datensatz für das Regalfach konnte nicht hinzugefügt werden", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    //NL für Anzeige der Regale
                    DB.RegalSQL.HoleRegal(regalID);
                    DB.RegalfachSQL.HoleLastXRegalfach(zeilen * spalten);
                    Dashboard.Verwaltung.UpdateForm(Model.Lager.HoleListe);



                }//END IF DB erfolgreich

                //Datensatz konnte nicht gespeichert werden
                else
                {
                    MessageBox.Show("Der Datensatz für das Regal konnte nicht hinzugefügt werden", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }

            //Validierung fehlgeschlagen
            else
            {
                MessageBox.Show("Bitte Überprüfen sie das eingegebene Format der Daten", "Fehler beim Hinzufügen des Regals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


			//Dashboard.Verwaltung.UpdateForm(Model.Lager.HoleListe);
			this.Close();
		}

        private void RegalHinzufügen_Load(object sender, EventArgs e)
        {

        }
    }
}
