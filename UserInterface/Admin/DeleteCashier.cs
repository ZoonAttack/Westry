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
	public partial class DeleteCashierPage : Form
	{
		private readonly DevDbContext _dbContext;

		public DeleteCashierPage()
		{
			InitializeComponent();
			_dbContext = new DevDbContext();
		}

		private void deleteCashierButton_Click(object sender, EventArgs e)
		{
			if (cashierNameTextBox.Text == "")
			{
				
				MessageBox.Show("الرجاء ادخال اسم الحساب المراد حذفه");
			}
			else
			{
				Cashier? oldCashier = _dbContext.Cashiers.FirstOrDefault(u => u.UserName == cashierNameTextBox.Text);
				if (oldCashier != null)
				{
					_dbContext.Cashiers.Remove(oldCashier);
					MessageBox.Show($"تم حذف الكاشير: {cashierNameTextBox.Text}");
					_dbContext.SaveChanges();
					this.Close();
				}
				else
				{
					MessageBox.Show("هذا الحساب غير موجود");
				}
			}
		}

		private void cashierNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void DeleteCashierPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.Show();
		}

		private void DeleteCashierPage_Load(object sender, EventArgs e)
		{

		}
	}
}
