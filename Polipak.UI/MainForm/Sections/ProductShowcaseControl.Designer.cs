namespace Polipak.UI.MainForm.Sections
{
    partial class ProductShowcaseControl
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
            viewProductsTLP = new TableLayoutPanel();
            SuspendLayout();
            // 
            // viewProductsTLP
            // 
            viewProductsTLP.ColumnCount = 2;
            viewProductsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewProductsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewProductsTLP.Location = new Point(0, 113);
            viewProductsTLP.Name = "viewProductsTLP";
            viewProductsTLP.RowCount = 2;
            viewProductsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            viewProductsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            viewProductsTLP.Size = new Size(723, 347);
            viewProductsTLP.TabIndex = 0;
            // 
            // ProductShowcaseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewProductsTLP);
            Name = "ProductShowcaseControl";
            Size = new Size(726, 460);
            Load += ProductShowcaseControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel viewProductsTLP;
    }
}
