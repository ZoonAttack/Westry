namespace Westry.UserInterface.Admin
{
	partial class newOptDialog
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
			ConfirmBTN = new Button();
			CancelBTN = new Button();
			optNameTB = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// ConfirmBTN
			// 
			ConfirmBTN.BackColor = Color.AntiqueWhite;
			ConfirmBTN.DialogResult = DialogResult.OK;
			ConfirmBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			ConfirmBTN.Location = new Point(206, 97);
			ConfirmBTN.Name = "ConfirmBTN";
			ConfirmBTN.Size = new Size(109, 52);
			ConfirmBTN.TabIndex = 27;
			ConfirmBTN.Text = "إضافه";
			ConfirmBTN.UseVisualStyleBackColor = false;
			ConfirmBTN.Click += ConfirmBTN_Click;
			// 
			// CancelBTN
			// 
			CancelBTN.BackColor = Color.AntiqueWhite;
			CancelBTN.DialogResult = DialogResult.Cancel;
			CancelBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			CancelBTN.Location = new Point(12, 97);
			CancelBTN.Name = "CancelBTN";
			CancelBTN.Size = new Size(109, 52);
			CancelBTN.TabIndex = 28;
			CancelBTN.Text = "إلغاء";
			CancelBTN.UseVisualStyleBackColor = false;
			// 
			// optNameTB
			// 
			optNameTB.Location = new Point(12, 44);
			optNameTB.Name = "optNameTB";
			optNameTB.Size = new Size(207, 23);
			optNameTB.TabIndex = 29;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(225, 44);
			label1.Name = "label1";
			label1.Size = new Size(101, 25);
			label1.TabIndex = 30;
			label1.Text = "اسم الاختيار";
			// 
			// newOptDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(327, 157);
			ControlBox = false;
			Controls.Add(label1);
			Controls.Add(optNameTB);
			Controls.Add(CancelBTN);
			Controls.Add(ConfirmBTN);
			Name = "newOptDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "newOptDialog";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button ConfirmBTN;
		private Button CancelBTN;
		private TextBox optNameTB;
		private Label label1;
	}
}