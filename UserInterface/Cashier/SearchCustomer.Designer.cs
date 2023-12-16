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
            nameBox = new TextBox();
            phoneLabel = new Label();
            nameLabel = new Label();
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
            phoneBox.Location = new Point(329, 247);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(154, 23);
            phoneBox.TabIndex = 8;
            phoneBox.TextChanged += phoneBox_TextChanged;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(329, 188);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(154, 23);
            nameBox.TabIndex = 7;
            nameBox.TextChanged += nameBox_TextChanged;
            nameBox.KeyPress += nameBox_KeyPress;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(508, 239);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(107, 31);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "رقم الهاتف";
            phoneLabel.Click += phoneLabel_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(510, 188);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(105, 31);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "اسم العميل";
            nameLabel.Click += nameLabel_Click;
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
            // cashierPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(newUserButton);
            Controls.Add(searchButton);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Controls.Add(phoneLabel);
            Controls.Add(nameLabel);
            Name = "cashierPage";
            Text = "Cashier Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private TextBox phoneBox;
        private TextBox nameBox;
        private Label phoneLabel;
        private Label nameLabel;
        private Button newUserButton;
    }
}