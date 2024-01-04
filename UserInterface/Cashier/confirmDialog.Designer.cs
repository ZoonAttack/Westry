namespace Westry.UserInterface.Cashier
{
	partial class confirmDialog
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
			w = new Label();
			BFRenewBTn = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// w
			// 
			w.AutoSize = true;
			w.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			w.Location = new Point(65, 35);
			w.Name = "w";
			w.Size = new Size(186, 25);
			w.TabIndex = 3;
			w.Text = "تجديد الوجبه المحدده؟";
			// 
			// BFRenewBTn
			// 
			BFRenewBTn.BackColor = Color.AntiqueWhite;
			BFRenewBTn.DialogResult = DialogResult.OK;
			BFRenewBTn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			BFRenewBTn.Location = new Point(224, 95);
			BFRenewBTn.Name = "BFRenewBTn";
			BFRenewBTn.Size = new Size(91, 50);
			BFRenewBTn.TabIndex = 18;
			BFRenewBTn.Text = "تجديد";
			BFRenewBTn.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = Color.AntiqueWhite;
			button1.DialogResult = DialogResult.Cancel;
			button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(12, 95);
			button1.Name = "button1";
			button1.Size = new Size(91, 50);
			button1.TabIndex = 19;
			button1.Text = "إلغاء";
			button1.UseVisualStyleBackColor = false;
			// 
			// confirmDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(327, 157);
			Controls.Add(button1);
			Controls.Add(BFRenewBTn);
			Controls.Add(w);
			Name = "confirmDialog";
			Text = "confirmDialog";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label w;
		private Button BFRenewBTn;
		private Button button1;
	}
}