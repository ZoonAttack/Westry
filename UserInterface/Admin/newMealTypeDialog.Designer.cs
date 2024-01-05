namespace Westry.UserInterface.Admin
{
	partial class newMealTypeDialog
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
			ConfirmBTN = new Button();
			CancelBTN = new Button();
			mealNameTB = new TextBox();
			label1 = new Label();
			BFCB = new CheckBox();
			LunchCB = new CheckBox();
			DinnerCB = new CheckBox();
			SuspendLayout();
			// 
			// ConfirmBTN
			// 
			ConfirmBTN.BackColor = Color.AntiqueWhite;
			ConfirmBTN.DialogResult = DialogResult.OK;
			ConfirmBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			ConfirmBTN.Location = new Point(203, 121);
			ConfirmBTN.Name = "ConfirmBTN";
			ConfirmBTN.Size = new Size(109, 52);
			ConfirmBTN.TabIndex = 26;
			ConfirmBTN.Text = "إضافه";
			ConfirmBTN.UseVisualStyleBackColor = false;
			ConfirmBTN.Click += ConfirmBTN_Click;
			// 
			// CancelBTN
			// 
			CancelBTN.BackColor = Color.AntiqueWhite;
			CancelBTN.DialogResult = DialogResult.Cancel;
			CancelBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			CancelBTN.Location = new Point(12, 121);
			CancelBTN.Name = "CancelBTN";
			CancelBTN.Size = new Size(109, 52);
			CancelBTN.TabIndex = 27;
			CancelBTN.Text = "إلغاء";
			CancelBTN.UseVisualStyleBackColor = false;
			// 
			// mealNameTB
			// 
			mealNameTB.Location = new Point(12, 27);
			mealNameTB.Name = "mealNameTB";
			mealNameTB.Size = new Size(207, 23);
			mealNameTB.TabIndex = 28;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(226, 27);
			label1.Name = "label1";
			label1.Size = new Size(97, 25);
			label1.TabIndex = 29;
			label1.Text = "اسم الوجبه";
			// 
			// BFCB
			// 
			BFCB.AutoSize = true;
			BFCB.Location = new Point(224, 83);
			BFCB.Name = "BFCB";
			BFCB.Size = new Size(99, 19);
			BFCB.TabIndex = 30;
			BFCB.Text = "اختيارت الافطار";
			BFCB.UseVisualStyleBackColor = true;
			// 
			// LunchCB
			// 
			LunchCB.AutoSize = true;
			LunchCB.Location = new Point(118, 83);
			LunchCB.Name = "LunchCB";
			LunchCB.Size = new Size(96, 19);
			LunchCB.TabIndex = 31;
			LunchCB.Text = "اختيارات الغداء";
			LunchCB.UseVisualStyleBackColor = true;
			// 
			// DinnerCB
			// 
			DinnerCB.AutoSize = true;
			DinnerCB.Location = new Point(12, 83);
			DinnerCB.Name = "DinnerCB";
			DinnerCB.Size = new Size(100, 19);
			DinnerCB.TabIndex = 32;
			DinnerCB.Text = "اختيارات العشاء";
			DinnerCB.UseVisualStyleBackColor = true;
			// 
			// newMealTypeDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(327, 185);
			ControlBox = false;
			Controls.Add(DinnerCB);
			Controls.Add(LunchCB);
			Controls.Add(BFCB);
			Controls.Add(label1);
			Controls.Add(mealNameTB);
			Controls.Add(CancelBTN);
			Controls.Add(ConfirmBTN);
			Name = "newMealTypeDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "newMealTypeDialog";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button ConfirmBTN;
		private Button CancelBTN;
		private TextBox mealNameTB;
		private Label label1;
		private CheckBox BFCB;
		private CheckBox LunchCB;
		private CheckBox DinnerCB;
	}
}