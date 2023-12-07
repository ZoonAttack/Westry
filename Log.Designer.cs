namespace Westry
{
    partial class Log
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
            pdfButton = new Button();
            logBox = new TextBox();
            SuspendLayout();
            // 
            // pdfButton
            // 
            pdfButton.BackColor = Color.AntiqueWhite;
            pdfButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pdfButton.Location = new Point(331, 242);
            pdfButton.Name = "pdfButton";
            pdfButton.Size = new Size(146, 79);
            pdfButton.TabIndex = 8;
            pdfButton.Text = "Export PDF";
            pdfButton.UseVisualStyleBackColor = false;
            pdfButton.Click += pdfButton_Click;
            // 
            // logBox
            // 
            logBox.BackColor = SystemColors.Window;
            logBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            logBox.Location = new Point(74, 12);
            logBox.Multiline = true;
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.Size = new Size(652, 155);
            logBox.TabIndex = 5;
            logBox.TextChanged += logBox_TextChanged;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pdfButton);
            Controls.Add(logBox);
            Name = "Log";
            Text = "Log";
            Load += Log_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pdfButton;
        private TextBox logBox;
    }
}