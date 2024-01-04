namespace Westry.UserInterface.Admin
{
	partial class EditMeals
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ChooseMealComboBox = new ComboBox();
			mealLBL = new Label();
			newMealBTN = new Button();
			DinnerLB = new ListBox();
			LunchLB = new ListBox();
			BFLB = new ListBox();
			saveChangesBTN = new Button();
			DinnerLBL = new Label();
			LunchLBL = new Label();
			BFLBL = new Label();
			DinnerDLE = new Button();
			DinnerADD = new Button();
			LunchADD = new Button();
			LunchDLE = new Button();
			BFDLE = new Button();
			BFADD = new Button();
			EditMealBTN = new Button();
			mealDLEBTN = new Button();
			SuspendLayout();
			// 
			// ChooseMealComboBox
			// 
			ChooseMealComboBox.FormattingEnabled = true;
			ChooseMealComboBox.Location = new Point(442, 73);
			ChooseMealComboBox.Name = "ChooseMealComboBox";
			ChooseMealComboBox.Size = new Size(310, 23);
			ChooseMealComboBox.TabIndex = 0;
			ChooseMealComboBox.SelectedIndexChanged += ChooseMealComboBox_SelectedIndexChanged;
			// 
			// mealLBL
			// 
			mealLBL.AutoSize = true;
			mealLBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			mealLBL.Location = new Point(758, 71);
			mealLBL.Name = "mealLBL";
			mealLBL.Size = new Size(60, 25);
			mealLBL.TabIndex = 1;
			mealLBL.Text = "الوجبه";
			// 
			// newMealBTN
			// 
			newMealBTN.BackColor = Color.AntiqueWhite;
			newMealBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			newMealBTN.Location = new Point(975, 26);
			newMealBTN.Name = "newMealBTN";
			newMealBTN.Size = new Size(203, 100);
			newMealBTN.TabIndex = 16;
			newMealBTN.Text = "وجبه جديده";
			newMealBTN.UseVisualStyleBackColor = false;
			newMealBTN.Click += newMealBTN_Click;
			// 
			// DinnerLB
			// 
			DinnerLB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			DinnerLB.FormattingEnabled = true;
			DinnerLB.ItemHeight = 17;
			DinnerLB.Location = new Point(50, 169);
			DinnerLB.Name = "DinnerLB";
			DinnerLB.Size = new Size(352, 327);
			DinnerLB.TabIndex = 17;
			// 
			// LunchLB
			// 
			LunchLB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			LunchLB.FormattingEnabled = true;
			LunchLB.ItemHeight = 17;
			LunchLB.Location = new Point(472, 169);
			LunchLB.Name = "LunchLB";
			LunchLB.Size = new Size(352, 327);
			LunchLB.TabIndex = 18;
			// 
			// BFLB
			// 
			BFLB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			BFLB.FormattingEnabled = true;
			BFLB.ItemHeight = 17;
			BFLB.Location = new Point(916, 169);
			BFLB.Name = "BFLB";
			BFLB.Size = new Size(352, 327);
			BFLB.TabIndex = 19;
			// 
			// saveChangesBTN
			// 
			saveChangesBTN.BackColor = Color.AntiqueWhite;
			saveChangesBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			saveChangesBTN.Location = new Point(549, 582);
			saveChangesBTN.Name = "saveChangesBTN";
			saveChangesBTN.Size = new Size(203, 100);
			saveChangesBTN.TabIndex = 20;
			saveChangesBTN.Text = "حفظ التغيرات";
			saveChangesBTN.UseVisualStyleBackColor = false;
			saveChangesBTN.Click += saveChangesBTN_Click;
			// 
			// DinnerLBL
			// 
			DinnerLBL.AutoSize = true;
			DinnerLBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			DinnerLBL.Location = new Point(143, 132);
			DinnerLBL.Name = "DinnerLBL";
			DinnerLBL.Size = new Size(129, 25);
			DinnerLBL.TabIndex = 21;
			DinnerLBL.Text = "اختيارات العشاء";
			// 
			// LunchLBL
			// 
			LunchLBL.AutoSize = true;
			LunchLBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			LunchLBL.Location = new Point(577, 132);
			LunchLBL.Name = "LunchLBL";
			LunchLBL.Size = new Size(123, 25);
			LunchLBL.TabIndex = 22;
			LunchLBL.Text = "اختيارات الغداء";
			// 
			// BFLBL
			// 
			BFLBL.AutoSize = true;
			BFLBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			BFLBL.Location = new Point(1017, 132);
			BFLBL.Name = "BFLBL";
			BFLBL.Size = new Size(133, 25);
			BFLBL.TabIndex = 23;
			BFLBL.Text = "اختيارات الافطار";
			// 
			// DinnerDLE
			// 
			DinnerDLE.BackColor = Color.AntiqueWhite;
			DinnerDLE.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			DinnerDLE.Location = new Point(50, 515);
			DinnerDLE.Name = "DinnerDLE";
			DinnerDLE.Size = new Size(109, 48);
			DinnerDLE.TabIndex = 24;
			DinnerDLE.Text = "حذف";
			DinnerDLE.UseVisualStyleBackColor = false;
			DinnerDLE.Click += DinnerDLE_Click;
			// 
			// DinnerADD
			// 
			DinnerADD.BackColor = Color.AntiqueWhite;
			DinnerADD.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			DinnerADD.Location = new Point(293, 515);
			DinnerADD.Name = "DinnerADD";
			DinnerADD.Size = new Size(109, 48);
			DinnerADD.TabIndex = 25;
			DinnerADD.Text = "إضافه";
			DinnerADD.UseVisualStyleBackColor = false;
			DinnerADD.Click += DinnerADD_Click;
			// 
			// LunchADD
			// 
			LunchADD.BackColor = Color.AntiqueWhite;
			LunchADD.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			LunchADD.Location = new Point(715, 515);
			LunchADD.Name = "LunchADD";
			LunchADD.Size = new Size(109, 48);
			LunchADD.TabIndex = 26;
			LunchADD.Text = "إضافه";
			LunchADD.UseVisualStyleBackColor = false;
			LunchADD.Click += LunchADD_Click;
			// 
			// LunchDLE
			// 
			LunchDLE.BackColor = Color.AntiqueWhite;
			LunchDLE.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			LunchDLE.Location = new Point(472, 515);
			LunchDLE.Name = "LunchDLE";
			LunchDLE.Size = new Size(109, 48);
			LunchDLE.TabIndex = 27;
			LunchDLE.Text = "حذف";
			LunchDLE.UseVisualStyleBackColor = false;
			LunchDLE.Click += LunchDLE_Click;
			// 
			// BFDLE
			// 
			BFDLE.BackColor = Color.AntiqueWhite;
			BFDLE.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			BFDLE.Location = new Point(916, 515);
			BFDLE.Name = "BFDLE";
			BFDLE.Size = new Size(109, 48);
			BFDLE.TabIndex = 28;
			BFDLE.Text = "حذف";
			BFDLE.UseVisualStyleBackColor = false;
			BFDLE.Click += BFDLE_Click;
			// 
			// BFADD
			// 
			BFADD.BackColor = Color.AntiqueWhite;
			BFADD.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			BFADD.Location = new Point(1159, 515);
			BFADD.Name = "BFADD";
			BFADD.Size = new Size(109, 48);
			BFADD.TabIndex = 29;
			BFADD.Text = "إضافه";
			BFADD.UseVisualStyleBackColor = false;
			BFADD.Click += BFADD_Click;
			// 
			// EditMealBTN
			// 
			EditMealBTN.BackColor = Color.AntiqueWhite;
			EditMealBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			EditMealBTN.Location = new Point(211, 26);
			EditMealBTN.Name = "EditMealBTN";
			EditMealBTN.Size = new Size(171, 100);
			EditMealBTN.TabIndex = 30;
			EditMealBTN.Text = "تعديل الاختيارات";
			EditMealBTN.UseVisualStyleBackColor = false;
			EditMealBTN.Click += EditMealBTN_Click;
			// 
			// mealDLEBTN
			// 
			mealDLEBTN.BackColor = Color.AntiqueWhite;
			mealDLEBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			mealDLEBTN.Location = new Point(42, 26);
			mealDLEBTN.Name = "mealDLEBTN";
			mealDLEBTN.Size = new Size(163, 100);
			mealDLEBTN.TabIndex = 31;
			mealDLEBTN.Text = "حذف الوجبه";
			mealDLEBTN.UseVisualStyleBackColor = false;
			mealDLEBTN.Click += mealDLEBTN_Click;
			// 
			// EditMeals
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1314, 694);
			Controls.Add(mealDLEBTN);
			Controls.Add(EditMealBTN);
			Controls.Add(BFADD);
			Controls.Add(BFDLE);
			Controls.Add(LunchDLE);
			Controls.Add(LunchADD);
			Controls.Add(DinnerADD);
			Controls.Add(DinnerDLE);
			Controls.Add(BFLBL);
			Controls.Add(LunchLBL);
			Controls.Add(DinnerLBL);
			Controls.Add(saveChangesBTN);
			Controls.Add(BFLB);
			Controls.Add(LunchLB);
			Controls.Add(DinnerLB);
			Controls.Add(newMealBTN);
			Controls.Add(mealLBL);
			Controls.Add(ChooseMealComboBox);
			Name = "EditMeals";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EditMeals";
			FormClosed += EditMeals_FormClosed;
			Load += EditMeals_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox ChooseMealComboBox;
		private Label mealLBL;
		private Button newMealBTN;
		private ListBox DinnerLB;
		private ListBox LunchLB;
		private ListBox BFLB;
		private Button saveChangesBTN;
		private Label DinnerLBL;
		private Label LunchLBL;
		private Label BFLBL;
		private Button DinnerDLE;
		private Button DinnerADD;
		private Button LunchADD;
		private Button LunchDLE;
		private Button BFDLE;
		private Button BFADD;
		private Button EditMealBTN;
		private Button mealDLEBTN;
	}
}