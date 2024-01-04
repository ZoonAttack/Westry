using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Westry.UserInterface.Admin
{
	public partial class newMealTypeDialog : Form
	{
		public string mealName { get; set; }
		public bool hasBF { get; set; }
		public bool hasLunch { get; set; }
		public bool hasDinner { get; set; }

		public bool validated { get; set; }

		public newMealTypeDialog()
		{
			InitializeComponent();
		}

		private void ConfirmBTN_Click(object sender, EventArgs e)
		{
			if(mealNameTB.Text.Trim() == "")
			{
				MessageBox.Show("الرجاء كتابة اسم الوجبه", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				validated = false;
				return;
			}
			
			
			else if(!BFCB.Checked && !LunchCB.Checked && !DinnerCB.Checked) {
				MessageBox.Show("الرجاء اختيار نوع الاختيارات","",MessageBoxButtons.OK,MessageBoxIcon.Error);
				validated=false;
				return;
			}

			validated = true;
			mealName = mealNameTB.Text.Trim();

			if (BFCB.Checked)
			{
				hasBF = true;
			}
			if(LunchCB.Checked)
			{
				hasLunch = true;
			}
			if(DinnerCB.Checked)
			{
				hasDinner = true;
			}
		}
	}
}
