namespace Westry
{
    partial class SearchCustomer
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
			searchButton = new Button();
			phoneBox = new TextBox();
			phoneLabel = new Label();
			newUserButton = new Button();
			SuspendLayout();
			// 
			// searchButton
			// 
			searchButton.BackColor = Color.AntiqueWhite;
			searchButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			searchButton.ForeColor = SystemColors.ControlText;
			searchButton.Location = new Point(189, 204);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(116, 51);
			searchButton.TabIndex = 9;
			searchButton.Text = "بحث";
			searchButton.UseVisualStyleBackColor = false;
			searchButton.Click += searchButton_Click;
			// 
			// phoneBox
			// 
			phoneBox.Location = new Point(311, 215);
			phoneBox.Name = "phoneBox";
			phoneBox.Size = new Size(171, 23);
			phoneBox.TabIndex = 8;
			phoneBox.TextChanged += phoneBox_TextChanged;
			phoneBox.KeyPress += phoneBox_KeyPress;
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			phoneLabel.Location = new Point(515, 215);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new Size(107, 31);
			phoneLabel.TabIndex = 6;
			phoneLabel.Text = "رقم الهاتف";
			phoneLabel.Click += phoneLabel_Click;
			// 
			// newUserButton
			// 
			newUserButton.BackColor = Color.AntiqueWhite;
			newUserButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
			newUserButton.ForeColor = SystemColors.ControlText;
			newUserButton.Location = new Point(655, 364);
			newUserButton.Name = "newUserButton";
			newUserButton.Size = new Size(133, 74);
			newUserButton.TabIndex = 10;
			newUserButton.Text = "تسجيل عميل جديد";
			newUserButton.UseVisualStyleBackColor = false;
			newUserButton.Click += newUserButton_Click;
			// 
			// SearchCustomer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(newUserButton);
			Controls.Add(searchButton);
			Controls.Add(phoneBox);
			Controls.Add(phoneLabel);
			Name = "SearchCustomer";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cashier Page";
			FormClosed += SearchCustomer_FormClosed;
			Load += SearchCustomer_Load;
			KeyDown += SearchCustomer_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button searchButton;
        private TextBox phoneBox;
        private Label phoneLabel;
        private Button newUserButton;
    }
}