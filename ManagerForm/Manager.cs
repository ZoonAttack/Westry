using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Westry.Models;

namespace Westry.ManagerForm
{
	//This manager form is a hidden form that is always there
	//I created it because we dont want all the forms to be visiable at the same time
	//When the user logins and enters his form the loginpage form should close not just hide
	//so because it the main loop is at loginpage when you close it, it closes the whole program
	//so I just created this manager form to stay running all the time and it stays hidden
	//You can use it for global variabels or anything you want
	public partial class Manager : Form
	{
		public static Manager? ManagerInstance;
		public static Cashier? currentLoggedCashier;
		public Manager()
		{
			ManagerInstance = this;

			WindowState = FormWindowState.Minimized;
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			ShowInTaskbar = false;
			Visible = false;

			InitializeComponent();

			var loginPage = new LoginPage();
			loginPage.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		public void CloseApp()
		{
			//Check if only the manager form is opened
			//If its the only form opened then clsoe the program
			//This method should be called after the specific form closed
			if(Application.OpenForms.Count <= 1)
			{
				Application.Exit();
			}
		}
	}
}
