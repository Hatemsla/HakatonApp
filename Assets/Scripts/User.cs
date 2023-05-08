public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Roles Role { get; set; }

    public User(){}
    
    public User(string login, string password, Roles role)
    {
        Login = login;
        Password = password;
        Role = role;
    }

    public User(string login)
    {
        Login = login;
    }
}