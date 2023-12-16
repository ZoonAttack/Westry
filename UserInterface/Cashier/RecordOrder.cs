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

namespace Westry
{
    public partial class RecordOrder : Form
    {

        private string clientName; //got from the cashierPage form
        private string clientPhoneNumber;
        private int clientPreviousSubscriptions;
        private int remainingBreakfast;
        private int remainingLunch;
        private int remainingDinner;
        private int subscriptionType;

        public RecordOrder(string name, string phoneNumber, int previousSubscriptions, int breakfast, int lunch, int dinner, int subType)
        {
            clientName = name;
            clientPhoneNumber = phoneNumber;
            clientPreviousSubscriptions = previousSubscriptions;
            remainingBreakfast = breakfast;
            remainingLunch = lunch;
            remainingDinner = dinner;
            subscriptionType = subType;

            InitializeComponent();
            ManageComboboxes(subscriptionType);
            LoadClientDataFromDatabase(clientName, clientPhoneNumber, clientPreviousSubscriptions, remainingBreakfast, remainingLunch, remainingDinner, subscriptionType);

            specifyBuffetLabel.Visible = false;
            specifyNotesLabel.Visible = false;
            buffetTextBox.Visible = false;
        }

        private void LoadClientDataFromDatabase(string name, string phone, int subCount, int rembreak, int remlaunch, int remdinner, int subtype)
        {
            

            string clientName = name; //got from the previous form
            string clientPhoneNumber = phone;
            int clientPreviousSubscriptions = subCount;
            int remainingBreakfast = rembreak;
            int remainingLunch = remlaunch;
            int remainingDinner = remdinner;

            // add data to labels
            nameLabel.Text = $"Name: {clientName}";
            phoneLabel.Text = $"Phone Number: {clientPhoneNumber}";
            subCountLabel.Text = $"Previous Subscriptions: {clientPreviousSubscriptions}";
            breakfastRemLabel.Text = $"Remaining Breakfast Meals: {remainingBreakfast}";
            launchRemLabel.Text = $"Remaining Lunch Meals: {remainingLunch}";
            dinnerRemLabel.Text = $"Remaining Dinner Meals: {remainingDinner}";

        }

        private void ManageComboboxes(int subtype)
        {
            if (subtype == 1)
            {
                LaunchComboBox.Visible = false; DinnerComboBox.Visible = false;
                launchRemLabel.Visible = false; dinnerRemLabel.Visible = false;
            }
            else if (subtype == 2) { DinnerComboBox.Visible = false; dinnerRemLabel.Visible = false; }
        }

        private void BreakfastComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaunchComboBox.Enabled = false;
            DinnerComboBox.Enabled = false;

            string selectedmeal;
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

            string selectedmeal;
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

            string selectedmeal;
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

            if (BreakfastComboBox.SelectedIndex == -1 && LaunchComboBox.SelectedIndex == -1 && DinnerComboBox.SelectedIndex == -1) { Console.Beep(500, 500); MessageBox.Show("please enter a valid order"); }
            else if (specifyNotesLabel.Visible && notesTextBox.Text=="") { Console.Beep(500, 500); MessageBox.Show("please enter a proper note"); }
            else if (specifyBuffetLabel.Visible && buffetTextBox.Text == "") { Console.Beep(500, 500); MessageBox.Show("please enter a buffet order"); }

            else
            {
                //TO DO: save order to database
                this.Close();
            }
        }
    }
}
