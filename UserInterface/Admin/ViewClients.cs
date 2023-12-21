
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
using Westry.Models;

namespace Westry
{
	public partial class ViewClients : Form
	{
		DevDbContext db;
		public ViewClients()
		{
			InitializeComponent();
			ClientsDataGridView.ReadOnly = true;
			db = new DevDbContext();
		}

		private void ClientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ViewClients_Load(object sender, EventArgs e)
		{
			ClientsDataGridView.DataBindings.Clear();
			var dt = Utility.db.Customers.ToList();
			ClientsDataGridView.DataSource = Utility.ToDataTable(dt);
		}
		private void ViewClients_FormClosed(object sender, FormClosedEventArgs e)
		{
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.Show();
		}
	}
}
