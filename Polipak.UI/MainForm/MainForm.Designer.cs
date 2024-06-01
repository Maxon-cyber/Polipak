namespace Polipak.UI.MainForm
{
    partial class MainForm
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
            barPanel = new Panel();
            companyNameLabel = new Label();
            shoppingCartButton = new Button();
            productShowcaseButton = new Button();
            userAccountButton = new Button();
            sectionNamePanel = new Panel();
            sectionNameLabel = new Label();
            contentPanel = new Panel();
            barPanel.SuspendLayout();
            sectionNamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // barPanel
            // 
            barPanel.Controls.Add(companyNameLabel);
            barPanel.Controls.Add(shoppingCartButton);
            barPanel.Controls.Add(productShowcaseButton);
            barPanel.Controls.Add(userAccountButton);
            barPanel.Location = new Point(2, 1);
            barPanel.Name = "barPanel";
            barPanel.Size = new Size(144, 537);
            barPanel.TabIndex = 0;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(50, 44);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(56, 15);
            companyNameLabel.TabIndex = 3;
            companyNameLabel.Text = "Полипак";
            // 
            // shoppingCartButton
            // 
            shoppingCartButton.Location = new Point(0, 260);
            shoppingCartButton.Name = "shoppingCartButton";
            shoppingCartButton.Size = new Size(144, 63);
            shoppingCartButton.TabIndex = 2;
            shoppingCartButton.Text = "Корзина";
            shoppingCartButton.UseVisualStyleBackColor = true;
            shoppingCartButton.Click += BtnOpenShoppingCart_Click;
            // 
            // productShowcaseButton
            // 
            productShowcaseButton.Location = new Point(0, 193);
            productShowcaseButton.Name = "productShowcaseButton";
            productShowcaseButton.Size = new Size(144, 63);
            productShowcaseButton.TabIndex = 1;
            productShowcaseButton.Text = "Товары";
            productShowcaseButton.UseVisualStyleBackColor = true;
            productShowcaseButton.Click += BtnOpenProductShowcase_Click;
            // 
            // userAccountButton
            // 
            userAccountButton.Location = new Point(0, 127);
            userAccountButton.Name = "userAccountButton";
            userAccountButton.Size = new Size(144, 63);
            userAccountButton.TabIndex = 0;
            userAccountButton.Text = "Аккаунт";
            userAccountButton.UseVisualStyleBackColor = true;
            userAccountButton.Click += BtnOpenUserAccount_Click;
            // 
            // sectionNamePanel
            // 
            sectionNamePanel.Controls.Add(sectionNameLabel);
            sectionNamePanel.Location = new Point(145, 1);
            sectionNamePanel.Name = "sectionNamePanel";
            sectionNamePanel.Size = new Size(726, 77);
            sectionNamePanel.TabIndex = 1;
            // 
            // sectionNameLabel
            // 
            sectionNameLabel.Location = new Point(228, 18);
            sectionNameLabel.Name = "sectionNameLabel";
            sectionNameLabel.Size = new Size(177, 41);
            sectionNameLabel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Location = new Point(145, 78);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(726, 460);
            contentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 539);
            Controls.Add(contentPanel);
            Controls.Add(sectionNamePanel);
            Controls.Add(barPanel);
            Name = "MainForm";
            Text = "Главная страница";
            FormClosed += MainForm_FormClosed;
            barPanel.ResumeLayout(false);
            barPanel.PerformLayout();
            sectionNamePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel barPanel;
        private Button shoppingCartButton;
        private Button productShowcaseButton;
        private Button userAccountButton;
        private Panel sectionNamePanel;
        private Label sectionNameLabel;
        private Panel contentPanel;
        private Label companyNameLabel;
    }
}