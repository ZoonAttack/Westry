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
            addCashierButton = new Button();
            deleteCashierButton = new Button();
            viewClientsButton = new Button();
            viewDailyButton = new Button();
            cashierInfoDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cashierInfoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addCashierButton
            // 
            addCashierButton.BackColor = Color.AntiqueWhite;
            addCashierButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addCashierButton.Location = new Point(71, 345);
            addCashierButton.Name = "addCashierButton";
            addCashierButton.Size = new Size(146, 79);
            addCashierButton.TabIndex = 1;
            addCashierButton.Text = "تسجيل كاشير جديد";
            addCashierButton.UseVisualStyleBackColor = false;
            addCashierButton.Click += addCashierButton_Click;
            // 
            // deleteCashierButton
            // 
            deleteCashierButton.BackColor = Color.AntiqueWhite;
            deleteCashierButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCashierButton.Location = new Point(565, 345);
            deleteCashierButton.Name = "deleteCashierButton";
            deleteCashierButton.Size = new Size(146, 79);
            deleteCashierButton.TabIndex = 2;
            deleteCashierButton.Text = "حذف كاشير";
            deleteCashierButton.UseVisualStyleBackColor = false;
            deleteCashierButton.Click += deleteCashierButton_Click;
            // 
            // viewClientsButton
            // 
            viewClientsButton.BackColor = Color.AntiqueWhite;
            viewClientsButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            viewClientsButton.Location = new Point(71, 449);
            viewClientsButton.Name = "viewClientsButton";
            viewClientsButton.Size = new Size(146, 79);
            viewClientsButton.TabIndex = 3;
            viewClientsButton.Text = "بيانات العملاء";
            viewClientsButton.UseVisualStyleBackColor = false;
            viewClientsButton.Click += viewClientsButton_Click;
            // 
            // viewDailyButton
            // 
            viewDailyButton.BackColor = Color.AntiqueWhite;
            viewDailyButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            viewDailyButton.Location = new Point(565, 449);
            viewDailyButton.Name = "viewDailyButton";
            viewDailyButton.Size = new Size(146, 79);
            viewDailyButton.TabIndex = 4;
            viewDailyButton.Text = "سجل الطلبات اليومي";
            viewDailyButton.UseVisualStyleBackColor = false;
            viewDailyButton.Click += viewDailyButton_Click;
            // 
            // cashierInfoDataGridView
            // 
            cashierInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierInfoDataGridView.Location = new Point(71, 12);
            cashierInfoDataGridView.Name = "cashierInfoDataGridView";
            cashierInfoDataGridView.RowTemplate.Height = 25;
            cashierInfoDataGridView.Size = new Size(640, 303);
            cashierInfoDataGridView.TabIndex = 5;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 540);
            Controls.Add(cashierInfoDataGridView);
            Controls.Add(viewDailyButton);
            Controls.Add(viewClientsButton);
            Controls.Add(deleteCashierButton);
            Controls.Add(addCashierButton);
            Name = "AdminPage";
            Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)cashierInfoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addCashierButton;
        private Button deleteCashierButton;
        private Button viewClientsButton;
        private Button viewDailyButton;
        private DataGridView cashierInfoDataGridView;
    }
}