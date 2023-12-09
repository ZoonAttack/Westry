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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            cashierInfoDataGridView.ReadOnly = true;
        }

        private void deleteCashierButton_Click(object sender, EventArgs e)
        {
            DeleteCashierPage deleteCashierPage = new DeleteCashierPage();
            deleteCashierPage.Show();

        }

        private void addCashierButton_Click(object sender, EventArgs e)
        {
            AddCashierPage addCashierPage = new AddCashierPage();
            addCashierPage.Show();
        }

        private void viewDailyButton_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.Show();

        }

        private void viewClientsButton_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();

        }
    }
}
