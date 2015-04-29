using System.Text.RegularExpressions;

namespace Core.Helpers
{
    public static class EmailHelper
    {
        public static bool IsEmailValid(string emailAddress)
        {
            lock (typeof(EmailHelper))
            {
                try
                {
                    var atIndex = emailAddress.LastIndexOf('@');

                    if (atIndex < 0)
                    {
                        return false;
                    }

                    var localPart = emailAddress.Substring(0, atIndex);
                    var domainPart = emailAddress.Substring(atIndex + 1);

                    // local-part must have maximum 64 characters
                    if (localPart.Length < 1 || localPart.Length > 64)
                    {
                        return false;
                    }
                    // the domain name is maximum 255 characters
                    if (domainPart.Length < 1 || domainPart.Length > 255)
                    {
                        return false;
                    }
                    // local-part must not begin and end with '.' character
                    if (localPart[0] == '.' || localPart[localPart.Length - 1] == '.')
                    {
                        return false;
                    }

                    // local part has two consecutive dots
                    if (Regex.IsMatch(localPart, @"\.\."))
                    {
                        return false;
                    }

                    // domain part has two consecutive dots
                    if (Regex.IsMatch(domainPart, @"\.\."))
                    {
                        return false;
                    }

                    // character not valid in local part unless local part is quoted
                    if (!Regex.IsMatch(localPart.Replace(@"\\", ""), @"^(\\.|[A-Za-z0-9!#%&`_=\/$\'*+?^{}|~.-])+$")
                        && !Regex.IsMatch(localPart.Replace(@"\\", ""), @"^""(\\""|[^""])+""$"))
                    {
                        return false;
                    }

                    //check domain name
                    if (!Regex.IsMatch(domainPart, @"^((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }

                return true;
            }
        }
    }
}