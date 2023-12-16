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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
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
            RegisterNewCashier addCashierPage = new RegisterNewCashier();
            addCashierPage.Show();
        }

        private void viewDailyButton_Click(object sender, EventArgs e)
        {
            MealLog log = new MealLog();
            log.Show();

        }

        private void viewClientsButton_Click(object sender, EventArgs e)
        {
            ViewClients clients = new ViewClients();
            clients.Show();

        }
    }
}
