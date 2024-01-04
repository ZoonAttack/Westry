namespace Westry
{
    partial class AdminPanel
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
			components = new System.ComponentModel.Container();
			addCashierButton = new Button();
			deleteCashierButton = new Button();
			viewClientsButton = new Button();
			viewDailyButton = new Button();
			cashierInfoDataGridView = new DataGridView();
			userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			cashierBindingSource = new BindingSource(components);
			editMeals = new Button();
			((System.ComponentModel.ISupportInitialize)cashierInfoDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)cashierBindingSource).BeginInit();
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
			deleteCashierButton.Location = new Point(266, 345);
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
			viewDailyButton.Location = new Point(266, 449);
			viewDailyButton.Name = "viewDailyButton";
			viewDailyButton.Size = new Size(146, 79);
			viewDailyButton.TabIndex = 4;
			viewDailyButton.Text = "سجل الطلبات";
			viewDailyButton.UseVisualStyleBackColor = false;
			viewDailyButton.Click += viewDailyButton_Click;
			// 
			// cashierInfoDataGridView
			// 
			cashierInfoDataGridView.AllowUserToAddRows = false;
			cashierInfoDataGridView.AllowUserToDeleteRows = false;
			cashierInfoDataGridView.AutoGenerateColumns = false;
			cashierInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			cashierInfoDataGridView.Columns.AddRange(new DataGridViewColumn[] { userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
			cashierInfoDataGridView.DataSource = cashierBindingSource;
			cashierInfoDataGridView.Location = new Point(71, 12);
			cashierInfoDataGridView.Name = "cashierInfoDataGridView";
			cashierInfoDataGridView.ReadOnly = true;
			cashierInfoDataGridView.RowTemplate.Height = 25;
			cashierInfoDataGridView.Size = new Size(640, 303);
			cashierInfoDataGridView.TabIndex = 5;
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
			userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			userNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			passwordDataGridViewTextBoxColumn.HeaderText = "Password";
			passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			passwordDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cashierBindingSource
			// 
			cashierBindingSource.DataSource = typeof(Models.Cashier);
			// 
			// editMeals
			// 
			editMeals.BackColor = Color.AntiqueWhite;
			editMeals.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			editMeals.Location = new Point(565, 345);
			editMeals.Name = "editMeals";
			editMeals.Size = new Size(146, 79);
			editMeals.TabIndex = 6;
			editMeals.Text = "تعديل الوجبات";
			editMeals.UseVisualStyleBackColor = false;
			editMeals.Click += editMeals_Click;
			// 
			// AdminPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(800, 540);
			Controls.Add(editMeals);
			Controls.Add(cashierInfoDataGridView);
			Controls.Add(viewDailyButton);
			Controls.Add(viewClientsButton);
			Controls.Add(deleteCashierButton);
			Controls.Add(addCashierButton);
			Name = "AdminPanel";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AdminPage";
			FormClosed += AdminPanel_FormClosed;
			Load += AdminPanel_Load;
			((System.ComponentModel.ISupportInitialize)cashierInfoDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)cashierBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button addCashierButton;
        private Button deleteCashierButton;
        private Button viewClientsButton;
        private Button viewDailyButton;
        private DataGridView cashierInfoDataGridView;
		private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private BindingSource cashierBindingSource;
		private Button editMeals;
	}
}