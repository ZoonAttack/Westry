namespace Westry
{
    partial class DeleteCashierPage
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
            cashierNameTextBox = new TextBox();
            cashierNameLabel = new Label();
            deleteCashierButton = new Button();
            SuspendLayout();
            // 
            // cashierNameTextBox
            // 
            cashierNameTextBox.Location = new Point(12, 107);
            cashierNameTextBox.Name = "cashierNameTextBox";
            cashierNameTextBox.Size = new Size(215, 23);
            cashierNameTextBox.TabIndex = 0;
            // 
            // cashierNameLabel
            // 
            cashierNameLabel.AutoSize = true;
            cashierNameLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cashierNameLabel.Location = new Point(233, 99);
            cashierNameLabel.Name = "cashierNameLabel";
            cashierNameLabel.Size = new Size(113, 31);
            cashierNameLabel.TabIndex = 1;
            cashierNameLabel.Text = "اسم الكاشير";
            // 
            // deleteCashierButton
            // 
            deleteCashierButton.BackColor = Color.AntiqueWhite;
            deleteCashierButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCashierButton.Location = new Point(76, 201);
            deleteCashierButton.Name = "deleteCashierButton";
            deleteCashierButton.Size = new Size(217, 70);
            deleteCashierButton.TabIndex = 2;
            deleteCashierButton.Text = "حذف الحساب";
            deleteCashierButton.UseVisualStyleBackColor = false;
            deleteCashierButton.Click += deleteCashierButton_Click;
            // 
            // DeleteCashierPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(372, 341);
            Controls.Add(deleteCashierButton);
            Controls.Add(cashierNameLabel);
            Controls.Add(cashierNameTextBox);
            Name = "DeleteCashierPage";
            Text = "Delete Cashier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cashierNameTextBox;
        private Label cashierNameLabel;
        private Button deleteCashierButton;
    }
}