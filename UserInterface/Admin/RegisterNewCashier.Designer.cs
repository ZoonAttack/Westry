namespace Westry
{
    partial class RegisterNewCashier
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
			addButton = new Button();
			passwordBox = new TextBox();
			nameBox = new TextBox();
			passwordLabel = new Label();
			nameLabel = new Label();
			SuspendLayout();
			// 
			// addButton
			// 
			addButton.BackColor = Color.AntiqueWhite;
			addButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			addButton.ForeColor = SystemColors.ControlText;
			addButton.Location = new Point(188, 182);
			addButton.Name = "addButton";
			addButton.Size = new Size(116, 51);
			addButton.TabIndex = 9;
			addButton.Text = "تسجيل";
			addButton.UseVisualStyleBackColor = false;
			addButton.Click += addButton_Click;
			// 
			// passwordBox
			// 
			passwordBox.Location = new Point(327, 229);
			passwordBox.Name = "passwordBox";
			passwordBox.Size = new Size(154, 23);
			passwordBox.TabIndex = 8;
			passwordBox.TextChanged += passwordBox_TextChanged;
			// 
			// nameBox
			// 
			nameBox.Location = new Point(327, 170);
			nameBox.Name = "nameBox";
			nameBox.Size = new Size(154, 23);
			nameBox.TabIndex = 7;
			nameBox.TextChanged += nameBox_TextChanged;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			passwordLabel.Location = new Point(487, 221);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(120, 31);
			passwordLabel.TabIndex = 6;
			passwordLabel.Text = "كلمة المرور";
			passwordLabel.Click += passwordLabel_Click;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			nameLabel.Location = new Point(487, 162);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(58, 31);
			nameLabel.TabIndex = 5;
			nameLabel.Text = "الاسم";
			nameLabel.Click += nameLabel_Click;
			// 
			// RegisterNewCashier
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(addButton);
			Controls.Add(passwordBox);
			Controls.Add(nameBox);
			Controls.Add(passwordLabel);
			Controls.Add(nameLabel);
			MaximizeBox = false;
			Name = "RegisterNewCashier";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AddCashierPage";
			FormClosed += RegisterNewCashier_FormClosed;
			Load += RegisterNewCashier_Load;
			KeyDown += RegisterNewCashier_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button addButton;
        private TextBox passwordBox;
        private TextBox nameBox;
        private Label passwordLabel;
        private Label nameLabel;
    }
}