public class UserService
{
    public bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email)) return false;
        return email.Contains("@") && email.Contains(".") && email.Contains(".com");
    }

    public bool IsValidPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password)) return false;
        return password.Length >= 6 && password.Length <= 8; 
    }

    public bool Login(string email, string password)
    {
        if (!IsValidEmail(email) || !IsValidPassword(password))
            return false;

        return email == "user@example.com" && password == "password";
    }
}