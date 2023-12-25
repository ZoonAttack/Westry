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
			TimeTaken = new DataGridViewTextBoxColumn();
			mealLogBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)LogDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)mealLogBindingSource).BeginInit();
			SuspendLayout();
			// 
			// pdfButton
			// 
			pdfButton.BackColor = Color.AntiqueWhite;
			pdfButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			pdfButton.Location = new Point(321, 573);
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
			LogDataGridView.Columns.AddRange(new DataGridViewColumn[] { phoneNumberDataGridViewTextBoxColumn, mealIdDataGridViewTextBoxColumn, choosenmealDataGridViewTextBoxColumn, TimeTaken });
			LogDataGridView.DataSource = mealLogBindingSource;
			LogDataGridView.Location = new Point(27, 12);
			LogDataGridView.Name = "LogDataGridView";
			LogDataGridView.ReadOnly = true;
			LogDataGridView.RowTemplate.Height = 25;
			LogDataGridView.Size = new Size(743, 555);
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
			// TimeTaken
			// 
			TimeTaken.DataPropertyName = "TimeTaken";
			TimeTaken.HeaderText = "TimeTaken";
			TimeTaken.Name = "TimeTaken";
			TimeTaken.ReadOnly = true;
			TimeTaken.Width = 150;
			// 
			// mealLogBindingSource
			// 
			mealLogBindingSource.DataSource = typeof(Models.MealLog);
			// 
			// LogWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(800, 664);
			Controls.Add(LogDataGridView);
			Controls.Add(pdfButton);
			Name = "LogWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Log";
			FormClosed += LogWindow_FormClosed;
			Load += Log_Load;
			KeyDown += LogWindow_KeyDown;
			((System.ComponentModel.ISupportInitialize)LogDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)mealLogBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button pdfButton;
        private DataGridView LogDataGridView;
		private BindingSource mealLogBindingSource;
		private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mealIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn choosenmealDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn TimeTaken;
	}
}