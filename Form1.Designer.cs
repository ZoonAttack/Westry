namespace Westry
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
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(205, 148);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(129, 31);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "User name";
            nameLabel.Click += nameLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(205, 207);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(117, 31);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(355, 156);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(154, 23);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(355, 207);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(154, 23);
            passwordBox.TabIndex = 3;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.AntiqueWhite;
            loginButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ControlText;
            loginButton.Location = new Point(531, 167);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(116, 51);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(passwordBox);
            Controls.Add(nameBox);
            Controls.Add(passwordLabel);
            Controls.Add(nameLabel);
            Name = "LoginPage";
            Text = "Westry";
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