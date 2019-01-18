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

                /*
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
                */



                /*
                 * @Martin 
                 * Hab hier das mal mit try-catch noch gemacht, weil eine FormatException auftritt, wenn man Sonderzeichen eingibt, das ist nur für die Präsi jetzt, kannst du also dann ändern. 
                 * Es treten übrigens komischerweise auch OverflowExceptions auf, wenn die Werte zu groß sind, obwohl das ja glaube ich das ValidateData machen sollte.
                 * Außerdem musste ich die Variablen vor dem try-catch deklarieren, weil dann der Compiler rumgemeckert hat, da die ja gleich darunter evtl., falls das try-catch fehlschlägt, nie deklariert werden
                 * -Benjamin
                 */

                //Die Variable verhindert, dass sich das Fenster bei falscher Eingabe schließt. Hab die weiter unten verwendet, bei dem close()
                bool success = true;

                short spalten = 0;
                short zeilen = 0;
                float regalH = 0;
                float regalB = 0;
                float regalL = 0;
                float wandH = 0;
                float wandV = 0;
                float fachH = 0;
                float fachB = 0;
                float fachL = 0;

                try
                {
                    spalten = Convert.ToInt16(SpaltenTextbox.Text);
                    zeilen = Convert.ToInt16(ZeilenTextbox.Text);
                    regalH = Convert.ToSingle(RegalhoeheTextbox.Text);
                    regalB = Convert.ToSingle(RegalbreiteTextbox.Text);
                    regalL = Convert.ToSingle(RegallaengeTextbox.Text);
                    wandH = Convert.ToSingle(StaerkeH.Text);
                    wandV = Convert.ToSingle(StaerkeV.Text);
                    fachH = Convert.ToSingle(FachhoeheTextbox.Text);
                    fachB = Convert.ToSingle(FachbreiteTextbox.Text);
                    fachL = Convert.ToSingle(FachlaengeTextbox.Text);
                }
                catch (FormatException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Falsches Eingabeformat! Bitte geben sie bei den Maßen und Anzahl der Spalten/Zahlen nur Ziffern ein!", "Regal nicht erstellt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    success = false;
                }
                catch (OverflowException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Eingabe zu großer Zahlen! Bitte geben sie bei der Anzahl der Spalten/Zahlen nur Zahlen ein bis 32767 und bei den Maßen nur bis 340282300000000000000000000000000000000 ein!", "Regal nicht erstellt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    success = false;
                }

                /* Hier endet was ich in diesem Block verändert habe
                 * Das Original ist über diesem Block in einem Kommentar
                 */


                if (Controller.RegalHinzufuegenController.ValidateGroesse(zeilen, spalten, regalH, regalB, regalL, fachH, fachB, fachL, wandH, wandV) /*Hab nur das folgende noch eingefügt ->*/ && success == true)
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

                        //Das ist was vorher hier stand
                        //Close();

                        if (success == true)
                        {
                            Close();
                        }



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
