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
		public RegsisterNewClient()
		{
			InitializeComponent();
			db = new DevDbContext();
		}

		private void mealsBox_Enter(object sender, EventArgs e)
		{

		}

		private void nameBox_TextChanged(object sender, EventArgs e)
		{

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
			else if (!oneMealRadioButton.Checked && !threeMealRadioButton.Checked && !twoMealRadioButton.Checked) {MessageBox.Show("choose a subscription type!"); }
			else
			{
				Customer newCustomer = new Customer();
				newCustomer.Name = nameBox.Text;
				newCustomer.PhoneNumber = phoneBox.Text;
				newCustomer.SubscriptionCount = 0;
				if (oneMealRadioButton.Checked)
				{
					newCustomer.MealId = 1;
					newCustomer.BreakfastCounter = 0;
					newCustomer.LunchCounter = 22;
					newCustomer.DinnerCounter = 0;
				}
				else if (twoMealRadioButton.Checked) {
					newCustomer.MealId = 2;
					newCustomer.BreakfastCounter = 22;
					newCustomer.LunchCounter = 22;
					newCustomer.DinnerCounter = 0;
				}
				else if (threeMealRadioButton.Checked)
				{
					newCustomer.MealId = 3;
					newCustomer.BreakfastCounter = 22;
					newCustomer.LunchCounter = 22;
					newCustomer.DinnerCounter = 22;
				}

				try
				{
					db.Customers.Add(newCustomer);
					db.SaveChanges();
					MessageBox.Show("تم تسجيل العميل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				catch(Exception ex)
				{
					
					MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				
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
	}
}
