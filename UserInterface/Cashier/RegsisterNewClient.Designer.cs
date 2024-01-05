namespace Westry
{
    partial class RegsisterNewClient
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
			registerButton = new Button();
			phoneBox = new TextBox();
			nameBox = new TextBox();
			phoneLabel = new Label();
			nameLabel = new Label();
			mealsBox = new GroupBox();
			mealTypeComboBox = new ComboBox();
			mealsBox.SuspendLayout();
			SuspendLayout();
			// 
			// registerButton
			// 
			registerButton.BackColor = Color.AntiqueWhite;
			registerButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			registerButton.ForeColor = SystemColors.ControlText;
			registerButton.Location = new Point(328, 256);
			registerButton.Name = "registerButton";
			registerButton.Size = new Size(154, 66);
			registerButton.TabIndex = 16;
			registerButton.Text = "تسجيل العميل";
			registerButton.UseVisualStyleBackColor = false;
			registerButton.Click += registerButton_Click;
			// 
			// phoneBox
			// 
			phoneBox.Location = new Point(328, 210);
			phoneBox.Name = "phoneBox";
			phoneBox.Size = new Size(154, 23);
			phoneBox.TabIndex = 14;
			phoneBox.TextChanged += phoneBox_TextChanged;
			phoneBox.KeyPress += phoneBox_KeyPress;
			// 
			// nameBox
			// 
			nameBox.Location = new Point(328, 151);
			nameBox.Name = "nameBox";
			nameBox.Size = new Size(154, 23);
			nameBox.TabIndex = 13;
			nameBox.KeyPress += nameBox_KeyPress;
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			phoneLabel.Location = new Point(488, 202);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new Size(107, 31);
			phoneLabel.TabIndex = 12;
			phoneLabel.Text = "رقم الهاتف";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			nameLabel.Location = new Point(488, 143);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(105, 31);
			nameLabel.TabIndex = 11;
			nameLabel.Text = "اسم العميل";
			// 
			// mealsBox
			// 
			mealsBox.Controls.Add(mealTypeComboBox);
			mealsBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			mealsBox.ForeColor = SystemColors.ControlText;
			mealsBox.Location = new Point(97, 126);
			mealsBox.Name = "mealsBox";
			mealsBox.Size = new Size(200, 79);
			mealsBox.TabIndex = 17;
			mealsBox.TabStop = false;
			mealsBox.Text = "نوع الاشتراك";
			// 
			// mealTypeComboBox
			// 
			mealTypeComboBox.FormattingEnabled = true;
			mealTypeComboBox.Location = new Point(6, 38);
			mealTypeComboBox.Name = "mealTypeComboBox";
			mealTypeComboBox.Size = new Size(188, 29);
			mealTypeComboBox.TabIndex = 0;
			// 
			// RegsisterNewClient
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(mealsBox);
			Controls.Add(registerButton);
			Controls.Add(phoneBox);
			Controls.Add(nameBox);
			Controls.Add(phoneLabel);
			Controls.Add(nameLabel);
			MaximizeBox = false;
			Name = "RegsisterNewClient";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "userRegistrationPage";
			FormClosing += RegsisterNewClient_FormClosing;
			Load += RegsisterNewClient_Load;
			KeyDown += RegsisterNewClient_KeyDown;
			mealsBox.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button registerButton;
        private TextBox phoneBox;
        private TextBox nameBox;
        private Label phoneLabel;
        private Label nameLabel;
        private GroupBox mealsBox;
		private ComboBox mealTypeComboBox;
	}
}