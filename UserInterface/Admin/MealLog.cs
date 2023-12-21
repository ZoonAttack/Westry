
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

namespace Westry
{
	public partial class MealLog : Form
	{

		public MealLog()
		{
			InitializeComponent();
			LogDataGridView.ReadOnly = true;
		}

		private void pdfButton_Click(object sender, EventArgs e)
		{
			//TO DO: print pdf *itextsharp ?

		}

		private void Log_Load(object sender, EventArgs e)
		{
			LogDataGridView.DataBindings.Clear();
			var dt = Utility.db.MealLogs.ToList();
			LogDataGridView.DataSource = Utility.ToDataTable(dt);
		}

		private void LogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
