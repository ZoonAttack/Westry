using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Westry.ManagerForm
{
	public partial class Manager : Form
	{
		public static Manager? ManagerInstance;
		public Manager()
		{
			ManagerInstance = this;

			WindowState = FormWindowState.Minimized;
			ShowInTaskbar = false;
			Visible = false;

			InitializeComponent();

			var loginPage = new LoginPage();
			loginPage.Show();
		}


		public void closeapp()
		{
			Application.Exit();
		}
	}
}
