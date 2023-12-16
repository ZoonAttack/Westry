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
            if (phoneBox.Text == "") {MessageBox.Show("enter phone number"); }
            else
            {
                Customer? foundCustomer = db.Customers.SingleOrDefault(u => u.PhoneNumber == phoneBox.Text);

                if(foundCustomer != null)
                {
                    RecordOrder recordOrderPage = new RecordOrder(foundCustomer);
					recordOrderPage.Show();
                    Hide();
                    Close();
				}
                else
                {
                    MessageBox.Show("Customer not Found.","",MessageBoxButtons.OK,MessageBoxIcon.Error);

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
            RegsisterNewClient UserRegistrationPage = new RegsisterNewClient();
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
