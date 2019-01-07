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
                MetroFramework.MetroMessageBox.Show(this, "Bitte erstellen Sie zuerst ein Lager, bevor sie ein Regal hinzufügen!", "Kein Lager gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AendernButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EntfernenButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LagerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LagerCombobox.SelectedIndex >= 0)
            {
                _dictRegal = DB.SqlStatements.HoleRegal(-1, ((Model.LagerModel)LagerCombobox.SelectedItem).Lager_ID, "", -1);
                RegalCombobox.DataSource = new BindingSource().DataSource = _dictRegal.Values.ToArray();
            }

            if (RegalCombobox.Items.Count <= 0 || LagerCombobox.SelectedIndex < 0)
            {
                RegalCombobox.SelectedIndex = -1;
            }
            else
                RegalCombobox.SelectedIndex = 0;
        }
    }
}