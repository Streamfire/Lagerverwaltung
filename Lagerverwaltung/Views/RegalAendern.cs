using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class RegalAendern : MetroFramework.Forms.MetroForm
    {
        private Dictionary<long, Model.LagerModel> _dictLager;
        private Dictionary<long, Model.RegalModel> _dictRegal;
        private Dictionary<long, Model.RegalfachModel> _dictRegalfach;
        private Dictionary<long, Model.PaketModel> _dictPaket;

        public RegalAendern()
        {
            InitializeComponent();
        }

        private void RegalAendern_Entfernen_Load(object sender, EventArgs e)
        {
            LagerCombobox.ValueMember = "Lager_ID";
            LagerCombobox.DisplayMember = "Name";

            RegalCombobox.ValueMember = "Regal_ID";
            RegalCombobox.DisplayMember = "Name";

            _dictLager = DB.SqlStatements.HoleLager();

            if (_dictLager.Values.Count > 0)
            {
                LagerCombobox.DataSource = new BindingSource().DataSource = _dictLager.Values.ToArray();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Bitte erstellen Sie zuerst ein Lager!", "Kein Lager gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }

        private void LagerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LagerCombobox.SelectedIndex >= 0)
            {
                _dictRegal = DB.SqlStatements.HoleRegal(-1, ((Model.LagerModel)LagerCombobox.SelectedItem).Lager_ID, "", -1);

                if (_dictRegal.Values.Count > 0)
                    RegalCombobox.DataSource = new BindingSource().DataSource = _dictRegal.Values.ToArray();
            }

            if (RegalCombobox.Items.Count <= 0 || LagerCombobox.SelectedIndex < 0)
            {
                RegalCombobox.SelectedIndex = -1;
            }
            else
            {
                RegalCombobox.SelectedIndex = 0;
            }
        }

        private void UpdateComboboxRegal(int index)
        {
            _dictRegal = DB.SqlStatements.HoleRegal(-1, ((Model.LagerModel)LagerCombobox.SelectedItem).Lager_ID, "", -1);
            RegalCombobox.DataSource = new BindingSource().DataSource = _dictRegal.Values.ToArray();
            RegalCombobox.SelectedIndex = index;
            
        }

        private void RegalCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegalCombobox.SelectedIndex >= 0)
            {
                NameTextbox.Text = ((Model.RegalModel)RegalCombobox.SelectedItem).Name;
            }
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AendernButton_Click(object sender, EventArgs e)
        {
            if (RegalCombobox.Items.Count > 0)
            {
                if (NameTextbox.Text.Length != 0)
                {
                    string name = NameTextbox.Text;
                    name = name.Replace("-", "");
                    DB.SqlStatements.UpdateRegal(((Model.RegalModel)RegalCombobox.SelectedItem).Regal_ID, name, null, null, null, null, null, null, null, null);
                    MetroFramework.MetroMessageBox.Show(this, String.Format("Das Regal wurde erfolgreich in \"{0}\" geändert!", name), "Regalname geändert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateComboboxRegal(RegalCombobox.SelectedIndex);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Bitte geben Sie einen neuen Namen für das Regal ein!", "Regalname ist leer!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Bitte wählen Sie ein Regal aus, dessen Name Sie ändern wollen!", "Kein Regal ausgewählt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EntfernenButton_Click(object sender, EventArgs e)
        {
            if (RegalCombobox.Items.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, String.Format("Wollen sie das ausgewählte Regal \"{0}\" wirklich entfernen?", ((Model.RegalModel)RegalCombobox.SelectedItem).Name), "Lager entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    long regalID = ((Model.RegalModel)RegalCombobox.SelectedItem).Regal_ID;
                    string regalname = ((Model.RegalModel)RegalCombobox.SelectedItem).Name;

                    //Alle Daten (Regalfächer,Pakete) besorgen
                    _dictRegalfach = DB.SqlStatements.HoleRegalfach(-1,regalID,"",-1);

                    foreach (Model.RegalfachModel regalfach in _dictRegalfach.Values)
                    {
                        _dictPaket = DB.SqlStatements.HolePaket(-1,regalfach.Regalfach_ID,"",-1);

                        if (_dictPaket.Count > 0)
                        {
                            foreach (Model.PaketModel paket in _dictPaket.Values)
                            {
                                DB.SqlStatements.LoeschePaket(paket.Paket_ID);
                            }
                        }

                        DB.SqlStatements.LoescheRegalfach(regalfach.Regalfach_ID);
                    }

                    DB.SqlStatements.LoescheRegal(regalID);
                    MetroFramework.MetroMessageBox.Show(this, String.Format("Das Regal {0} wurde erfolgreich entfernt!", regalname), "Regal entfernt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LagerCombobox_SelectedIndexChanged(null, null);
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Bitte wählen Sie ein Regal aus, dass Sie entfernen möchten!", "Kein Regal ausgewählt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}