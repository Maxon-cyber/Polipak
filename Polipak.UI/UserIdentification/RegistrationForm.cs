using Polipak.DataAccess;
using Polipak.Entities;

namespace Polipak.UI.UserIdentification;

public partial class RegistrationForm : Form
{
    private readonly AuthorizationForm authorizationForm;

    public RegistrationForm(AuthorizationForm authorizationForm)
    {
        InitializeComponent();
        this.authorizationForm = authorizationForm;
    }

    private async void BtnRegistration_Click(object sender, EventArgs e)
    {
        using PolipakDbContext polipakDb = new PolipakDbContext();

        await polipakDb.Users.AddAsync(new User()
        {
            Name = nameTextBox.Text,
            SecondName = secondNameTextBox.Text,
            Patronymic = patronymicTextBox.Text,
            Gender = genderPanel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked == true).Tag.ToString()!,
            Age = Convert.ToInt32(ageTextBox.Text),
            Email = emailTextBox.Text,
            Login = loginTextBox.Text,
            Password = passwordTextBox.Text,
        });

        await polipakDb.SaveChangesAsync();
        bool userExists = polipakDb.Users.Any(u => u.Email == emailTextBox.Text && u.Login == loginTextBox.Text && u.Password == passwordTextBox.Text);

        if (userExists)
            MessageBox.Show("Пользователь успешно зарегистрирован!");
        else
            MessageBox.Show("Пользователь не зарегистрирован");
    }

    private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Close();
        authorizationForm.Show();
    }
}