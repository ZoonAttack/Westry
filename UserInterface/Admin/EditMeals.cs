using Microsoft.EntityFrameworkCore;
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
		List<BreakFastOption> breakfastopts;
		List<LunchOption> lunchopts;
		List<DinnerOption> dinneropts;

		List<BreakFastOption> bftobeadded = new List<BreakFastOption>();
		List<LunchOption> lunchtobeadded = new List<LunchOption>();
		List<DinnerOption> dinnertobeadded = new List<DinnerOption>();

		List<BreakFastOption> bftoberemoved = new List<BreakFastOption>();
		List<LunchOption> lunchtoberemoved = new List<LunchOption>();
		List<DinnerOption> dinnertoberemoved = new List<DinnerOption>();

		private bool isFirstTime = true;
		Meal mealToBeEdited;
		public EditMeals()
		{
			InitializeComponent();
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

		private void EditMeals_FormClosed(object sender, FormClosedEventArgs e)
		{
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.Show();
			clearChanges();

		}

		private void clearChanges()
		{
			foreach (var entity in bftobeadded)
			{
				var entry = Utility.db.Entry(entity);

				if (entry.State == EntityState.Added)
					entry.State = EntityState.Detached;
			}
			foreach (var entity in lunchtobeadded)
			{
				var entry = Utility.db.Entry(entity);

				if (entry.State == EntityState.Added)
					entry.State = EntityState.Detached;
			}
			foreach (var entity in dinnertobeadded)
			{
				var entry = Utility.db.Entry(entity);

				if (entry.State == EntityState.Added)
					entry.State = EntityState.Detached;
			}

			foreach (var entity in bftoberemoved)
			{
				var entry = Utility.db.Entry(entity);

				if (entry.State == EntityState.Deleted)
					entry.State = EntityState.Detached;
			}
			foreach (var entity in lunchtoberemoved)
			{
				var entry = Utility.db.Entry(entity);

				if (entry.State == EntityState.Deleted)
					entry.State = EntityState.Detached;
			}
			foreach (var entity in dinnertoberemoved)
			{
				var entry = Utility.db.Entry(entity);

				if (entry.State == EntityState.Deleted)
					entry.State = EntityState.Detached;
			}
		}
		private void refreshComboBox()
		{
			ChooseMealComboBox.DataSource = null;
			ChooseMealComboBox.DisplayMember = "Name";
			ChooseMealComboBox.DataSource = mealTypes;
			ChooseMealComboBox.SelectedIndex = -1;
		}
		private void refreshBFLB()
		{
			BFLB.DataSource = null;
			BFLB.DataSource = breakfastopts;
			BFLB.DisplayMember = "optionName";
		}
		private void refreshLunchLB()
		{
			LunchLB.DataSource = null;
			LunchLB.DataSource = lunchopts;
			LunchLB.DisplayMember = "optionName";
		}
		private void refreshDinnerLB()
		{
			DinnerLB.DataSource = null;
			DinnerLB.DataSource = dinneropts;
			DinnerLB.DisplayMember = "optionName";
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
				refreshComboBox();
			}
			catch
			{
				MessageBox.Show("الوجبه غير موجوده", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void EditMealBTN_Click(object sender, EventArgs e)
		{
			try
			{
				mealToBeEdited = ChooseMealComboBox.SelectedItem as Meal;
			}
			catch
			{
				MessageBox.Show("حدث خطأ ما", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if ((bool)mealToBeEdited.hasBreakfast)
			{
				showBF();
				breakfastopts = Utility.db.BreakFastOptions.Where(u => u.MealId == mealToBeEdited.MealId).ToList();
				refreshBFLB();
			}
			if ((bool)mealToBeEdited.hasLunch)
			{
				showLunch();
				lunchopts = Utility.db.LunchOptions.Where(u => u.MealId == mealToBeEdited.MealId).ToList();
				refreshLunchLB();
			}
			if ((bool)mealToBeEdited.hasDinner)
			{
				showDinner();
				dinneropts = Utility.db.DinnerOptions.Where(u => u.MealId == mealToBeEdited.MealId).ToList();
				refreshDinnerLB();
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

		private void BFADD_Click(object sender, EventArgs e)
		{
			addNewOptToMeal(0);
		}


		private void LunchADD_Click(object sender, EventArgs e)
		{
			addNewOptToMeal(1);
		}

		private void DinnerADD_Click(object sender, EventArgs e)
		{
			addNewOptToMeal(2);
		}

		private void addNewOptToMeal(int type)
		{
			string newOptName;
			using (newOptDialog dialog = new newOptDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK && dialog.validated)
				{
					newOptName = dialog.optName;
				}
				else
				{
					return;
				}
			}

			//type 
			// 0 breakfast
			// 1 lunch
			// 2 dinner


			if (type == 0)
			{
				BreakFastOption newOpt = new BreakFastOption();
				newOpt.optionName = newOptName;
				newOpt.MealId = mealToBeEdited.MealId;
				Utility.db.BreakFastOptions.Add(newOpt);
				breakfastopts.Add(newOpt);
				refreshBFLB();
				bftobeadded.Add(newOpt);
			}
			else if (type == 1)
			{
				LunchOption newOpt = new LunchOption();
				newOpt.optionName = newOptName;
				newOpt.MealId = mealToBeEdited.MealId;
				Utility.db.LunchOptions.Add(newOpt);
				lunchopts.Add(newOpt);
				refreshLunchLB();
				lunchtobeadded.Add(newOpt);
			}
			else if (type == 2)
			{
				DinnerOption newOpt = new DinnerOption();
				newOpt.optionName = newOptName;
				newOpt.MealId = mealToBeEdited.MealId;
				Utility.db.DinnerOptions.Add(newOpt);
				dinneropts.Add(newOpt);
				refreshDinnerLB();
				dinnertobeadded.Add(newOpt);
			}

		}


		private void BFDLE_Click(object sender, EventArgs e)
		{
			removeOldOptFromMeal(0);
		}

		private void LunchDLE_Click(object sender, EventArgs e)
		{
			removeOldOptFromMeal(1);
		}

		private void DinnerDLE_Click(object sender, EventArgs e)
		{
			removeOldOptFromMeal(2);
		}

		private void removeOldOptFromMeal(int type)
		{
			if (type == 0)
			{
				BreakFastOption oldOptBF = BFLB.SelectedItem as BreakFastOption;
				Utility.db.BreakFastOptions.Remove(oldOptBF);
				breakfastopts.Remove(oldOptBF);
				refreshBFLB();
				bftoberemoved.Add(oldOptBF);
			}
			else if (type == 1)
			{
				LunchOption oldOptLunch = LunchLB.SelectedItem as LunchOption;
				Utility.db.LunchOptions.Remove(oldOptLunch);
				lunchopts.Remove(oldOptLunch);
				refreshLunchLB();
				lunchtoberemoved.Add(oldOptLunch);
			}
			else if (type == 2)
			{
				DinnerOption oldOptDinner = DinnerLB.SelectedItem as DinnerOption;
				Utility.db.DinnerOptions.Remove(oldOptDinner);
				dinneropts.Remove(oldOptDinner);
				refreshDinnerLB();
				dinnertoberemoved.Add(oldOptDinner);
			}

		}

	}
}
