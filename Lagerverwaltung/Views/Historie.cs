using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Historie : Form
	{
        private ReadOnlyDictionary<ulong,Model.Historie> readonly_dict;
        private List<Model.Historie> _list = new List<Model.Historie>();
        private List<Model.Historie> _result = new List<Model.Historie>();
        private BindingSource source = new BindingSource();

		public Historie()
		{
			InitializeComponent();

            readonly_dict = Model.Historie.HoleListe;
            GenerateList();
            UpdateDataGridView();

        }

        private void GenerateList()
        {
            foreach (var item in readonly_dict.Values)
            {
                _list.Add(item);
            }
        }

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
                object expression = textBoxSearch.Text.ToLower();

                if(expression is ushort || expression is ulong)
                {
                    // findet nicht alle. kp wieso nicht
                    _result = _list.FindAll(x => x.LogID == (ulong)expression | x.UserID == (ushort)expression);
                }
                else if(expression is string)
                {
                    _result = _list.FindAll(s => s.LogText.ToLower().Contains(expression.ToString()));
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
