﻿namespace Westry
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			nameLabel = new Label();
			passwordLabel = new Label();
			nameBox = new TextBox();
			passwordBox = new TextBox();
			loginButton = new Button();
			SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.Anchor = AnchorStyles.None;
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			nameLabel.Location = new Point(536, 156);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(126, 31);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "اسم المستخدم";
			nameLabel.Click += nameLabel_Click;
			// 
			// passwordLabel
			// 
			passwordLabel.Anchor = AnchorStyles.None;
			passwordLabel.AutoSize = true;
			passwordLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			passwordLabel.Location = new Point(536, 207);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(120, 31);
			passwordLabel.TabIndex = 1;
			passwordLabel.Text = "كلمة المرور";
			passwordLabel.Click += passwordLabel_Click;
			// 
			// nameBox
			// 
			nameBox.Anchor = AnchorStyles.None;
			nameBox.Location = new Point(355, 156);
			nameBox.Name = "nameBox";
			nameBox.Size = new Size(154, 23);
			nameBox.TabIndex = 2;
			nameBox.TextChanged += nameBox_TextChanged;
			// 
			// passwordBox
			// 
			passwordBox.Anchor = AnchorStyles.None;
			passwordBox.Location = new Point(355, 207);
			passwordBox.Name = "passwordBox";
			passwordBox.Size = new Size(154, 23);
			passwordBox.TabIndex = 3;
			passwordBox.UseSystemPasswordChar = true;
			passwordBox.TextChanged += passwordBox_TextChanged;
			// 
			// loginButton
			// 
			loginButton.Anchor = AnchorStyles.None;
			loginButton.BackColor = Color.AntiqueWhite;
			loginButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			loginButton.ForeColor = SystemColors.ControlText;
			loginButton.Location = new Point(178, 167);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(155, 51);
			loginButton.TabIndex = 4;
			loginButton.Text = "تسجيل الدخول";
			loginButton.UseVisualStyleBackColor = false;
			loginButton.Click += loginButton_Click;
			// 
			// LoginPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(loginButton);
			Controls.Add(passwordBox);
			Controls.Add(nameBox);
			Controls.Add(passwordLabel);
			Controls.Add(nameLabel);
			Name = "LoginPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Westry";
			FormClosing += LoginPage_FormClosing;
			FormClosed += LoginPage_FormClosed;
			Load += LoginPage_Load;
			KeyDown += LoginPage_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label nameLabel;
        private Label passwordLabel;
        private TextBox nameBox;
        private TextBox passwordBox;
        private Button loginButton;
    }
}