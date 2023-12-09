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
    public partial class DeleteCashierPage : Form
    {
        public DeleteCashierPage()
        {
            InitializeComponent();
        }

        private void deleteCashierButton_Click(object sender, EventArgs e)
        {
            if (cashierNameTextBox.Text == "")
            {
                Console.Beep(500, 500);
                MessageBox.Show("Cannot leave phone or name fields empty!");
            }
            else
            {
                //To DO: delete cashier name and password from database
                this.Close();
            }
        }
    }
}
