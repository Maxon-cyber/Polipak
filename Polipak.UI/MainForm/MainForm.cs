using Microsoft.EntityFrameworkCore;
using Polipak.DataAccess;
using Polipak.Entities;
using Polipak.UI.MainForm.Sections;
using Polipak.UI.UserIdentification;

namespace Polipak.UI.MainForm;

public partial class MainForm : Form
{
    private readonly UserAccountControl userAccount;
    private readonly ProductShowcaseControl productShowcase;
    private readonly ShoppingCartControl shoppingCart;

    public MainForm(User user, AuthorizationForm authorizationForm)
    {
        InitializeComponent();

        userAccount = new UserAccountControl(user);
        productShowcase = new ProductShowcaseControl();

        using PolipakDbContext polipakDb = new PolipakDbContext();

        shoppingCart = new ShoppingCartControl(polipakDb.Orders
                                        .Where(o => o.UserId == user.UserId)
                                        .Include(o => o.OrderProducts)
                                        .ThenInclude(op => op.Product)
                                        .ToList());

        DataSet.Data.CollectionChanged += shoppingCart.Products_CollectionChanged;
    }

    private void BtnOpenUserAccount_Click(object sender, EventArgs e)
    {
        AddSection(userAccount, "Аккаунт");
    }

    private void BtnOpenProductShowcase_Click(object sender, EventArgs e)
    {
        AddSection(productShowcase, "Товары");
    }

    private void BtnOpenShoppingCart_Click(object sender, EventArgs e)
    {
        AddSection(shoppingCart, "Корзина");
    }

    private void AddSection(UserControl control, string name)
    {
        control.BorderStyle = BorderStyle.None;
        control.Dock = DockStyle.Fill;

        contentPanel.Controls.Add(control);
        contentPanel.Tag = control;

        control.BringToFront();

        sectionNameLabel.Text = name;
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}