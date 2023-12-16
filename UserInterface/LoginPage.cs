namespace Westry
{
    public partial class LoginPage : Form
    {
        bool isAdmin = false;
        bool isCashier = false;
        public LoginPage()
        {
            InitializeComponent();

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(nameBox.Text=="" || passwordBox.Text == "") { Console.Beep(500, 500); MessageBox.Show("enter a valid username and password");  }
            else {


                //TO DO :check name and password in data base and change isCashier or isAdmin state according to it
                isCashier = true; //just for testing, delete it when finishing database code

                if (isAdmin)
                {
                    AdminPanel adminPage = new AdminPanel();
                    adminPage.Show();
                }
                else if (isCashier)
                {
                    SearchCustomer CashierPage = new SearchCustomer();
                    CashierPage.Show();
                }
                else
                {
                    Console.Beep(500, 500);
                    MessageBox.Show("Wrong username or password!");
                }
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}