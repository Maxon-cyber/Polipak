namespace Polipak.UI.MainForm.Sections
{
    partial class ShoppingCartControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartControl));
            viewProductsTLP = new TableLayoutPanel();
            searchTextBox = new TextBox();
            searchButton = new Button();
            SuspendLayout();
            // 
            // viewProductsTLP
            // 
            resources.ApplyResources(viewProductsTLP, "viewProductsTLP");
            viewProductsTLP.Name = "viewProductsTLP";
            // 
            // searchTextBox
            // 
            resources.ApplyResources(searchTextBox, "searchTextBox");
            searchTextBox.Name = "searchTextBox";
            // 
            // searchButton
            // 
            resources.ApplyResources(searchButton, "searchButton");
            searchButton.Name = "searchButton";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // ShoppingCartControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(viewProductsTLP);
            Name = "ShoppingCartControl";
            Load += ShoppingCartControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel viewProductsTLP;
        private TextBox searchTextBox;
        private Button searchButton;
    }
}
