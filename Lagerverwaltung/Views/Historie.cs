using Lagerverwaltung.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using SqlKata.Execution;

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
            textBoxSearch.Enabled = false;
            textBoxSearch.Text = "Suche deaktiviert, da Probleme wenn TextChanged-Event zu schnell kommt!";
            LadeDatenAsync();
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

            source = new BindingSource();
            source.DataSource = _dict.Values;
            /*
            if (list==null)
            {
                source.DataSource = _dict.Values;
            }
            else
            {
                source.DataSource = list;
            }
            */
            dataGridView1.DataSource = source;
            if (!paging.HasNext)
            {
                button1.Enabled = false;
            }
            else
            {
                paging = paging.Next();
                foreach (var p in paging.List)
                {
                    _dict.Add(p.Log_ID, p);
                }
            }
            label1.Hide();
        }

        // muss eindeutig optimiert werden!
        private void TextBoxSearch_TextChanged(object sender, System.EventArgs e)
        {
            /*
            if(textBoxSearch.TextLength >=1)
            {
                var expression = textBoxSearch.Text.ToLower();
                _result.Clear();
                if (long.TryParse(expression,out long num))
                {
                    foreach(var item in _dict.Values)
                    {
                        // Contains noch nicht ausgereift!
                        if(item.Log_ID == num | item.User_ID == num | item.LogText.Contains(expression))
                        {
                            _result.Add(item);
                        }
                    }
                }
                else
                {
                    foreach(var item in _dict.Values)
                    {
                        bool test = item.LogText.ToLower().Contains(expression.ToLower());
                        if (test)
                        {
                            _result.Add(item);
                        }
                    }
                }
                //UpdateDataGridView(_result);
            }
            else
            {
                //UpdateDataGridView();
            }
            */
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
