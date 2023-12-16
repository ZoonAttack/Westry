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
			if (nameBox.Text == "" || passwordBox.Text == "") { MessageBox.Show("enter a valid username and password"); }
			else
			{


				foreach (Cashier cashier in db.Cashiers.ToList())
				{
					if (cashier.UserName == nameBox.Text && cashier.Password == passwordBox.Text)
					{
						isCashier = true;
					}
				}

				foreach (Admin admin in db.Admins.ToList())
				{
					if (admin.UserName == nameBox.Text && admin.Password == passwordBox.Text)
					{
						isAdmin = true;
					}
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

					MessageBox.Show("Wrong username or password!");
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

		}

		private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
	}
}