using Lagerverwaltung.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class RegalHinzufuegen : MetroFramework.Forms.MetroForm
    {
        private Dictionary<long, Model.LagerModel> _dictLager;

        public RegalHinzufuegen()
        {
            InitializeComponent();
        }

        private void RegalHinzufuegen_Load(object sender, EventArgs e)
        {
            //TODO: Später in der Verwaltung schon kontrollieren, ob überhaupt ein Lager existiert

            LagerCombobox.ValueMember = "Lager_ID";
            LagerCombobox.DisplayMember = "Name";

            _dictLager = DB.SqlStatements.HoleLager();

            if (_dictLager.Values.Count > 0)
            {
                LagerCombobox.DataSource = new BindingSource().DataSource = _dictLager.Values.ToArray();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Bitte erstellen Sie zuerst ein Lager, bevor sie ein Regal hinzufügen!", "Kein Lager gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void HinzufuegenButton_Click(object sender, EventArgs e)
		{
            if (Controller.RegalHinzufuegenController.ValidateData(BezeichnungTextbox.Text, ZeilenTextbox.Text, SpaltenTextbox.Text, RegalhoeheTextbox.Text, RegalbreiteTextbox.Text,
                                                                    RegallaengeTextbox.Text, FachhoeheTextbox.Text, FachbreiteTextbox.Text, FachlaengeTextbox.Text,
                                                                    StaerkeH.Text, StaerkeV.Text))
            //Validierung erfolgreich
            {
                long regalID;
                string regalname = BezeichnungTextbox.Text;
                short spalten = Convert.ToInt16(SpaltenTextbox.Text);
                short zeilen = Convert.ToInt16(ZeilenTextbox.Text);
                float regalH = Convert.ToSingle(RegalhoeheTextbox.Text);
                float regalB = Convert.ToSingle(RegalbreiteTextbox.Text);
                float regalL = Convert.ToSingle(RegallaengeTextbox.Text);
                float wandH = Convert.ToSingle(StaerkeH.Text);
                float wandV = Convert.ToSingle(StaerkeV.Text);
                float fachH = Convert.ToSingle(FachhoeheTextbox.Text);
                float fachB = Convert.ToSingle(FachbreiteTextbox.Text);
                float fachL = Convert.ToSingle(FachlaengeTextbox.Text);



                if (Controller.RegalHinzufuegenController.ValidateGroesse(zeilen, spalten, regalH, regalB, regalL, fachH, fachB, fachL, wandH, wandV))
                {
                    regalID = DB.SqlStatements.ErstelleRegal(regalname, ((LagerModel)LagerCombobox.SelectedItem).Lager_ID, zeilen, spalten, regalH, regalB, regalL, wandH, wandV);

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
                                                                    Convert.ToSingle(FachhoeheTextbox.Text),
                                                                    Convert.ToSingle(FachbreiteTextbox.Text),
                                                                    Convert.ToSingle(FachlaengeTextbox.Text));
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
                        MetroFramework.MetroMessageBox.Show(this,"Der Datensatz für das Regal konnte nicht hinzugefügt werden", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                } //END IF Validate Größe 
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Die Größen der angegebenen Fächer und Wandstärken überschreiten die Gesamtgröße des Regals.", "Fehler beim Hinzufügen des Regals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            //Validierung fehlgeschlagen
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Bitte Überprüfen sie das eingegebene Format der Daten.", "Fehler beim Hinzufügen des Regals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
		}
    }
}
