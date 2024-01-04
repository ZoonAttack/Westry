namespace Westry
{
    partial class ViewClients
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
			ClientsDataGridView = new DataGridView();
			customerBindingSource = new BindingSource(components);
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			mealIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			subscriptionCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			breakfastCounterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			lunchCounterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dinnerCounterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			createdBy = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)ClientsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
			SuspendLayout();
			// 
			// ClientsDataGridView
			// 
			ClientsDataGridView.AllowUserToAddRows = false;
			ClientsDataGridView.AllowUserToDeleteRows = false;
			ClientsDataGridView.AutoGenerateColumns = false;
			ClientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ClientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, mealIdDataGridViewTextBoxColumn, subscriptionCountDataGridViewTextBoxColumn, breakfastCounterDataGridViewTextBoxColumn, lunchCounterDataGridViewTextBoxColumn, dinnerCounterDataGridViewTextBoxColumn, createdBy });
			ClientsDataGridView.DataSource = customerBindingSource;
			ClientsDataGridView.Location = new Point(12, 12);
			ClientsDataGridView.Name = "ClientsDataGridView";
			ClientsDataGridView.ReadOnly = true;
			ClientsDataGridView.RowTemplate.Height = 25;
			ClientsDataGridView.Size = new Size(861, 660);
			ClientsDataGridView.TabIndex = 0;
			// 
			// customerBindingSource
			// 
			customerBindingSource.DataSource = typeof(Models.Customer);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			nameDataGridViewTextBoxColumn.HeaderText = "Name";
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// mealIdDataGridViewTextBoxColumn
			// 
			mealIdDataGridViewTextBoxColumn.DataPropertyName = "MealId";
			mealIdDataGridViewTextBoxColumn.HeaderText = "MealId";
			mealIdDataGridViewTextBoxColumn.Name = "mealIdDataGridViewTextBoxColumn";
			mealIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// subscriptionCountDataGridViewTextBoxColumn
			// 
			subscriptionCountDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionCount";
			subscriptionCountDataGridViewTextBoxColumn.HeaderText = "SubscriptionCount";
			subscriptionCountDataGridViewTextBoxColumn.Name = "subscriptionCountDataGridViewTextBoxColumn";
			subscriptionCountDataGridViewTextBoxColumn.ReadOnly = true;
			subscriptionCountDataGridViewTextBoxColumn.Width = 110;
			// 
			// breakfastCounterDataGridViewTextBoxColumn
			// 
			breakfastCounterDataGridViewTextBoxColumn.DataPropertyName = "BreakfastCounter";
			breakfastCounterDataGridViewTextBoxColumn.FillWeight = 110F;
			breakfastCounterDataGridViewTextBoxColumn.HeaderText = "BreakfastCounter";
			breakfastCounterDataGridViewTextBoxColumn.Name = "breakfastCounterDataGridViewTextBoxColumn";
			breakfastCounterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lunchCounterDataGridViewTextBoxColumn
			// 
			lunchCounterDataGridViewTextBoxColumn.DataPropertyName = "LunchCounter";
			lunchCounterDataGridViewTextBoxColumn.HeaderText = "LunchCounter";
			lunchCounterDataGridViewTextBoxColumn.Name = "lunchCounterDataGridViewTextBoxColumn";
			lunchCounterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dinnerCounterDataGridViewTextBoxColumn
			// 
			dinnerCounterDataGridViewTextBoxColumn.DataPropertyName = "DinnerCounter";
			dinnerCounterDataGridViewTextBoxColumn.HeaderText = "DinnerCounter";
			dinnerCounterDataGridViewTextBoxColumn.Name = "dinnerCounterDataGridViewTextBoxColumn";
			dinnerCounterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// createdBy
			// 
			createdBy.DataPropertyName = "createdBy";
			createdBy.HeaderText = "createdBy";
			createdBy.Name = "createdBy";
			createdBy.ReadOnly = true;
			// 
			// ViewClients
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(885, 684);
			Controls.Add(ClientsDataGridView);
			Name = "ViewClients";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Clients";
			FormClosed += ViewClients_FormClosed;
			Load += ViewClients_Load;
			((System.ComponentModel.ISupportInitialize)ClientsDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView ClientsDataGridView;
		private BindingSource customerBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mealIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn subscriptionCountDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn breakfastCounterDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lunchCounterDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dinnerCounterDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn createdBy;
	}
}