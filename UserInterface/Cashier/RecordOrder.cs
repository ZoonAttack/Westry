using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Westry.Models;
using Westry.ManagerForm;
using Westry.UserInterface.Cashier;

namespace Westry
{
	public partial class RecordOrder : Form
	{

		private string? clientName; //got from the cashierPage form
		private string? clientPhoneNumber;
		private int? clientPreviousSubscriptions;
		private int? remainingBreakfast;
		private int? remainingLunch;
		private int? remainingDinner;
		private int? subscriptionType;
		private Customer customer;
		private readonly DevDbContext db;
		bool sameCustomer = false;
		public RecordOrder(Customer FoundCustomer)
		{
			customer = FoundCustomer;
			db = new DevDbContext();

			

			InitializeComponent();
			ShowData();

			specifyBuffetLabel.Visible = false;
			specifyNotesLabel.Visible = false;
			buffetTextBox.Visible = false;
			buffetCheckBox.Visible = true;

			BFRenewBTn.Visible = false;
			LunchRenewBTN.Visible = false;
			DinnerRenewBTN.Visible = false;

			if (FoundCustomer.BreakfastCounter <= 0)
			{
				BreakfastComboBox.Enabled = false;
				if ((bool)Utility.db.Meals.Find(FoundCustomer.MealId).hasBreakfast)
				{
					BFRenewBTn.Visible = true;
				}
			}
			if (FoundCustomer.LunchCounter <= 0)
			{
				LaunchComboBox.Enabled = false;
				if ((bool)Utility.db.Meals.Find(FoundCustomer.MealId).hasLunch)
				{
					LunchRenewBTN.Visible = true;
				}
			}
			if (FoundCustomer.DinnerCounter <= 0)
			{
				DinnerComboBox.Enabled = false;
				if ((bool)Utility.db.Meals.Find(FoundCustomer.MealId).hasDinner)
				{
					DinnerRenewBTN.Visible = true;
				}
			}
		}

		private void ShowData()
		{

			// add data to labels
			nameLabel.Text = $"اسم العميل: {customer.Name}";
			phoneLabel.Text = $"رقم الهاتف: {customer.PhoneNumber}";
			subCountLabel.Text = $"عدد مرات الاشتراك السابقه: {customer.SubscriptionCount}";
			breakfastRemLabel.Text = $"عدد وجبات الافطار المتبقيه: {customer.BreakfastCounter}";
			launchRemLabel.Text = $"عدد وجبات الغداء المتبقيه: {customer.LunchCounter}";
			w.Text = $"عدد وجبات العشاء المتبقيه: {customer.DinnerCounter}";

		}

		private void BreakfastComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (BreakfastComboBox.SelectedIndex != -1)
			{
				LaunchComboBox.Enabled = false;
				DinnerComboBox.Enabled = false;
			}
			else
			{
				if (customer.LunchCounter > 0)
				{
					LaunchComboBox.Enabled = true;
				}
				if (customer.DinnerCounter > 0)
				{
					DinnerComboBox.Enabled = true;
				}
			}
		}

		private void LaunchComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LaunchComboBox.SelectedIndex != -1)
			{
				BreakfastComboBox.Enabled = false;
				DinnerComboBox.Enabled = false;
			}
			else
			{
				if (customer.BreakfastCounter > 0)
				{
					BreakfastComboBox.Enabled = true;
				}
				if (customer.DinnerCounter > 0)
				{
					DinnerComboBox.Enabled = true;
				}
			}
		}

		private void DinnerComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DinnerComboBox.SelectedIndex != -1)
			{
				LaunchComboBox.Enabled = false;
				BreakfastComboBox.Enabled = false;
			}
			else
			{
				if (customer.LunchCounter > 0)
				{
					LaunchComboBox.Enabled = true;
				}
				if (customer.DinnerCounter > 0)
				{
					DinnerComboBox.Enabled = true;
				}
			}
		}

		private void buffetCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (buffetCheckBox.Checked)
			{
				buffetTextBox.Visible = true;
				specifyBuffetLabel.Visible = true;
				BreakfastComboBox.Enabled = false;
				LaunchComboBox.Enabled = false;
				DinnerComboBox.Enabled = false;


			}
			else
			{
				buffetTextBox.Visible = false;
				specifyBuffetLabel.Visible = false;
				if (customer.BreakfastCounter > 0)
				{
					BreakfastComboBox.Enabled = true;
				}
				if (customer.LunchCounter > 0)
				{
					LaunchComboBox.Enabled = true;
				}
				if (customer.DinnerCounter > 0)
				{
					DinnerComboBox.Enabled = true;
				}
			}

		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			BreakfastComboBox.SelectedIndex = -1;
			LaunchComboBox.SelectedIndex = -1;
			DinnerComboBox.SelectedIndex = -1;
			specifyBuffetLabel.Visible = false;
			specifyNotesLabel.Visible = false;

			buffetCheckBox.Visible = true;
			buffetTextBox.Visible = false;
			buffetCheckBox.Checked = false;
			if (customer.BreakfastCounter > 0)
			{
				BreakfastComboBox.Enabled = true;
			}
			if (customer.LunchCounter > 0)
			{
				LaunchComboBox.Enabled = true;
			}
			if (customer.DinnerCounter > 0)
			{
				DinnerComboBox.Enabled = true;
			}
			notesTextBox.Text = string.Empty;
			buffetTextBox.Text = string.Empty;
		}

		private void recordOrderButton_Click(object sender, EventArgs e)
		{

			if (BreakfastComboBox.SelectedIndex == -1 && LaunchComboBox.SelectedIndex == -1 && DinnerComboBox.SelectedIndex == -1 && !buffetCheckBox.Checked) { MessageBox.Show("الرجاء اختيار طلب"); }

			else if (specifyBuffetLabel.Visible && buffetTextBox.Text == "") { MessageBox.Show("الرجاء ادخال طلب البوفيه"); }

			else
			{
				if (BreakfastComboBox.SelectedIndex != -1)
				{
					customer.BreakfastCounter--;
				}
				if (LaunchComboBox.SelectedIndex != -1)
				{
					customer.LunchCounter--;
				}
				if (DinnerComboBox.SelectedIndex != -1)
				{
					customer.DinnerCounter--;
				}
				try
				{
					RecordAndLogOrder();
					MessageBox.Show("تم تسجيل الطلب بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

					this.Close();
				}
				catch (Exception ex)
				{

					MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}
		}

		private void RecordOrder_FormClosing(object sender, FormClosingEventArgs e)
		{
			var SearchCust = new SearchCustomer();
			SearchCust.Show();
			Utility.db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
			
		}


		private void RecordAndLogOrder()
		{
			db.Update(customer);
			MealLog newlog = new MealLog();
			newlog.TimeTaken = DateTime.Now;
			newlog.PhoneNumber = customer.PhoneNumber;
			newlog.MealId = customer.MealId;
			newlog.isBuffet = false;
			newlog.isKitchen = true;
			if (BreakfastComboBox.SelectedIndex != -1 && BreakfastComboBox.SelectedItem is BreakFastOption breakfastOption)
			{
				newlog.choosen_meal = breakfastOption.optionName;

			}
			if (LaunchComboBox.SelectedIndex != -1 && LaunchComboBox.SelectedItem is LunchOption launchOption)
			{
				newlog.choosen_meal = launchOption.optionName;
			}
			if (DinnerComboBox.SelectedIndex != -1 && DinnerComboBox.SelectedItem is DinnerOption dinnerOption)
			{
				newlog.choosen_meal = dinnerOption.optionName;
			}

			if (buffetCheckBox.Checked)
			{
				newlog.choosen_meal = buffetTextBox.Text;
				newlog.isBuffet = true;
				newlog.isKitchen = false;
			}
			newlog.CashierName = Manager.currentLoggedCashier.UserName;
			db.MealLog.Add(newlog);
			Manager.currentLoggedCashier.ordersServied += 1;
			db.Cashiers.Update(Manager.currentLoggedCashier);
			db.SaveChanges();
		}

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}

		private void specifyNotesLabel_Click(object sender, EventArgs e)
		{

		}

		private void RecordOrder_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				recordOrderButton.PerformClick();
			}
		}

		private void RecordOrder_Load(object sender, EventArgs e)
		{
			buffetCheckBox.Checked = false;



			KeyPreview = true;
			var breakfastOps = db.BreakFastOptions.Where(e => e.MealId == customer.MealId).ToList();
			var lunchOps = db.LunchOptions.Where(e => e.MealId == customer.MealId).ToList();
			var dinnerOps = db.DinnerOptions.Where(e => e.MealId == customer.MealId).ToList();


			BreakfastComboBox.DisplayMember = "optionName";
			LaunchComboBox.DisplayMember = "optionName";
			DinnerComboBox.DisplayMember = "optionName";


			BreakfastComboBox.DataSource = breakfastOps;
			LaunchComboBox.DataSource = lunchOps;
			DinnerComboBox.DataSource = dinnerOps;

			BreakfastComboBox.SelectedIndex = -1;
			LaunchComboBox.SelectedIndex = -1;
			DinnerComboBox.SelectedIndex = -1;
		}

		private void BFRenewBTn_Click(object sender, EventArgs e)
		{
			using(confirmDialog dialog = new confirmDialog())
			{
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						customer.BreakfastCounter = 22;
						Utility.db.Customers.Update(customer);
						Utility.db.SaveChanges();
						MessageBox.Show("تم التجديد بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch 
					{
						MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					this.Close();
				}
			}
		}

		private void LunchRenewBTN_Click(object sender, EventArgs e)
		{
			using (confirmDialog dialog = new confirmDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						customer.LunchCounter = 22;
						Utility.db.Customers.Update(customer);
						Utility.db.SaveChanges();
						MessageBox.Show("تم التجديد بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
					}
					catch
					{
						MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					this.Close();
				}
			}
		}

		private void DinnerRenewBTN_Click(object sender, EventArgs e)
		{
			using (confirmDialog dialog = new confirmDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					try 
					{
						customer.DinnerCounter = 22;
						Utility.db.Customers.Update(customer);
						Utility.db.SaveChanges();
						MessageBox.Show("تم التجديد بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch
					{
						MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					this.Close();
				}
			}
		}
	}
}
