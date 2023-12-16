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
    public partial class RegisterNewCashier : Form
    {
        public RegisterNewCashier()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (nameBox.Text == "" || passwordBox.Text == "")
            {
                Console.Beep(500, 500);
                MessageBox.Show("You cannot leave name or password fields empty");
            }
            //TO DO: Add Cashir name and password to the database

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
