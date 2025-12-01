using NUnit.Framework;
namespace MyApp.Tests;


public class UserServiceTests
{
    private UserService _userService;

    [SetUp]
    public void Setup()
    {
        _userService = new UserService();
    }

    [Test]
    public void IsValidEmail_ValidEmail_ReturnsTrue()
    {
        var result = _userService.IsValidEmail("test@example.com");
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValidEmail_InvalidEmail_ReturnsFalse()
    {
        var result = _userService.IsValidEmail("testexample.com");
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValidPassword_ValidPassword_ReturnsTrue()
    {
        var result = _userService.IsValidPassword("password");
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValidPassword_TooShort_ReturnsFalse()
    {
        var result = _userService.IsValidPassword("123");
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValidPassword_TooLong_ReturnsFalse()
    {
        var result = _userService.IsValidPassword("123456789");
        Assert.IsFalse(result);
    }

    [Test]
    public void Login_CorrectCredentials_ReturnsTrue()
    {
        var result = _userService.Login("user@example.com", "password");
        Assert.IsTrue(result);
    }

    [Test]
    public void Login_WrongEmail_ReturnsFalse()
    {
        var result = _userService.Login("wrong@example.com", "password123");
        Assert.IsFalse(result);
    }

    [Test]
    public void Login_WrongPassword_ReturnsFalse()
    {
        var result = _userService.Login("user@example.com", "wrongpass");
        Assert.IsFalse(result);
    }

    [Test]
    public void Login_InvalidEmailFormat_ReturnsFalse()
    {
        var result = _userService.Login("userexample.com", "password123");
        Assert.IsFalse(result);
    }




    [Test]
    public void IsValidEmail_ValidEmail_ReturnsFalse()
    {
        var results = _userService.IsValidEmail("google@gmail.net");
        Assert.IsFalse(results);
    }
}