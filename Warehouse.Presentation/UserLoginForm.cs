using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Service;

namespace Warehouse.Presentation
{
	public partial class UserLoginForm : Form
	{
		private UserService _serviceUser;

		public UserLoginForm()
		{
			InitializeComponent();
			_serviceUser = new UserService();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!ValidateData())
			{
				return;
			}
			AppData.LoggedUserID = 1;// _serviceUser.Login(txtUsername.Text, txtPassword.Text);
			if (AppData.LoggedUserID != -1)
			{
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Login Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateData()
		{
			Control[] controls = new Control[Controls.Count];
			Controls.CopyTo(controls, 0); // davasortirot tab indexebit
			//Array.Sort(controls);
			foreach (Control control in controls)
			{
				if (control is TextBox && !ValidateRequiredField(control)) return false;
			}
			return true;
		}

		private bool ValidateRequiredField(Control control)
		{
			if (IsFieldRequired(control) && control.Text.Length == 0)
			{
				MessageBox.Show($"{GetFieldName(control)} is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				control.Focus();
				return false;
			}
			return true;
		}

		//viswavlot gavitanot extention metodshi.
		private bool IsFieldRequired(Control control)
		{
			if (control.Tag != null)
			{
				string tag = control.Tag.ToString();
				string[] tokens = tag.Split('|');
				if (tokens.Length > 1 && tokens[1] == "*")
				{
					return true;
				}
			}
			return false;
		}

		private string GetFieldName(Control control)
		{
			if (control.Tag != null)
			{
				string tag = control.Tag.ToString();
				string[] tokens = tag.Split('|');
				if (tokens.Length > 0)
				{
					return tokens[0];
				}
			}
			return string.Empty;
		}
	}
}
