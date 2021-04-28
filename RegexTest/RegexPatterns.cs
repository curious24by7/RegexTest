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
        public string RegexName = "^[A-Z]{1}[a-z]{3,}$";
        public string RegexLastName = "^[A-Z]{1}[a-z]{3,}$";
        public string RegexPhoneNum = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";
        public string RegexEmail = "^[a-z0-9A-Z]+([.][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        public string RegexPassword = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, RegexName);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, RegexLastName);
        }
        public bool ValidatePhoneNum(string phonenum)
        {
            return Regex.IsMatch(phonenum, RegexPhoneNum);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, RegexEmail);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, RegexPassword);
        }
    }
}
