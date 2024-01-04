using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Westry.ManagerForm;
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

				MessageBox.Show("الرجاء ادخال اسم العميل ورقم الهاتف");
			}

			else if (mealTypeComboBox.SelectedIndex == -1) 
			{ MessageBox.Show("الرجاء اختيار نوع الاشتراك"); }
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
		}

		private void adjustCustomer(Customer customer, bool isOld)
		{
			customer.Name = nameBox.Text.Trim();
			customer.PhoneNumber = phoneBox.Text.Trim();
			Meal? type = mealTypeComboBox.SelectedItem as Meal;
			customer.MealId = type.MealId;

			customer.BreakfastCounter = 0;
			customer.LunchCounter = 0;
			customer.DinnerCounter = 0;

			if ((bool)type.hasBreakfast)
			{
				customer.BreakfastCounter = 22;
			}
			if ((bool)type.hasLunch)
			{
				customer.LunchCounter = 22;
			}
			if ((bool)type.hasDinner)
			{
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
					customer.createdBy = Manager.currentLoggedCashier.UserName;
					db.Customers.Add(customer);
				}
				db.SaveChanges();

				MessageBox.Show(isOld ? "تم تحديث العميل بنجاح" : "تم تسجيل العميل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch
			{

				MessageBox.Show("رقم الهاتف مسجل من قبل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();

			}

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
			var mealTypes = db.Meals.ToList();
			mealTypeComboBox.DisplayMember = "Name";
			mealTypeComboBox.DataSource = mealTypes;
			mealTypeComboBox.SelectedIndex = -1;
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
