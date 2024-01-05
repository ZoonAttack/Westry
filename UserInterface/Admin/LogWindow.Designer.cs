namespace Westry
{
    partial class LogWindow
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
			pdfButton = new Button();
			LogDataGridView = new DataGridView();
			phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			mealIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			choosenmealDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			isKitchen = new DataGridViewTextBoxColumn();
			isBuffet = new DataGridViewTextBoxColumn();
			TimeTaken = new DataGridViewTextBoxColumn();
			CashierName = new DataGridViewTextBoxColumn();
			mealLogBindingSource = new BindingSource(components);
			specificTimeFrom = new DateTimePicker();
			specificTimeTo = new DateTimePicker();
			FromLabel = new Label();
			ToLabel = new Label();
			specificTimeBTN = new Button();
			specificPeriodCB = new CheckBox();
			((System.ComponentModel.ISupportInitialize)LogDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)mealLogBindingSource).BeginInit();
			SuspendLayout();
			// 
			// pdfButton
			// 
			pdfButton.BackColor = Color.AntiqueWhite;
			pdfButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			pdfButton.Location = new Point(56, 573);
			pdfButton.Name = "pdfButton";
			pdfButton.Size = new Size(141, 79);
			pdfButton.TabIndex = 8;
			pdfButton.Text = "طباعة ملف PDF";
			pdfButton.UseVisualStyleBackColor = false;
			pdfButton.Click += pdfButton_Click;
			// 
			// LogDataGridView
			// 
			LogDataGridView.AllowUserToAddRows = false;
			LogDataGridView.AllowUserToDeleteRows = false;
			LogDataGridView.AutoGenerateColumns = false;
			LogDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			LogDataGridView.Columns.AddRange(new DataGridViewColumn[] { phoneNumberDataGridViewTextBoxColumn, mealIdDataGridViewTextBoxColumn, choosenmealDataGridViewTextBoxColumn, isKitchen, isBuffet, TimeTaken, CashierName });
			LogDataGridView.DataSource = mealLogBindingSource;
			LogDataGridView.Location = new Point(27, 12);
			LogDataGridView.Name = "LogDataGridView";
			LogDataGridView.ReadOnly = true;
			LogDataGridView.RowTemplate.Height = 25;
			LogDataGridView.Size = new Size(1055, 555);
			LogDataGridView.TabIndex = 9;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
			phoneNumberDataGridViewTextBoxColumn.Width = 150;
			// 
			// mealIdDataGridViewTextBoxColumn
			// 
			mealIdDataGridViewTextBoxColumn.DataPropertyName = "MealId";
			mealIdDataGridViewTextBoxColumn.HeaderText = "MealId";
			mealIdDataGridViewTextBoxColumn.Name = "mealIdDataGridViewTextBoxColumn";
			mealIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// choosenmealDataGridViewTextBoxColumn
			// 
			choosenmealDataGridViewTextBoxColumn.DataPropertyName = "choosen_meal";
			choosenmealDataGridViewTextBoxColumn.HeaderText = "choosen_meal";
			choosenmealDataGridViewTextBoxColumn.Name = "choosenmealDataGridViewTextBoxColumn";
			choosenmealDataGridViewTextBoxColumn.ReadOnly = true;
			choosenmealDataGridViewTextBoxColumn.Width = 300;
			// 
			// isKitchen
			// 
			isKitchen.DataPropertyName = "isKitchen";
			isKitchen.HeaderText = "isKitchen";
			isKitchen.Name = "isKitchen";
			isKitchen.ReadOnly = true;
			// 
			// isBuffet
			// 
			isBuffet.DataPropertyName = "isBuffet";
			isBuffet.HeaderText = "isBuffet";
			isBuffet.Name = "isBuffet";
			isBuffet.ReadOnly = true;
			// 
			// TimeTaken
			// 
			TimeTaken.DataPropertyName = "TimeTaken";
			TimeTaken.HeaderText = "TimeTaken";
			TimeTaken.Name = "TimeTaken";
			TimeTaken.ReadOnly = true;
			TimeTaken.Width = 150;
			// 
			// CashierName
			// 
			CashierName.DataPropertyName = "CashierName";
			CashierName.HeaderText = "CashierName";
			CashierName.Name = "CashierName";
			CashierName.ReadOnly = true;
			// 
			// mealLogBindingSource
			// 
			mealLogBindingSource.DataSource = typeof(Models.MealLog);
			// 
			// specificTimeFrom
			// 
			specificTimeFrom.Location = new Point(702, 585);
			specificTimeFrom.Name = "specificTimeFrom";
			specificTimeFrom.RightToLeft = RightToLeft.No;
			specificTimeFrom.Size = new Size(200, 23);
			specificTimeFrom.TabIndex = 10;
			// 
			// specificTimeTo
			// 
			specificTimeTo.Location = new Point(702, 626);
			specificTimeTo.Name = "specificTimeTo";
			specificTimeTo.Size = new Size(200, 23);
			specificTimeTo.TabIndex = 11;
			// 
			// FromLabel
			// 
			FromLabel.AutoSize = true;
			FromLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			FromLabel.Location = new Point(921, 585);
			FromLabel.Name = "FromLabel";
			FromLabel.Size = new Size(39, 31);
			FromLabel.TabIndex = 12;
			FromLabel.Text = "من";
			// 
			// ToLabel
			// 
			ToLabel.AutoSize = true;
			ToLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			ToLabel.Location = new Point(918, 620);
			ToLabel.Name = "ToLabel";
			ToLabel.Size = new Size(42, 31);
			ToLabel.TabIndex = 13;
			ToLabel.Text = "إلى";
			// 
			// specificTimeBTN
			// 
			specificTimeBTN.BackColor = Color.AntiqueWhite;
			specificTimeBTN.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			specificTimeBTN.Location = new Point(482, 573);
			specificTimeBTN.Name = "specificTimeBTN";
			specificTimeBTN.Size = new Size(141, 79);
			specificTimeBTN.TabIndex = 14;
			specificTimeBTN.Text = "بحث";
			specificTimeBTN.UseVisualStyleBackColor = false;
			specificTimeBTN.Click += specificTimeBTN_Click;
			// 
			// specificPeriodCB
			// 
			specificPeriodCB.AutoSize = true;
			specificPeriodCB.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			specificPeriodCB.Location = new Point(990, 603);
			specificPeriodCB.Name = "specificPeriodCB";
			specificPeriodCB.Size = new Size(92, 25);
			specificPeriodCB.TabIndex = 15;
			specificPeriodCB.Text = "فترة محدده";
			specificPeriodCB.UseVisualStyleBackColor = true;
			specificPeriodCB.CheckedChanged += specificPeriodCB_CheckedChanged;
			// 
			// LogWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1097, 664);
			Controls.Add(specificPeriodCB);
			Controls.Add(specificTimeBTN);
			Controls.Add(ToLabel);
			Controls.Add(FromLabel);
			Controls.Add(specificTimeTo);
			Controls.Add(specificTimeFrom);
			Controls.Add(LogDataGridView);
			Controls.Add(pdfButton);
			MaximizeBox = false;
			Name = "LogWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Log";
			FormClosed += LogWindow_FormClosed;
			Load += Log_Load;
			KeyDown += LogWindow_KeyDown;
			((System.ComponentModel.ISupportInitialize)LogDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)mealLogBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button pdfButton;
        private DataGridView LogDataGridView;
		private BindingSource mealLogBindingSource;
		private DateTimePicker specificTimeFrom;
		private DateTimePicker specificTimeTo;
		private Label FromLabel;
		private Label ToLabel;
		private Button specificTimeBTN;
		private CheckBox specificPeriodCB;
		private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mealIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn choosenmealDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn isKitchen;
		private DataGridViewTextBoxColumn isBuffet;
		private DataGridViewTextBoxColumn TimeTaken;
		private DataGridViewTextBoxColumn CashierName;
	}
}