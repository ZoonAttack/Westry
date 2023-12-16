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
            ClientsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ClientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ClientsDataGridView
            // 
            ClientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientsDataGridView.Location = new Point(12, 12);
            ClientsDataGridView.Name = "ClientsDataGridView";
            ClientsDataGridView.RowTemplate.Height = 25;
            ClientsDataGridView.Size = new Size(580, 660);
            ClientsDataGridView.TabIndex = 0;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(604, 684);
            Controls.Add(ClientsDataGridView);
            Name = "Clients";
            Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)ClientsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ClientsDataGridView;
    }
}