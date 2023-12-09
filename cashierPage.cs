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

namespace Westry
{
    public partial class cashierPage : Form
    {

        private string clientName;
        private string clientPhoneNumber;
        private int clientPreviousSubscriptions;
        private int remainingBreakfast;
        private int remainingLunch;
        private int remainingDinner;
        private int subscriptionType;
        public cashierPage()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (phoneBox.Text == "") { Console.Beep(500, 500); MessageBox.Show("enter phone number"); }
            else
            {




                //TO DO: check phone number in data base and get these client's data below

                clientName = "ahmed"; //dummy data
                clientPhoneNumber = "01234567899";
                clientPreviousSubscriptions = 3;
                remainingBreakfast = 10;
                remainingLunch = 15;
                remainingDinner = 20;
                subscriptionType = 1;

                RecordOrderPage recordOrderPage = new RecordOrderPage(clientName, clientPhoneNumber, clientPreviousSubscriptions, remainingBreakfast, remainingLunch, remainingDinner, subscriptionType);
                recordOrderPage.Show();

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
            userRegistrationPage UserRegistrationPage = new userRegistrationPage();
            UserRegistrationPage.Show();
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
    }
}
