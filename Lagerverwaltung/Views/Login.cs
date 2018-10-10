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
		private void Button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == _username && textBox2.Text == _userpass)
			{
				_adminuser = true;
				this.Hide();
			}
			else
			{
				label4.Text = "Nutzername oder Passwort falsch.";
				_adminuser = false;
			}
		}

		/// <summary>
		/// Enter gedrückt(nach eingabe in einer der Textboxen)
		/// </summary>
		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			label4.Text = "";
			if (e.KeyCode == Keys.Enter)
			{
				if (textBox1.Text == _username && textBox2.Text == _userpass)
				{
					_adminuser = true;
					this.Hide();
				}
				else
				{
					label4.Text = "Nutzername oder Passwort falsch.";
					_adminuser = false;
				}
			}
		}

		private string _username="admin";
		private string _userpass = "admin";
		private bool _adminuser = false;




		#endregion

		private void Button2_Click(object sender, EventArgs e)
		{
			_adminuser = false;
			this.Hide();
		}
	}
}
