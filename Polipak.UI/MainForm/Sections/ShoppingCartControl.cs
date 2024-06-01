using Polipak.Entities;
using Polipak.UI.MainForm.Sections.Product;
using System.Collections.Specialized;

namespace Polipak.UI.MainForm.Sections;

public partial class ShoppingCartControl : UserControl
{
    private static List<Order> ordersOwn;
    private readonly List<Entities.Product> products = new List<Entities.Product>();

    public ShoppingCartControl(List<Order> orders)
    {
        InitializeComponent();

        ordersOwn = orders;
    }

    private void ShoppingCartControl_Load(object sender, EventArgs e)
    {
        int countOfOrders = ordersOwn.Count;

        int columnTPL = viewProductsTLP.ColumnCount;
        int rowTPL = countOfOrders / columnTPL;
        viewProductsTLP.RowCount = rowTPL;

        viewProductsTLP.SuspendLayout();
        for (int orderIndex = 0; orderIndex < countOfOrders; orderIndex++)
        {
            int column = orderIndex % columnTPL;
            int row = orderIndex / columnTPL;

            Order currentOrder = ordersOwn[orderIndex];
            for (int productIndex = 0; productIndex < currentOrder.OrderProducts.Count; productIndex++)
            {
                Entities.Product currentProduct = products[productIndex];

                ProductControl productControl = new ProductControl(currentProduct);
                productControl.Dock = DockStyle.Fill;
                productControl.DeleteButtonClicked += (s, e) =>
                {
                    ProductControl? product = viewProductsTLP.Controls
                                                        .OfType<ProductControl>()
                                                        .FirstOrDefault(p => p.Tag?.ToString() == currentProduct.Name);

                    if (product != null)
                        viewProductsTLP.Controls.Remove(product);
                };

                viewProductsTLP.Controls.Add(productControl, column, row);
            }
        }
        viewProductsTLP.ResumeLayout();

        TableLayoutRowStyleCollection rowStyles = viewProductsTLP.RowStyles;
        TableLayoutColumnStyleCollection columnStyles = viewProductsTLP.ColumnStyles;

        rowStyles.Clear();
        columnStyles.Clear();

        for (int rowIndex = 0; rowIndex < rowTPL; rowIndex++)
            rowStyles.Add(new RowStyle() { SizeType = SizeType.Percent });
        for (int columnIndex = 0; columnIndex < columnTPL; columnIndex++)
            columnStyles.Add(new ColumnStyle() { SizeType = SizeType.Percent });

        viewProductsTLP.Invalidate();
    }

    public void Products_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add)
        {
            foreach (Entities.Product product in e.NewItems)
            {
                ProductControl productControl = new ProductControl(product);
                productControl.Dock = DockStyle.Fill;
                productControl.DeleteButtonClicked += (s, e) =>
                {
                    ProductControl? findProduct = viewProductsTLP.Controls
                                                        .OfType<ProductControl>()
                                                        .FirstOrDefault(p => p.Tag?.ToString() == product.Name);

                    if (findProduct != null)
                    {
                        viewProductsTLP.Controls.Remove(findProduct);
                        products.Remove(product);
                    }
                };

                products.Add(product);
                viewProductsTLP.Controls.Add(productControl);
            }
        }
    }
}