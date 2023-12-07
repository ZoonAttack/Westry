namespace Westry
{
    partial class Clients
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
            clientsInfo = new TextBox();
            SuspendLayout();
            // 
            // clientsInfo
            // 
            clientsInfo.BackColor = SystemColors.Window;
            clientsInfo.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            clientsInfo.Location = new Point(74, 12);
            clientsInfo.Multiline = true;
            clientsInfo.Name = "clientsInfo";
            clientsInfo.ReadOnly = true;
            clientsInfo.Size = new Size(652, 155);
            clientsInfo.TabIndex = 5;
            clientsInfo.TextChanged += clientsInfo_TextChanged;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(clientsInfo);
            Name = "Clients";
            Text = "Clients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientsInfo;
    }
}