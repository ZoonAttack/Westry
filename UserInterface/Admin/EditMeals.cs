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
		List<Meal> mealTypes;
		private bool isFirstTime = true;
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

			mealTypes = Utility.db.Meals.ToList();
			refreshComboBox();
		}

		private void refreshComboBox()
		{
			ChooseMealComboBox.DataSource = null;
			ChooseMealComboBox.DisplayMember = "Name";
			ChooseMealComboBox.DataSource = mealTypes;
			ChooseMealComboBox.SelectedIndex = -1;
		}

		private void hideControls()
		{
			EditMealBTN.Visible = false;
			mealDLEBTN.Visible = false;
			
		}

		private void showControls()
		{
			EditMealBTN.Visible = true;
			mealDLEBTN.Visible = true;
			saveChangesBTN.Visible = true;
		}

		private void hideBF()
		{
			BFLBL.Visible = false;
			BFLB.Visible = false;
			BFADD.Visible = false;
			BFDLE.Visible = false;
		}
		private void showBF()
		{
			BFLBL.Visible = true;
			BFLB.Visible = true;
			BFADD.Visible = true;
			BFDLE.Visible = true;
		}
		private void hideLunch()
		{
			LunchLBL.Visible = false;
			LunchLB.Visible = false;
			LunchADD.Visible = false;
			LunchDLE.Visible = false;
		}
		private void showLunch()
		{
			LunchLBL.Visible = true;
			LunchLB.Visible = true;
			LunchADD.Visible = true;
			LunchDLE.Visible = true;
		}

		private void hideDinner()
		{
			DinnerLBL.Visible = false;
			DinnerLB.Visible = false;
			DinnerADD.Visible = false;
			DinnerDLE.Visible = false;
		}
		private void showDinner()
		{
			DinnerLBL.Visible = true;
			DinnerLB.Visible = true;
			DinnerADD.Visible = true;
			DinnerDLE.Visible = true;
		}

		private void newMealBTN_Click(object sender, EventArgs e)
		{
			using (newMealTypeDialog dialog = new newMealTypeDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK && dialog.validated)
				{
					Meal newMeal = new Meal();
					try
					{
						newMeal.Name = dialog.mealName;
						newMeal.hasBreakfast = dialog.hasBF;
						newMeal.hasLunch = dialog.hasLunch;
						newMeal.hasDinner = dialog.hasDinner;

						Utility.db.Meals.Add(newMeal);
						Utility.db.SaveChanges();
						mealTypes.Add(newMeal);
						refreshComboBox();
						MessageBox.Show("تم تسجيل الوجبه بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch
					{
						MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			};

		}

		private void ChooseMealComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			hideBF();
			hideLunch();
			hideDinner();

			if (ChooseMealComboBox.SelectedIndex == -1)
			{
				hideControls();
				if (isFirstTime)
				{
					saveChangesBTN.Visible = false;
					isFirstTime = false;
				}
			}
			else
			{
				showControls();
			}
		}
		private void mealDLEBTN_Click(object sender, EventArgs e)
		{
			try
			{
				Meal? selectedMeal = ChooseMealComboBox.SelectedItem as Meal;
				Utility.db.Meals.Remove(selectedMeal);
				MessageBox.Show(mealTypes.Remove(selectedMeal).ToString());
				refreshComboBox();
			}
			catch
			{
				MessageBox.Show("الوجبه غير موجوده", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void EditMealBTN_Click(object sender, EventArgs e)
		{
			Meal selectedMeal = ChooseMealComboBox.SelectedItem as Meal;
			if((bool)selectedMeal.hasBreakfast)
			{
				showBF();
				List<BreakFastOption> bfOpts = Utility.db.BreakFastOptions.Where(u => u.MealId == selectedMeal.MealId).ToList();
				BFLB.DataSource = null;
				BFLB.DataSource = bfOpts;
				BFLB.DisplayMember = "optionName";
			}
			if ((bool)selectedMeal.hasLunch)
			{
				showLunch();
				List<LunchOption> LunchOpts = Utility.db.LunchOptions.Where(u => u.MealId == selectedMeal.MealId).ToList();
				LunchLB.DataSource = null;
				LunchLB.DataSource = LunchOpts;
				LunchLB.DisplayMember = "optionName";
			}
			if ((bool)selectedMeal.hasDinner)
			{
				showDinner();
				List<DinnerOption> dinnerOpts = Utility.db.DinnerOptions.Where(u => u.MealId == selectedMeal.MealId).ToList();
				DinnerLB.DataSource = null;
				DinnerLB.DataSource = dinnerOpts;
				DinnerLB.DisplayMember = "optionName";
			}
		}

		private void saveChangesBTN_Click(object sender, EventArgs e)
		{
			try
			{
				Utility.db.SaveChanges();
				MessageBox.Show("تم حفظ التغيرات بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch
			{
				MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
