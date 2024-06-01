namespace Polipak.UI.UserIdentification
{
    partial class RegistrationForm
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
            genderPanel = new Panel();
            womanRadioButton = new RadioButton();
            manRadioButton = new RadioButton();
            countryTextBox = new TextBox();
            registrationButton = new Button();
            regionTextBox = new TextBox();
            cityTextBox = new TextBox();
            houseNumberTextBox = new TextBox();
            streetTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            ageTextBox = new TextBox();
            patronymicTextBox = new TextBox();
            secondNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            genderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // genderPanel
            // 
            genderPanel.Controls.Add(womanRadioButton);
            genderPanel.Controls.Add(manRadioButton);
            genderPanel.Location = new Point(170, 293);
            genderPanel.Name = "genderPanel";
            genderPanel.Size = new Size(153, 73);
            genderPanel.TabIndex = 28;
            // 
            // womanRadioButton
            // 
            womanRadioButton.AutoSize = true;
            womanRadioButton.Location = new Point(17, 38);
            womanRadioButton.Name = "womanRadioButton";
            womanRadioButton.Size = new Size(52, 19);
            womanRadioButton.TabIndex = 17;
            womanRadioButton.TabStop = true;
            womanRadioButton.Tag = "Woman";
            womanRadioButton.Text = "Жен.";
            womanRadioButton.UseVisualStyleBackColor = true;
            // 
            // manRadioButton
            // 
            manRadioButton.AutoSize = true;
            manRadioButton.Location = new Point(17, 13);
            manRadioButton.Name = "manRadioButton";
            manRadioButton.Size = new Size(54, 19);
            manRadioButton.TabIndex = 16;
            manRadioButton.TabStop = true;
            manRadioButton.Tag = "Man";
            manRadioButton.Text = "Муж.";
            manRadioButton.UseVisualStyleBackColor = true;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(340, 418);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.PlaceholderText = "Страна";
            countryTextBox.Size = new Size(100, 23);
            countryTextBox.TabIndex = 27;
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(233, 493);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(147, 23);
            registrationButton.TabIndex = 26;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += BtnRegistration_Click;
            // 
            // regionTextBox
            // 
            regionTextBox.Location = new Point(340, 367);
            regionTextBox.Name = "regionTextBox";
            regionTextBox.PlaceholderText = "Регион";
            regionTextBox.Size = new Size(100, 23);
            regionTextBox.TabIndex = 25;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(340, 315);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PlaceholderText = "Город";
            cityTextBox.Size = new Size(100, 23);
            cityTextBox.TabIndex = 24;
            // 
            // houseNumberTextBox
            // 
            houseNumberTextBox.Location = new Point(340, 264);
            houseNumberTextBox.Name = "houseNumberTextBox";
            houseNumberTextBox.PlaceholderText = "Номер дома";
            houseNumberTextBox.Size = new Size(100, 23);
            houseNumberTextBox.TabIndex = 23;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(340, 211);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.PlaceholderText = "Улица";
            streetTextBox.Size = new Size(100, 23);
            streetTextBox.TabIndex = 22;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(340, 159);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Пароль";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 21;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(340, 105);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PlaceholderText = "Логин";
            loginTextBox.Size = new Size(100, 23);
            loginTextBox.TabIndex = 20;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(181, 264);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.PlaceholderText = "Возраст";
            ageTextBox.Size = new Size(100, 23);
            ageTextBox.TabIndex = 19;
            // 
            // patronymicTextBox
            // 
            patronymicTextBox.Location = new Point(181, 211);
            patronymicTextBox.Name = "patronymicTextBox";
            patronymicTextBox.PlaceholderText = "Отчество";
            patronymicTextBox.Size = new Size(100, 23);
            patronymicTextBox.TabIndex = 18;
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.Location = new Point(181, 159);
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.PlaceholderText = "Фамилия";
            secondNameTextBox.Size = new Size(100, 23);
            secondNameTextBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(181, 105);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Имя";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(181, 396);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Логин";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 30;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 621);
            Controls.Add(emailTextBox);
            Controls.Add(genderPanel);
            Controls.Add(countryTextBox);
            Controls.Add(registrationButton);
            Controls.Add(regionTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(houseNumberTextBox);
            Controls.Add(streetTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(patronymicTextBox);
            Controls.Add(secondNameTextBox);
            Controls.Add(nameTextBox);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            FormClosed += RegistrationForm_FormClosed;
            genderPanel.ResumeLayout(false);
            genderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel genderPanel;
        private RadioButton womanRadioButton;
        private RadioButton manRadioButton;
        private TextBox countryTextBox;
        private Button registrationButton;
        private TextBox regionTextBox;
        private TextBox cityTextBox;
        private TextBox houseNumberTextBox;
        private TextBox streetTextBox;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private TextBox ageTextBox;
        private TextBox patronymicTextBox;
        private TextBox secondNameTextBox;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
    }
}