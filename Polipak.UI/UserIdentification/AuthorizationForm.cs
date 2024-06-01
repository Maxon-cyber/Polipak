using Polipak.DataAccess;
using Polipak.Entities;

namespace Polipak.UI.UserIdentification;

public partial class AuthorizationForm : Form
{
    public AuthorizationForm()
    {
        InitializeComponent();
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(loginTextBox.Text))
        {
            MessageBox.Show($"Пользователь с логином: {loginTextBox.Text} не найден");
            return;
        }
        else if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
        {
            MessageBox.Show($"Пользователь с логином: {passwordTextBox.Text} не найден");
            return;
        }

        using PolipakDbContext polipakDb = new PolipakDbContext();
        User? user = polipakDb.Users.Where(u => u.Login == loginTextBox.Text && u.Password == passwordTextBox.Text).FirstOrDefault();

        if (user == null)
        {
            MessageBox.Show($"Пользователь с логином: {loginTextBox.Text} не найден");
            return;
        }

        MessageBox.Show($"{user.SecondName} {user.Name} {user.Patronymic}");

        MainForm.MainForm mainForm = new MainForm.MainForm(user, this);
        Hide();

        mainForm.Show();
    }

    private void BtnRegistration_Click(object sender, EventArgs e)
    {
        RegistrationForm registrationForm = new RegistrationForm(this);
        Hide();

        registrationForm.ShowDialog();
    }
}