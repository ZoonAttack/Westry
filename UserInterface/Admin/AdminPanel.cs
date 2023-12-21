using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Westry.ManagerForm;
using Westry.Models;

namespace Westry
{
	public partial class AdminPanel : Form
	{
		DevDbContext db;
		public AdminPanel()
		{
			InitializeComponent();
			cashierInfoDataGridView.ReadOnly = true;
			db = new DevDbContext();
		}

		private void deleteCashierButton_Click(object sender, EventArgs e)
		{
			DeleteCashierPage deleteCashierPage = new DeleteCashierPage();
			deleteCashierPage.Show();
			this.Close();
		}

		private void addCashierButton_Click(object sender, EventArgs e)
		{
			RegisterNewCashier addCashierPage = new RegisterNewCashier();
			addCashierPage.Show();
			this.Close();
		}

		private void viewDailyButton_Click(object sender, EventArgs e)
		{
			MealLog log = new MealLog();
			log.Show();

		}

		private void viewClientsButton_Click(object sender, EventArgs e)
		{
			ViewClients clients = new ViewClients();
			clients.Show();
			this.Close();
		}

		private void cashierInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
		{
			Manager.ManagerInstance?.CloseApp();
		}
		private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
		{
			Manager.ManagerInstance?.CloseApp();
		}

		private void AdminPanel_Load(object sender, EventArgs e)
		{
			cashierInfoDataGridView.DataBindings.Clear();
			var dt = db.Cashiers.ToList();
			cashierInfoDataGridView.DataSource = Utility.ToDataTable(dt);
		}

	}
}
