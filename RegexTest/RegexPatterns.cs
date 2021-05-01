using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    public class RegexPatterns
    {
        public string FIRSTNAME_REGEX = "^[A-Z]{1}[a-z]{3,}$";
        public string LASTNAME_REGEX = "^[A-Z]{1}[a-z]{3,}$";
        public string PHONENUM_REGEX = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";
        public string EMAIL_REGEX = "^[a-z0-9A-Z]+([.][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        public string PASSWORD_REGEX = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, FIRSTNAME_REGEX);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, LASTNAME_REGEX);
        }
        public bool ValidatePhoneNum(string phonenum)
        {
            return Regex.IsMatch(phonenum, PHONENUM_REGEX);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD_REGEX);
        }
    }
}
