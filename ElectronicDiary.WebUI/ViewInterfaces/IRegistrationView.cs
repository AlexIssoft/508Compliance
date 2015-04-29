using System;

namespace ElectronicDiary.WebUI.ViewInterfaces
{
    public interface IRegistrationView
    {
        string UserName { get; set; }
        string Password { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; } 
        string LastName { get; set; }
        DateTime Birthday { get; set; }
        string University { get; set; } 
    }
}