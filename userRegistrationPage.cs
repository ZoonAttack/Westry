using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Westry
{
    public partial class userRegistrationPage : Form
    {
        public userRegistrationPage()
        {
            InitializeComponent();
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
            if (phoneBox.Text=="" || nameBox.Text == "") {
                Console.Beep(500,500);
                MessageBox.Show("Cannot leave phone or name fields empty!"); }
            else if (!oneMealRadioButton.Checked && !threeMealRadioButton.Checked && !twoMealRadioButton.Checked){ Console.Beep(500, 500); MessageBox.Show("choose a subscription type!"); }
            else { 
            //To Do: register data to the database and allert the user if success
            this.Close();
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
    }
}
