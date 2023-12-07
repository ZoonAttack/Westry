namespace Westry
{
    partial class AdminPage
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
            cashiersInfo = new TextBox();
            addCashierButton = new Button();
            deleteCashierButton = new Button();
            viewClientsButton = new Button();
            viewDailyButton = new Button();
            SuspendLayout();
            // 
            // cashiersInfo
            // 
            cashiersInfo.BackColor = SystemColors.Window;
            cashiersInfo.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cashiersInfo.Location = new Point(59, 12);
            cashiersInfo.Multiline = true;
            cashiersInfo.Name = "cashiersInfo";
            cashiersInfo.ReadOnly = true;
            cashiersInfo.Size = new Size(652, 155);
            cashiersInfo.TabIndex = 0;
            cashiersInfo.TextChanged += cashiersInfo_TextChanged;
            // 
            // addCashierButton
            // 
            addCashierButton.BackColor = Color.AntiqueWhite;
            addCashierButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addCashierButton.Location = new Point(71, 205);
            addCashierButton.Name = "addCashierButton";
            addCashierButton.Size = new Size(146, 79);
            addCashierButton.TabIndex = 1;
            addCashierButton.Text = "Add Cashier";
            addCashierButton.UseVisualStyleBackColor = false;
            addCashierButton.Click += addCashierButton_Click;
            // 
            // deleteCashierButton
            // 
            deleteCashierButton.BackColor = Color.AntiqueWhite;
            deleteCashierButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCashierButton.Location = new Point(565, 205);
            deleteCashierButton.Name = "deleteCashierButton";
            deleteCashierButton.Size = new Size(146, 79);
            deleteCashierButton.TabIndex = 2;
            deleteCashierButton.Text = "Delete Cashier";
            deleteCashierButton.UseVisualStyleBackColor = false;
            deleteCashierButton.Click += deleteCashierButton_Click;
            // 
            // viewClientsButton
            // 
            viewClientsButton.BackColor = Color.AntiqueWhite;
            viewClientsButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            viewClientsButton.Location = new Point(71, 359);
            viewClientsButton.Name = "viewClientsButton";
            viewClientsButton.Size = new Size(146, 79);
            viewClientsButton.TabIndex = 3;
            viewClientsButton.Text = "View Clients data";
            viewClientsButton.UseVisualStyleBackColor = false;
            viewClientsButton.Click += viewClientsButton_Click;
            // 
            // viewDailyButton
            // 
            viewDailyButton.BackColor = Color.AntiqueWhite;
            viewDailyButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            viewDailyButton.Location = new Point(565, 359);
            viewDailyButton.Name = "viewDailyButton";
            viewDailyButton.Size = new Size(146, 79);
            viewDailyButton.TabIndex = 4;
            viewDailyButton.Text = "View Daily log";
            viewDailyButton.UseVisualStyleBackColor = false;
            viewDailyButton.Click += viewDailyButton_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(viewDailyButton);
            Controls.Add(viewClientsButton);
            Controls.Add(deleteCashierButton);
            Controls.Add(addCashierButton);
            Controls.Add(cashiersInfo);
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cashiersInfo;
        private Button addCashierButton;
        private Button deleteCashierButton;
        private Button viewClientsButton;
        private Button viewDailyButton;
    }
}