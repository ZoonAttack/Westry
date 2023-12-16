﻿namespace Westry
{
    partial class RegsisterNewClient
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
            registerButton = new Button();
            phoneBox = new TextBox();
            nameBox = new TextBox();
            phoneLabel = new Label();
            nameLabel = new Label();
            mealsBox = new GroupBox();
            threeMealRadioButton = new RadioButton();
            twoMealRadioButton = new RadioButton();
            oneMealRadioButton = new RadioButton();
            mealsBox.SuspendLayout();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.AntiqueWhite;
            registerButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = SystemColors.ControlText;
            registerButton.Location = new Point(328, 256);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(154, 66);
            registerButton.TabIndex = 16;
            registerButton.Text = "تسجيل العميل";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(328, 210);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(154, 23);
            phoneBox.TabIndex = 14;
            phoneBox.TextChanged += phoneBox_TextChanged;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(328, 151);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(154, 23);
            nameBox.TabIndex = 13;
            nameBox.TextChanged += nameBox_TextChanged;
            nameBox.KeyPress += nameBox_KeyPress;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(488, 202);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(107, 31);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "رقم الهاتف";
            phoneLabel.Click += phoneLabel_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(488, 143);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(105, 31);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "اسم العميل";
            nameLabel.Click += nameLabel_Click;
            // 
            // mealsBox
            // 
            mealsBox.Controls.Add(threeMealRadioButton);
            mealsBox.Controls.Add(twoMealRadioButton);
            mealsBox.Controls.Add(oneMealRadioButton);
            mealsBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mealsBox.ForeColor = SystemColors.ControlText;
            mealsBox.Location = new Point(97, 126);
            mealsBox.Name = "mealsBox";
            mealsBox.Size = new Size(200, 117);
            mealsBox.TabIndex = 17;
            mealsBox.TabStop = false;
            mealsBox.Text = "نوع الاشتراك";
            mealsBox.Enter += mealsBox_Enter;
            // 
            // threeMealRadioButton
            // 
            threeMealRadioButton.AutoSize = true;
            threeMealRadioButton.Location = new Point(51, 81);
            threeMealRadioButton.Name = "threeMealRadioButton";
            threeMealRadioButton.Size = new Size(143, 25);
            threeMealRadioButton.TabIndex = 2;
            threeMealRadioButton.TabStop = true;
            threeMealRadioButton.Text = "نظام الثلاث وجبات";
            threeMealRadioButton.UseVisualStyleBackColor = true;
            threeMealRadioButton.CheckedChanged += threeMealRadioButton_CheckedChanged;
            // 
            // twoMealRadioButton
            // 
            twoMealRadioButton.AutoSize = true;
            twoMealRadioButton.Location = new Point(51, 50);
            twoMealRadioButton.Name = "twoMealRadioButton";
            twoMealRadioButton.Size = new Size(110, 25);
            twoMealRadioButton.TabIndex = 1;
            twoMealRadioButton.TabStop = true;
            twoMealRadioButton.Text = "نظام الوجبتين";
            twoMealRadioButton.UseVisualStyleBackColor = true;
            twoMealRadioButton.CheckedChanged += twoMealRadioButton_CheckedChanged;
            // 
            // oneMealRadioButton
            // 
            oneMealRadioButton.AutoSize = true;
            oneMealRadioButton.Location = new Point(51, 19);
            oneMealRadioButton.Name = "oneMealRadioButton";
            oneMealRadioButton.Size = new Size(143, 25);
            oneMealRadioButton.TabIndex = 0;
            oneMealRadioButton.TabStop = true;
            oneMealRadioButton.Text = "نظام الوجبة الواحدة";
            oneMealRadioButton.UseVisualStyleBackColor = true;
            oneMealRadioButton.CheckedChanged += oneMealRadioButton_CheckedChanged;
            // 
            // userRegistrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(mealsBox);
            Controls.Add(registerButton);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Controls.Add(phoneLabel);
            Controls.Add(nameLabel);
            Name = "userRegistrationPage";
            Text = "userRegistrationPage";
            mealsBox.ResumeLayout(false);
            mealsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TextBox phoneBox;
        private TextBox nameBox;
        private Label phoneLabel;
        private Label nameLabel;
        private GroupBox mealsBox;
        private RadioButton threeMealRadioButton;
        private RadioButton twoMealRadioButton;
        private RadioButton oneMealRadioButton;
    }
}