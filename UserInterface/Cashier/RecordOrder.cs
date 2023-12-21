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

		public RecordOrder(Customer FoundCustomer)
		{
			customer = FoundCustomer;
			db = new DevDbContext();

			InitializeComponent();
			subscriptionType = FoundCustomer.MealId;
			ManageComboboxes(subscriptionType);
			ShowData();

			specifyBuffetLabel.Visible = false;
			specifyNotesLabel.Visible = false;
			buffetTextBox.Visible = false;
		}

		private void ShowData()
		{

			// add data to labels
			nameLabel.Text = $"Name: {customer.Name}";
			phoneLabel.Text = $"Phone Number: {customer.PhoneNumber}";
			subCountLabel.Text = $"Previous Subscriptions: {customer.SubscriptionCount}";
			breakfastRemLabel.Text = $"Remaining Breakfast Meals: {customer.BreakfastCounter}";
			launchRemLabel.Text = $"Remaining Lunch Meals: {customer.LunchCounter}";
			dinnerRemLabel.Text = $"Remaining Dinner Meals: {customer.DinnerCounter}";

		}

		private void ManageComboboxes(int? subtype)
		{
			if (subtype == 1)
			{
				BreakfastComboBox.Visible = false; DinnerComboBox.Visible = false;
				breakfastRemLabel.Visible = false; dinnerRemLabel.Visible = false;
			}
			else if (subtype == 2) { DinnerComboBox.Visible = false; dinnerRemLabel.Visible = false; }
		}

		private void BreakfastComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LaunchComboBox.Enabled = false;
			DinnerComboBox.Enabled = false;

			string? selectedmeal;
			if (BreakfastComboBox.SelectedItem != null)
			{
				selectedmeal = BreakfastComboBox.SelectedItem.ToString();
				if (selectedmeal == "آخر") { specifyNotesLabel.Visible = true; }
				else { specifyNotesLabel.Visible = false; }
			}
		}

		private void LaunchComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			BreakfastComboBox.Enabled = false;
			DinnerComboBox.Enabled = false;

			string? selectedmeal;
			if (LaunchComboBox.SelectedItem != null)
			{
				selectedmeal = LaunchComboBox.SelectedItem.ToString();
				if (selectedmeal == "آخر") { specifyNotesLabel.Visible = true; }
				else { specifyNotesLabel.Visible = false; }
			}
		}

		private void DinnerComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			BreakfastComboBox.Enabled = false;
			LaunchComboBox.Enabled = false;

			string? selectedmeal;
			if (DinnerComboBox.SelectedItem != null)
			{
				selectedmeal = DinnerComboBox.SelectedItem.ToString();
				if (selectedmeal == "آخر") { specifyNotesLabel.Visible = true; }
				else { specifyNotesLabel.Visible = false; }
			}
		}

		private void buffetCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			buffetTextBox.Visible = buffetCheckBox.Checked;
			specifyBuffetLabel.Visible = buffetCheckBox.Checked;
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			BreakfastComboBox.SelectedIndex = -1;
			LaunchComboBox.SelectedIndex = -1;
			DinnerComboBox.SelectedIndex = -1;
			specifyBuffetLabel.Visible = false;
			specifyNotesLabel.Visible = false;
			buffetTextBox.Visible = false;
			buffetCheckBox.Checked = false;
			BreakfastComboBox.Enabled = true;
			LaunchComboBox.Enabled = true;
			DinnerComboBox.Enabled = true;
			notesTextBox.Text = string.Empty;
			buffetTextBox.Text = string.Empty;
		}

		private void recordOrderButton_Click(object sender, EventArgs e)
		{

			if (BreakfastComboBox.SelectedIndex == -1 && LaunchComboBox.SelectedIndex == -1 && DinnerComboBox.SelectedIndex == -1) { MessageBox.Show("please enter a valid order"); }
			else if (specifyNotesLabel.Visible && notesTextBox.Text == "") { MessageBox.Show("please enter a proper note"); }
			else if (specifyBuffetLabel.Visible && buffetTextBox.Text == "") { MessageBox.Show("please enter a buffet order"); }

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
				catch
				{
					MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}
		}

		private void RecordOrder_FormClosing(object sender, FormClosingEventArgs e)
		{

			var SearchCust = new SearchCustomer();
			SearchCust.Show();
		}


		private void RecordAndLogOrder()
		{
			db.Update(customer);
			//TODO: Should Log Meal here and record it to DB
			db.SaveChanges();
		}

	}
}
