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
using System.Xml.Linq;
using Westry.ManagerForm;
using Westry.Models;

namespace Westry
{
	public partial class SearchCustomer : Form
	{

		private string clientName;
		private string clientPhoneNumber;
		private int clientPreviousSubscriptions;
		private int remainingBreakfast;
		private int remainingLunch;
		private int remainingDinner;
		private int subscriptionType;

		private readonly DevDbContext db;
		public SearchCustomer()
		{
			InitializeComponent();
			db = new DevDbContext();

		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			if (phoneBox.Text == "") { MessageBox.Show("الرجاء ادخال رقم الهاتف"); }
			else
			{
				Customer? foundCustomer = db.Customers.SingleOrDefault(u => u.PhoneNumber == phoneBox.Text);

				if (foundCustomer != null)
				{
					if (foundCustomer.LunchCounter <= 0 && foundCustomer.DinnerCounter <= 0 && foundCustomer.BreakfastCounter <= 0)
					{
						DialogResult value = MessageBox.Show("العميل لم يعد لديه وجبات متبقيه\nهل تريد تجديد الاشتراك؟", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
						if (value == DialogResult.OK)
						{
							RegsisterNewClient form = new RegsisterNewClient(foundCustomer);
							form.Show();
							Hide();
							Close();
						}
					}
					else
					{
						RecordOrder recordOrderPage = new RecordOrder(foundCustomer);
						recordOrderPage.Show();
						Hide();
						Close();
					}
				}
				else
				{
					MessageBox.Show("لم يتم العثور على عميل مسجل برقم الهاتف هذا", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}




			}
		}

		private void nameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void phoneBox_TextChanged(object sender, EventArgs e)
		{
			phoneBox.MaxLength = 11;
		}

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}

		private void phoneLabel_Click(object sender, EventArgs e)
		{

		}

		private void newUserButton_Click(object sender, EventArgs e)
		{
			RegsisterNewClient UserRegistrationPage = new RegsisterNewClient(null);
			UserRegistrationPage.Show();
			Hide();
			Close();
		}

		private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow only digits, backspace, delete 
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
			{
				e.Handled = true;
			}
		}

		private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Do not Allow digits and symbols

			if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
			{
				e.Handled = true;
			}
		}


		private void SearchCustomer_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				searchButton.PerformClick();
			}
		}

		private void SearchCustomer_FormClosed(object sender, FormClosedEventArgs e)
		{
			Manager.ManagerInstance.CloseApp();
		}

		private void SearchCustomer_Load(object sender, EventArgs e)
		{
			KeyPreview = true;
		}
	}
}
