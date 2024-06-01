using Polipak.DataAccess;
using Polipak.UI.MainForm.Sections.Product;

namespace Polipak.UI.MainForm.Sections;

public partial class ProductShowcaseControl : UserControl
{
    public ProductShowcaseControl()
    {
        InitializeComponent();
    }

    private void ProductShowcaseControl_Load(object sender, EventArgs e)
    {
        using PolipakDbContext polipakDb = new PolipakDbContext();
        List<Entities.Product> products = polipakDb.Products.ToList();

        viewProductsTLP.Invoke(() =>
        {
            int countOfProducts = products.Count;

            int columnTPL = viewProductsTLP.ColumnCount;
            int rowTPL = countOfProducts / columnTPL;
            viewProductsTLP.RowCount = rowTPL;

            viewProductsTLP.SuspendLayout();
            for (int index = 0; index < countOfProducts; index++)
            {
                int column = index % columnTPL;
                int row = index / columnTPL;

                Entities.Product currentProduct = products[index];

                ProductControl productControl = new ProductControl(currentProduct);
                productControl.Dock = DockStyle.Fill;
                productControl.AddButtonClicked += (s, e) => DataSet.Data.Add(currentProduct);

                productControl.CreateProductViewAsync();

                viewProductsTLP.Controls.Add(productControl, column, row);
            }

            TableLayoutRowStyleCollection rowStyles = viewProductsTLP.RowStyles;
            TableLayoutColumnStyleCollection columnStyles = viewProductsTLP.ColumnStyles;

            rowStyles.Clear();
            columnStyles.Clear();

            for (int rowIndex = 0; rowIndex < rowTPL; rowIndex++)
                rowStyles.Add(new RowStyle() { SizeType = SizeType.Percent });
            for (int columnIndex = 0; columnIndex < columnTPL; columnIndex++)
                columnStyles.Add(new ColumnStyle() { SizeType = SizeType.Percent });

            viewProductsTLP.ResumeLayout();
        });
    }
}