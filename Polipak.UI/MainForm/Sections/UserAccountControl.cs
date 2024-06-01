using Polipak.DataAccess;
using Polipak.Entities;

namespace Polipak.UI.MainForm.Sections;

public partial class UserAccountControl : UserControl
{
    private readonly User user;

    public UserAccountControl(User user)
    {
        InitializeComponent();
        this.user = user;
    }

    private void LoadAsync(object sender, EventArgs e)
    {
        nameTextBox.Text = user.Name;
        secondNameTextBox.Text = user.SecondName;
        patronymicTextBox.Text = user.Patronymic;
        genderTextBox.Text = user.Gender;
        ageTextBox.Text = user.Age.ToString();
        loginTextBox.Text = user.Login;
        passwordTextBox.Text = user.Password;
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {

    }
}