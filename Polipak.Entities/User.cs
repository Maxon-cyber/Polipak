namespace Polipak.Entities;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string SecondName { get; set; }
    public string Patronymic { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public List<Order> Orders { get; set; }
}