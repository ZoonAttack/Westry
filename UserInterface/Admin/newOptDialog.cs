using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Westry.UserInterface.Admin
{
	public partial class newOptDialog : Form
	{
		public string optName {  get; set; }
		public bool validated { get; set; }

		public newOptDialog()
		{
			InitializeComponent();
		}

		private void ConfirmBTN_Click(object sender, EventArgs e)
		{
			if (optNameTB.Text.Trim() == "")
			{
				MessageBox.Show("الرجاء كتابة اسم الاختيار", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				validated = false;
				return;
			}

			validated = true;
			optName = optNameTB.Text.Trim();

		}
	}
}
