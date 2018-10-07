using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
	public partial class Login : Form
	{

		#region ctor
		public Login()
		{
			InitializeComponent();
		}
		#endregion

		#region public
		/// <summary>
		/// Get Methode um zu bestimmen ob der Nutzer beim Login richtig lag.
		/// </summary>
		public bool Adminuser { get => _adminuser; }


		#endregion

		#region private
		//Login Button gedrückt
		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text==_username&&textBox2.Text==_userpass)
			{
				_adminuser = true;
			}
			else
			{
				_adminuser = false;
			}
		}

		/// <summary>
		/// Enter gedrückt(nach eingabe in einer der Textboxen)
		/// </summary>
		private void CheckEnterKey(object sender, EventArgs e)
		{
			if (textBox1.Text == _username && textBox2.Text == _userpass)
			{
				_adminuser = true;
			}
			else
			{
				_adminuser = false;
			}
		}

		private string _username="admin";
		private string _userpass = "admin";
		private bool _adminuser = false;

		
		#endregion



	}
}
