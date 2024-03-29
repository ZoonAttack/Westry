﻿using Westry.ManagerForm;
using Westry.Models;

namespace Westry
{
	public partial class LoginPage : Form
	{

		DevDbContext db;


		bool isAdmin = false;
		bool isCashier = false;
		public LoginPage()
		{
			InitializeComponent();
			db = new DevDbContext();

		}

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (nameBox.Text == "" || passwordBox.Text == "") { MessageBox.Show("الرجاء ادخال اسم الحساب وكلمة السر"); }
			else
			{
				//Return cashier if found. If not return null this is what "SingleOrDefault" does
				//"u => " is called the LINQ operator. search it
				Cashier? loginCashier = db.Cashiers.SingleOrDefault(u => u.Password.ToLower() == passwordBox.Text);
				Admin? loginAdmin = db.Admins.SingleOrDefault(u => u.UserName.ToLower() == nameBox.Text);

				if (loginAdmin != null && loginAdmin.Password == passwordBox.Text)
				{
					isAdmin = true;
				}

				if (loginCashier != null && loginCashier.UserName == nameBox.Text)
				{
					isCashier = true;
					Manager.currentLoggedCashier = loginCashier;
					Manager.currentLoggedCashier.loggedInTime = DateTime.Now;
					Utility.db.Cashiers.Update(Manager.currentLoggedCashier);
					Utility.db.SaveChanges();
				}




				if (isAdmin)
				{
					AdminPanel adminPage = new AdminPanel();

					adminPage.Show();
					Hide();
					Close();
				}
				else if (isCashier)
				{
					SearchCustomer CashierPage = new SearchCustomer();

					CashierPage.Show();
					Hide();
					Close();
				}
				else
				{

					MessageBox.Show("اسم الحساب او كلمة السر خطأ");
				}





			}
		}

		private void nameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void passwordBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void passwordLabel_Click(object sender, EventArgs e)
		{

		}

		private void LoginPage_Load(object sender, EventArgs e)
		{
			KeyPreview = true;
		}

		private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			Manager.ManagerInstance.CloseApp();
		}

		private void LoginPage_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				loginButton.PerformClick();
			}
		}
	}
}