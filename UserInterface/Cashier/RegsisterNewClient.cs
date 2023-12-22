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
	public partial class RegsisterNewClient : Form
	{
		private readonly DevDbContext db;
		private Customer? oldCustomer;
		public RegsisterNewClient(Customer? _oldCustomer)
		{

			InitializeComponent();
			db = new DevDbContext();

			if (_oldCustomer != null)
			{
				fillData(_oldCustomer);
				oldCustomer = _oldCustomer;
			}
		}


		private void phoneBox_TextChanged(object sender, EventArgs e)
		{
			phoneBox.MaxLength = 11;
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			if (phoneBox.Text == "" || nameBox.Text == "")
			{

				MessageBox.Show("Cannot leave phone or name fields empty!");
			}
			else if (!oneMealRadioButton.Checked && !threeMealRadioButton.Checked && !twoMealRadioButton.Checked) { MessageBox.Show("choose a subscription type!"); }
			else
			{
				if (oldCustomer != null)
				{
					oldCustomer.SubscriptionCount += 1;
					adjustCustomer(oldCustomer, true);
				}
				else
				{
					Customer newCustomer = new Customer();
					newCustomer.SubscriptionCount = 0;
					adjustCustomer(newCustomer, false);
				}



			}
		}

		private void fillData(Customer oldCustomer)
		{
			nameBox.Text = oldCustomer.Name;
			phoneBox.Text = oldCustomer.PhoneNumber;
			switch (oldCustomer.MealId)
			{
				case 1:
					oneMealRadioButton.Checked = true; break;
				case 2:
					twoMealRadioButton.Checked = true; break;
				case 3:
					threeMealRadioButton.Checked = true; break;
			}
		}

		private void adjustCustomer(Customer customer, bool isOld)
		{
			customer.Name = nameBox.Text;
			customer.PhoneNumber = phoneBox.Text;

			if (oneMealRadioButton.Checked)
			{
				customer.MealId = 1;
				customer.BreakfastCounter = 0;
				customer.LunchCounter = 22;
				customer.DinnerCounter = 0;
			}
			else if (twoMealRadioButton.Checked)
			{
				customer.MealId = 2;
				customer.BreakfastCounter = 22;
				customer.LunchCounter = 22;
				customer.DinnerCounter = 0;
			}
			else if (threeMealRadioButton.Checked)
			{
				customer.MealId = 3;
				customer.BreakfastCounter = 22;
				customer.LunchCounter = 22;
				customer.DinnerCounter = 22;
			}

			try
			{
				if (isOld)
				{
					db.Customers.Update(customer);
				}
				else
				{
					db.Customers.Add(customer);
				}
				db.SaveChanges();

				MessageBox.Show(isOld ? "تم تحديث العميل بنجاح" : "تم تسجيل العميل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch
			{

				MessageBox.Show("رقم الهاتف مسجل من قبل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}

		private void phoneLabel_Click(object sender, EventArgs e)
		{

		}

		private void oneMealRadioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void twoMealRadioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void threeMealRadioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Not Allow digits and symbols

			if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow only digits, backspace, delete key
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
			{
				e.Handled = true;
			}
		}

		private void RegsisterNewClient_FormClosing(object sender, FormClosingEventArgs e)
		{
			var SearchCust = new SearchCustomer();
			SearchCust.Show();
		}

		private void RegsisterNewClient_Load(object sender, EventArgs e)
		{
			KeyPreview = true;
		}

		private void RegsisterNewClient_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				registerButton.PerformClick();
			}
		}
	}
}
