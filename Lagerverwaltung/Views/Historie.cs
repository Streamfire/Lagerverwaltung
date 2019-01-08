using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Historie : MetroFramework.Forms.MetroForm
    {
        private PaginationResult<HistorieModel> paging;

        private Dictionary<long, HistorieModel> _dict;
        private List<HistorieModel> _result = new List<HistorieModel>();
        private BindingSource source;

        public Historie()
        {
            InitializeComponent();
            DB.SqlStatements.DatabaseChanged += DataChanged;
            SucheTextBox.Enabled = false;
            SucheTextBox.Text = "Suche deaktiviert, da Probleme wenn TextChanged-Event zu schnell kommt!";
            LadeDatenAsync();


            //Hab nur das hier eingefügt, nicht dass Schubi fragt, ob das mit dem Zeige nur mich funktioniert
            CustomCheckbox.Visible = false;
        }

        private void SchließenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataChanged(object sender, EventArgs e)
        {
            var type = (DB.SqlStatements.ModeltypEnum)sender;
            if (type == DB.SqlStatements.ModeltypEnum.HistorieModel)
            {
                AktualisierenButton.Enabled = true;
            }
        }

        private async void LadeDatenAsync()
        {
            paging = await Task.Run(() => DB.SqlStatements.HoleHistorieSeite());
            _dict = paging.List.ToDictionary(row => row.Log_ID, row => row);
            UpdateDataGridView();
        }

        private void UpdateDataGridView()//List<HistorieModel> list = null)
        {
            if (_dict.Count == 0)
            {
                LadeDatenLabel.Text = "Keine Daten vorhanden!";
                LadeDatenProgressspinner.Hide();
                return;
            }

            source = new BindingSource { DataSource = _dict.Values };
            HistorieGrid.DataSource = source;
            HistorieGrid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

            if (paging.HasNext)
            {
                paging = paging.Next();
                foreach (var p in paging.List)
                {
                    _dict.Add(p.Log_ID, p);
                }
                LademehrButton.Enabled = true;
            }
            PanelHelper.Hide();
        }

        private void AktualisierenButton_Click(object sender, EventArgs e)
        {
            AktualisierenButton.Enabled = false;
            LadeDatenAsync();
        }

        private void LademehrButton_Click(object sender, EventArgs e)
        {
            LademehrButton.Enabled = false;
            UpdateDataGridView();
        }

        private void CustomCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // lade erneut, aber nur mich
            throw new NotImplementedException();
        }
    }
}
