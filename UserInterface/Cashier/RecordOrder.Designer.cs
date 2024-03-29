﻿namespace Westry
{
    partial class RecordOrder
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
			nameLabel = new Label();
			subCountLabel = new Label();
			DinnerRemLabel = new Label();
			launchRemLabel = new Label();
			breakfastRemLabel = new Label();
			phoneLabel = new Label();
			BreakfastComboBox = new ComboBox();
			DinnerComboBox = new ComboBox();
			LaunchComboBox = new ComboBox();
			notesLabel = new Label();
			notesTextBox = new TextBox();
			buffetCheckBox = new CheckBox();
			buffetTextBox = new TextBox();
			specifyNotesLabel = new Label();
			specifyBuffetLabel = new Label();
			recordOrderButton = new Button();
			resetButton = new Button();
			BFRenewBTn = new Button();
			LunchRenewBTN = new Button();
			DinnerRenewBTN = new Button();
			mealTypeLBL = new Label();
			SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			nameLabel.Location = new Point(12, 25);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(101, 25);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "اسم العميل";
			nameLabel.Click += nameLabel_Click;
			// 
			// subCountLabel
			// 
			subCountLabel.AutoSize = true;
			subCountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			subCountLabel.Location = new Point(12, 99);
			subCountLabel.Name = "subCountLabel";
			subCountLabel.Size = new Size(157, 25);
			subCountLabel.TabIndex = 1;
			subCountLabel.Text = "عدد مرات الاشتراك";
			// 
			// DinnerRemLabel
			// 
			DinnerRemLabel.AutoSize = true;
			DinnerRemLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			DinnerRemLabel.Location = new Point(99, 135);
			DinnerRemLabel.Name = "DinnerRemLabel";
			DinnerRemLabel.Size = new Size(182, 25);
			DinnerRemLabel.TabIndex = 2;
			DinnerRemLabel.Text = "وجبات العشاء المتبقيه";
			// 
			// launchRemLabel
			// 
			launchRemLabel.AutoSize = true;
			launchRemLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			launchRemLabel.Location = new Point(531, 135);
			launchRemLabel.Name = "launchRemLabel";
			launchRemLabel.Size = new Size(212, 25);
			launchRemLabel.TabIndex = 3;
			launchRemLabel.Text = "عدد وحبات الغداء المتبقيه";
			// 
			// breakfastRemLabel
			// 
			breakfastRemLabel.AutoSize = true;
			breakfastRemLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			breakfastRemLabel.Location = new Point(943, 135);
			breakfastRemLabel.Name = "breakfastRemLabel";
			breakfastRemLabel.Size = new Size(222, 25);
			breakfastRemLabel.TabIndex = 4;
			breakfastRemLabel.Text = "عدد وحبات الافطار المتبقيه";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			phoneLabel.Location = new Point(12, 60);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new Size(95, 25);
			phoneLabel.TabIndex = 5;
			phoneLabel.Text = "رقم الهاتف";
			// 
			// BreakfastComboBox
			// 
			BreakfastComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			BreakfastComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			BreakfastComboBox.FormattingEnabled = true;
			BreakfastComboBox.Location = new Point(887, 210);
			BreakfastComboBox.Name = "BreakfastComboBox";
			BreakfastComboBox.Size = new Size(415, 25);
			BreakfastComboBox.TabIndex = 6;
			BreakfastComboBox.SelectedIndexChanged += BreakfastComboBox_SelectedIndexChanged;
			// 
			// DinnerComboBox
			// 
			DinnerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			DinnerComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			DinnerComboBox.FormattingEnabled = true;
			DinnerComboBox.Location = new Point(12, 210);
			DinnerComboBox.Name = "DinnerComboBox";
			DinnerComboBox.Size = new Size(420, 25);
			DinnerComboBox.TabIndex = 7;
			DinnerComboBox.SelectedIndexChanged += DinnerComboBox_SelectedIndexChanged;
			// 
			// LaunchComboBox
			// 
			LaunchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			LaunchComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			LaunchComboBox.FormattingEnabled = true;
			LaunchComboBox.Location = new Point(438, 210);
			LaunchComboBox.Name = "LaunchComboBox";
			LaunchComboBox.Size = new Size(443, 25);
			LaunchComboBox.TabIndex = 8;
			LaunchComboBox.SelectedIndexChanged += LaunchComboBox_SelectedIndexChanged;
			// 
			// notesLabel
			// 
			notesLabel.AutoSize = true;
			notesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			notesLabel.Location = new Point(1123, 350);
			notesLabel.Name = "notesLabel";
			notesLabel.Size = new Size(179, 32);
			notesLabel.TabIndex = 9;
			notesLabel.Text = "ملاحظات إضافية";
			notesLabel.Visible = false;
			// 
			// notesTextBox
			// 
			notesTextBox.Location = new Point(523, 303);
			notesTextBox.Multiline = true;
			notesTextBox.Name = "notesTextBox";
			notesTextBox.Size = new Size(594, 117);
			notesTextBox.TabIndex = 10;
			notesTextBox.Visible = false;
			// 
			// buffetCheckBox
			// 
			buffetCheckBox.AutoSize = true;
			buffetCheckBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buffetCheckBox.Location = new Point(1146, 523);
			buffetCheckBox.Name = "buffetCheckBox";
			buffetCheckBox.Size = new Size(156, 36);
			buffetCheckBox.TabIndex = 11;
			buffetCheckBox.Text = "طلب البوفيه";
			buffetCheckBox.UseVisualStyleBackColor = true;
			buffetCheckBox.CheckedChanged += buffetCheckBox_CheckedChanged;
			// 
			// buffetTextBox
			// 
			buffetTextBox.Location = new Point(523, 480);
			buffetTextBox.Multiline = true;
			buffetTextBox.Name = "buffetTextBox";
			buffetTextBox.Size = new Size(594, 120);
			buffetTextBox.TabIndex = 12;
			// 
			// specifyNotesLabel
			// 
			specifyNotesLabel.AutoSize = true;
			specifyNotesLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			specifyNotesLabel.ForeColor = Color.Red;
			specifyNotesLabel.Location = new Point(763, 275);
			specifyNotesLabel.Name = "specifyNotesLabel";
			specifyNotesLabel.Size = new Size(166, 25);
			specifyNotesLabel.TabIndex = 13;
			specifyNotesLabel.Text = "اكتب الملاحظات هنا";
			specifyNotesLabel.Visible = false;
			specifyNotesLabel.Click += specifyNotesLabel_Click;
			// 
			// specifyBuffetLabel
			// 
			specifyBuffetLabel.AutoSize = true;
			specifyBuffetLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			specifyBuffetLabel.ForeColor = Color.Red;
			specifyBuffetLabel.Location = new Point(763, 452);
			specifyBuffetLabel.Name = "specifyBuffetLabel";
			specifyBuffetLabel.Size = new Size(152, 25);
			specifyBuffetLabel.TabIndex = 14;
			specifyBuffetLabel.Text = "اكتب طلب البوفيه";
			// 
			// recordOrderButton
			// 
			recordOrderButton.BackColor = Color.AntiqueWhite;
			recordOrderButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			recordOrderButton.Location = new Point(136, 387);
			recordOrderButton.Name = "recordOrderButton";
			recordOrderButton.Size = new Size(203, 146);
			recordOrderButton.TabIndex = 15;
			recordOrderButton.Text = "سجل الطلب";
			recordOrderButton.UseVisualStyleBackColor = false;
			recordOrderButton.Click += recordOrderButton_Click;
			// 
			// resetButton
			// 
			resetButton.BackColor = Color.AntiqueWhite;
			resetButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			resetButton.Location = new Point(1063, 637);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(239, 45);
			resetButton.TabIndex = 16;
			resetButton.Text = "اعادة ادخال البيانات";
			resetButton.UseVisualStyleBackColor = false;
			resetButton.Click += resetButton_Click;
			// 
			// BFRenewBTn
			// 
			BFRenewBTn.BackColor = Color.AntiqueWhite;
			BFRenewBTn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			BFRenewBTn.Location = new Point(1211, 118);
			BFRenewBTn.Name = "BFRenewBTn";
			BFRenewBTn.Size = new Size(91, 50);
			BFRenewBTn.TabIndex = 17;
			BFRenewBTn.Text = "تجديد";
			BFRenewBTn.UseVisualStyleBackColor = false;
			BFRenewBTn.Click += BFRenewBTn_Click;
			// 
			// LunchRenewBTN
			// 
			LunchRenewBTN.BackColor = Color.AntiqueWhite;
			LunchRenewBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			LunchRenewBTN.Location = new Point(790, 118);
			LunchRenewBTN.Name = "LunchRenewBTN";
			LunchRenewBTN.Size = new Size(91, 50);
			LunchRenewBTN.TabIndex = 18;
			LunchRenewBTN.Text = "تجديد";
			LunchRenewBTN.UseVisualStyleBackColor = false;
			LunchRenewBTN.Click += LunchRenewBTN_Click;
			// 
			// DinnerRenewBTN
			// 
			DinnerRenewBTN.BackColor = Color.AntiqueWhite;
			DinnerRenewBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			DinnerRenewBTN.Location = new Point(341, 118);
			DinnerRenewBTN.Name = "DinnerRenewBTN";
			DinnerRenewBTN.Size = new Size(91, 50);
			DinnerRenewBTN.TabIndex = 19;
			DinnerRenewBTN.Text = "تجديد";
			DinnerRenewBTN.UseVisualStyleBackColor = false;
			DinnerRenewBTN.Click += DinnerRenewBTN_Click;
			// 
			// mealTypeLBL
			// 
			mealTypeLBL.AutoSize = true;
			mealTypeLBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			mealTypeLBL.Location = new Point(523, 25);
			mealTypeLBL.Name = "mealTypeLBL";
			mealTypeLBL.Size = new Size(110, 25);
			mealTypeLBL.TabIndex = 20;
			mealTypeLBL.Text = "نوع الاشتراك";
			// 
			// RecordOrder
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1314, 694);
			Controls.Add(mealTypeLBL);
			Controls.Add(DinnerRenewBTN);
			Controls.Add(LunchRenewBTN);
			Controls.Add(BFRenewBTn);
			Controls.Add(resetButton);
			Controls.Add(recordOrderButton);
			Controls.Add(specifyBuffetLabel);
			Controls.Add(specifyNotesLabel);
			Controls.Add(buffetTextBox);
			Controls.Add(buffetCheckBox);
			Controls.Add(notesTextBox);
			Controls.Add(notesLabel);
			Controls.Add(LaunchComboBox);
			Controls.Add(DinnerComboBox);
			Controls.Add(BreakfastComboBox);
			Controls.Add(phoneLabel);
			Controls.Add(breakfastRemLabel);
			Controls.Add(launchRemLabel);
			Controls.Add(DinnerRemLabel);
			Controls.Add(subCountLabel);
			Controls.Add(nameLabel);
			MaximizeBox = false;
			Name = "RecordOrder";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Record Order Page";
			FormClosing += RecordOrder_FormClosing;
			Load += RecordOrder_Load;
			KeyDown += RecordOrder_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label nameLabel;
        private Label subCountLabel;
        private Label DinnerRemLabel;
        private Label launchRemLabel;
        private Label breakfastRemLabel;
        private Label phoneLabel;
        private ComboBox BreakfastComboBox;
        private ComboBox DinnerComboBox;
        private ComboBox LaunchComboBox;
        private Label notesLabel;
        private TextBox notesTextBox;
        private CheckBox buffetCheckBox;
        private TextBox buffetTextBox;
        private Label specifyNotesLabel;
        private Label specifyBuffetLabel;
        private Button recordOrderButton;
        private Button resetButton;
		private Button BFRenewBTn;
		private Button LunchRenewBTN;
		private Button DinnerRenewBTN;
		private Label mealTypeLBL;
	}
}