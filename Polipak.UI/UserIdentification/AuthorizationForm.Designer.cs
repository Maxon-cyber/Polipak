namespace Polipak.UI.UserIdentification
{
    partial class AuthorizationForm
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
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            registrationButton = new Button();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(163, 180);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PlaceholderText = "Логин";
            loginTextBox.Size = new Size(100, 23);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(163, 236);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Пароль";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(172, 297);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += BtnLogin_Click;
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(157, 353);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(106, 23);
            registrationButton.TabIndex = 3;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += BtnRegistration_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 441);
            Controls.Add(registrationButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Name = "AuthorizationForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button registrationButton;
    }
}