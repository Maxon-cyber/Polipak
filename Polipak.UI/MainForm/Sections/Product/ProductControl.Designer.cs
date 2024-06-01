namespace Polipak.UI.MainForm.Sections.Product
{
    partial class ProductControl
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
            contentPanel = new Panel();
            addButton = new Button();
            productPictureBox = new PictureBox();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(addButton);
            contentPanel.Controls.Add(productPictureBox);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(377, 174);
            contentPanel.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(0, 120);
            addButton.Name = "addButton";
            addButton.Size = new Size(377, 54);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(0, 0);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(377, 122);
            productPictureBox.TabIndex = 0;
            productPictureBox.TabStop = false;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Name = "ProductControl";
            Size = new Size(377, 174);
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private PictureBox productPictureBox;
        private Button addButton;
    }
}
