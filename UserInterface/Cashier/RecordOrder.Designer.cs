namespace Westry
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
			dinnerRemLabel = new Label();
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
			SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			nameLabel.Location = new Point(12, 25);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(59, 25);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "name";
			// 
			// subCountLabel
			// 
			subCountLabel.AutoSize = true;
			subCountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			subCountLabel.Location = new Point(12, 99);
			subCountLabel.Name = "subCountLabel";
			subCountLabel.Size = new Size(168, 25);
			subCountLabel.TabIndex = 1;
			subCountLabel.Text = "subscription count";
			// 
			// dinnerRemLabel
			// 
			dinnerRemLabel.AutoSize = true;
			dinnerRemLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			dinnerRemLabel.Location = new Point(12, 135);
			dinnerRemLabel.Name = "dinnerRemLabel";
			dinnerRemLabel.Size = new Size(214, 25);
			dinnerRemLabel.TabIndex = 2;
			dinnerRemLabel.Text = "Dinner remaining meals";
			// 
			// launchRemLabel
			// 
			launchRemLabel.AutoSize = true;
			launchRemLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			launchRemLabel.Location = new Point(531, 135);
			launchRemLabel.Name = "launchRemLabel";
			launchRemLabel.Size = new Size(218, 25);
			launchRemLabel.TabIndex = 3;
			launchRemLabel.Text = "Launch remaining meals";
			// 
			// breakfastRemLabel
			// 
			breakfastRemLabel.AutoSize = true;
			breakfastRemLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			breakfastRemLabel.Location = new Point(983, 135);
			breakfastRemLabel.Name = "breakfastRemLabel";
			breakfastRemLabel.Size = new Size(234, 25);
			breakfastRemLabel.TabIndex = 4;
			breakfastRemLabel.Text = "Breakfast remaining meals";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			phoneLabel.Location = new Point(12, 60);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new Size(66, 25);
			phoneLabel.TabIndex = 5;
			phoneLabel.Text = "phone";
			// 
			// BreakfastComboBox
			// 
			BreakfastComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			BreakfastComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			BreakfastComboBox.FormattingEnabled = true;
			BreakfastComboBox.Items.AddRange(new object[] { "عصير -برش مربه- برشن عسل -نوع جبنه - بيضه مسلوقه -معيش الطازج", "اختيار اي 3 سندوتشات من فيل الفينو", "قطعتين من الباتيه او الكرواسون مع الشاي او النسكافيه", "آخر" });
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
			DinnerComboBox.Items.AddRange(new object[] { "( البيتزا): مرجريتا -- او بيتزا الخضار -- او بيتزا الهوت دوج", "البرجر مع الكلوسلو سلاط والبوم فريت", "4 سندوتشات من فيل افينو", "قطع 3من دجاج الاستربس مع البوم فريت", "آخر" });
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
			LaunchComboBox.Items.AddRange(new object[] { "وجبة البوفتيك والأرز والبوم فريت", "وجبة الاستربس مع الأرز والبوم فريت", "وجبة الكفته والأرز والبوم الفريت", "وجبة الفراخ المشوية مع الأرز والبوم فريت", "آخر" });
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
			// 
			// notesTextBox
			// 
			notesTextBox.Location = new Point(523, 303);
			notesTextBox.Multiline = true;
			notesTextBox.Name = "notesTextBox";
			notesTextBox.Size = new Size(594, 117);
			notesTextBox.TabIndex = 10;
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
			specifyNotesLabel.Size = new Size(134, 25);
			specifyNotesLabel.TabIndex = 13;
			specifyNotesLabel.Text = "اكتب الطلب هنا";
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
			resetButton.Location = new Point(1194, 637);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(108, 45);
			resetButton.TabIndex = 16;
			resetButton.Text = "reset";
			resetButton.UseVisualStyleBackColor = false;
			resetButton.Click += resetButton_Click;
			// 
			// RecordOrder
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1314, 694);
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
			Controls.Add(dinnerRemLabel);
			Controls.Add(subCountLabel);
			Controls.Add(nameLabel);
			Name = "RecordOrder";
			Text = "Record Order Page";
			FormClosing += RecordOrder_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label nameLabel;
        private Label subCountLabel;
        private Label dinnerRemLabel;
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
    }
}