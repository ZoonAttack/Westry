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
	public partial class RegisterNewCashier : Form
	{
		AdminPanel adminPanel;
		DevDbContext _db;
		public RegisterNewCashier()
		{
			InitializeComponent();
			_db = new DevDbContext();
			adminPanel = new AdminPanel();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			Cashier cashier = new Cashier();
			if (nameBox.Text == "" || passwordBox.Text == "")
			{

				MessageBox.Show("الرجاء ادخال اسم المستخدم وكلمة المرور");
			}
			else
			{
				cashier.UserName = nameBox.Text;
				cashier.Password = passwordBox.Text;
				_db.Cashiers.Add(cashier);
				try
				{
					_db.SaveChanges();
					MessageBox.Show($"تم اضافه الكاشير: {cashier.UserName}");
				}
				catch
				{
					MessageBox.Show("الرقم السري مسحل لكاشير من قبل");
				}
				this.Close();
			}
		}

		private void nameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void passwordBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}

		private void passwordLabel_Click(object sender, EventArgs e)
		{

		}

		private void RegisterNewCashier_FormClosed(object sender, FormClosedEventArgs e)
		{
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.Show();
		}

		private void RegisterNewCashier_Load(object sender, EventArgs e)
		{
			KeyPreview = true;
		}

		private void RegisterNewCashier_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				addButton.PerformClick();
			}
		}
	}
}
