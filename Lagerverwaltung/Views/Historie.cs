using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Historie : Form
	{
        private ReadOnlyDictionary<ulong,Model.Historie> readonly_dict;
        //private List<Model.Historie> _list = new List<Model.Historie>();
        private List<Model.Historie> _result = new List<Model.Historie>();
        private BindingSource source = new BindingSource();

		public Historie()
		{
			InitializeComponent();

            readonly_dict = Model.Historie.HoleListe;
            //GenerateList();
            UpdateDataGridView();

        }

        /*
        private void GenerateList()
        {
            foreach (var item in readonly_dict.Values)
            {
                _list.Add(item);
            }
        }
        */

		/// <summary>
		/// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HistorieFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Historie = null;
		}

        private void UpdateDataGridView(List<Model.Historie> list = null)
        {
            if(list==null)
            {
                source.DataSource = readonly_dict.Values;
            }
            else
            {
                source.DataSource = list;
            }
            dataGridView1.DataSource = source;
        }

        private void TextBoxSearch_TextChanged(object sender, System.EventArgs e)
        {
            if(textBoxSearch.TextLength >=1)
            {
                var expression = textBoxSearch.Text.ToLower();
                ulong num=0;
                _result.Clear();
                if(ulong.TryParse(expression,out num))
                {
                    foreach(var item in readonly_dict.Values)
                    {
                        // Contains noch nicht ausgereift!
                        if(item.LogID == num | item.UserID == num | item.LogText.Contains(expression))
                        {
                            _result.Add(item);
                        }
                    }
                }
                else
                {
                    foreach(var item in readonly_dict.Values)
                    {
                        bool test = item.LogText.ToLower().Contains(expression.ToLower());
                        if (test)
                        {
                            _result.Add(item);
                        }
                    }
                }
                UpdateDataGridView(_result);
            }
            else
            {
                UpdateDataGridView();
            }
        }
    }
}
