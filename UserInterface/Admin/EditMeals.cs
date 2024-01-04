using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Westry.Models;

namespace Westry.UserInterface.Admin
{
	public partial class EditMeals : Form
	{
		public EditMeals()
		{
			InitializeComponent();
		}

		private void EditMeals_FormClosed(object sender, FormClosedEventArgs e)
		{
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.Show();
		}

		private void EditMeals_Load(object sender, EventArgs e)
		{
			KeyPreview = true;

			hideBF();
			hideDinner();
			hideLunch();
			hideControls();
		}

		private void hideControls()
		{
			EditMealBTN.Visible = false;
			mealDLEBTN.Visible = false;
			saveChangesBTN.Visible = false;
		}

		private void hideBF()
		{
			BFLBL.Visible = false;
			BFLB.Visible = false;
			BFADD.Visible = false;
			BFDLE.Visible = false;
		}

		private void hideLunch()
		{
			LunchLBL.Visible = false;
			LunchLB.Visible = false;
			LunchADD.Visible = false;
			LunchDLE.Visible = false;
		}

		private void hideDinner()
		{
			DinnerLBL.Visible = false;
			DinnerLB.Visible = false;
			DinnerADD.Visible = false;
			DinnerDLE.Visible = false;
		}

		private void newMealBTN_Click(object sender, EventArgs e)
		{
			using (newMealTypeDialog dialog = new newMealTypeDialog()) {
				if (dialog.ShowDialog() == DialogResult.OK && dialog.validated)
				{
					Meal newMeal = new Meal();
					try {
						newMeal.Name = dialog.mealName;
						newMeal.hasBreakfast = dialog.hasBF;
						newMeal.hasLunch = dialog.hasLunch;
						newMeal.hasDinner = dialog.hasDinner;

						Utility.db.Meals.Add(newMeal);
						Utility.db.SaveChanges();

						MessageBox.Show("تم تسجيل الوجبه بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch
					{
						MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			} ;
			
		}
	}
}
