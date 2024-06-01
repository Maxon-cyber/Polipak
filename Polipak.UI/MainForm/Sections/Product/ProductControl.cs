
namespace Polipak.UI.MainForm.Sections.Product;

public partial class ProductControl : UserControl
{
    private readonly Entities.Product product;

    public event EventHandler? AddButtonClicked;
    public event EventHandler? DeleteButtonClicked;

    public ProductControl(Entities.Product product)
    {
        InitializeComponent();
        this.product = product;
    }

    public void CreateProductViewAsync()
    {
        if (AddButtonClicked == null && DeleteButtonClicked == null)
            throw new ArgumentNullException("AddButtonClicked/DeleteButtonClicked", "Перед созданием представления продукта необходимо подписаться хотя бы на одно свойство: AddButtonClicked или DeleteButtonClicked");

        productPictureBox.Name = $"{product.Name}PictureBox";

        using MemoryStream memoryStream = new MemoryStream(product.Image);
        productPictureBox.Image = Image.FromStream(memoryStream);

        productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        Tag = product.Name;

        if (AddButtonClicked != null && DeleteButtonClicked == null)
        {
            Button addButton = new Button()
            {
                Name = "addButton",
                Text = "Добавить продукт",
                Size = new Size(377, 54),
                Location = new Point(0, 120)
            };

            addButton.Click += AddButtonClicked;

            contentPanel.Controls.Add(addButton);
        }
        else if (AddButtonClicked == null && DeleteButtonClicked != null)
        {
            Button deleteButton = new Button()
            {
                Name = "deleteButton",
                Text = "Удалить продукт",
                Size = new Size(377, 54),
                Location = new Point(0, 120)
            };

            deleteButton.Click += DeleteButtonClicked;

            contentPanel.Controls.Add(deleteButton);
        }
    }
}