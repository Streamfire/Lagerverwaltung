using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Historie : Form
	{
        private PaginationResult<HistorieModel> paging;

        private Dictionary<long, HistorieModel> _dict;
        private List<HistorieModel> _result = new List<HistorieModel>();
        private BindingSource source;

        public Historie()
		{
			InitializeComponent();
            DB.SqlStatements.DatabaseChanged += DataChanged;
            textBoxSearch.Enabled = false;
            textBoxSearch.Text = "Suche deaktiviert, da Probleme wenn TextChanged-Event zu schnell kommt!";
            LadeDatenAsync();
        }

        private void DataChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        public async void LadeDatenAsync()
        {
            paging = await Task.Run(() => DB.SqlStatements.HoleHistorieSeite());
            _dict = paging.List.ToDictionary(row=>row.Log_ID,row=>row);
            UpdateDataGridView();
        }

        private void UpdateDataGridView()//List<HistorieModel> list = null)
        {
            if(_dict.Count == 0)
            {
                label1.Text = "Keine Daten vorhanden!";
                return;
            }

            source = new BindingSource{ DataSource = _dict.Values };
            dataGridView1.DataSource = source;

            if(paging.HasNext)
            {
                paging = paging.Next();
                foreach (var p in paging.List)
                {
                    _dict.Add(p.Log_ID, p);
                }
                button1.Enabled = true;
            }
            label1.Hide();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            button1.Enabled = false;
            UpdateDataGridView();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            LadeDatenAsync();
        }
    }
}
