namespace Polipak.UI.MainForm.Sections
{
    partial class UserAccountControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nameLabel = new Label();
            updateDataButton = new Button();
            patronymicTextBox = new TextBox();
            loginTextBox = new TextBox();
            ageTextBox = new TextBox();
            genderTextBox = new TextBox();
            secondNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 348);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 45;
            label7.Text = "Пароль";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 278);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 44;
            label6.Text = "Логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 211);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 43;
            label5.Text = "Возраст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 145);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 42;
            label4.Text = "Пол";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 278);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 41;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 211);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 40;
            label2.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(202, 145);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 15);
            nameLabel.TabIndex = 39;
            nameLabel.Text = "Имя";
            // 
            // updateDataButton
            // 
            updateDataButton.Location = new Point(286, 411);
            updateDataButton.Name = "updateDataButton";
            updateDataButton.Size = new Size(75, 23);
            updateDataButton.TabIndex = 38;
            updateDataButton.Text = "Обновить данные";
            updateDataButton.UseVisualStyleBackColor = true;
            updateDataButton.Click += BtnUpdate_Click;
            // 
            // patronymicTextBox
            // 
            patronymicTextBox.Location = new Point(202, 296);
            patronymicTextBox.Name = "patronymicTextBox";
            patronymicTextBox.Size = new Size(100, 23);
            patronymicTextBox.TabIndex = 32;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(344, 296);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(100, 23);
            loginTextBox.TabIndex = 31;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(344, 229);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(100, 23);
            ageTextBox.TabIndex = 30;
            // 
            // genderTextBox
            // 
            genderTextBox.Location = new Point(344, 163);
            genderTextBox.Name = "genderTextBox";
            genderTextBox.Size = new Size(100, 23);
            genderTextBox.TabIndex = 28;
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.Location = new Point(202, 229);
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.Size = new Size(100, 23);
            secondNameTextBox.TabIndex = 27;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(202, 163);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 26;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(274, 366);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 29;
            // 
            // UserAccountControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameLabel);
            Controls.Add(updateDataButton);
            Controls.Add(patronymicTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(genderTextBox);
            Controls.Add(secondNameTextBox);
            Controls.Add(nameTextBox);
            Name = "UserAccountControl";
            Size = new Size(654, 452);
            Load += LoadAsync;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label nameLabel;
        private Button updateDataButton;
        private TextBox patronymicTextBox;
        private TextBox loginTextBox;
        private TextBox ageTextBox;
        private TextBox genderTextBox;
        private TextBox secondNameTextBox;
        private TextBox nameTextBox;
        private TextBox passwordTextBox;
    }
}
