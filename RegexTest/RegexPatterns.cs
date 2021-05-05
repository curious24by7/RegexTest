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
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-z]{3,}$";
        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-z]{3,}$";
        public const string PHONENUM_REGEX = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";
        public const string EMAIL_REGEX = "^[a-z0-9A-Z]+([.][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        public const string PASSWORD_REGEX = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        //Func<string, string, bool> Test = (x, y) => x > y; ~~LAMBDA EXP
        public Func<string, string, bool> ValidateName = (name, FIRSTNAME_REGEX) => Regex.IsMatch(name, FIRSTNAME_REGEX);
        public Func<string, string, bool> ValidateLastName = (lastname, LASTNAME_REGEX) => Regex.IsMatch(lastname, LASTNAME_REGEX);
        public Func<string, string, bool> ValidatePhoneNum = (phonenum, PHONENUM_REGEX) => Regex.IsMatch(phonenum, PHONENUM_REGEX);
        public Func<string, string, bool> ValidateEmail = (email, EMAIL_REGEX) => Regex.IsMatch(email, EMAIL_REGEX);
        public Func<string, string, bool> ValidatePassword = (password, PASSWORD_REGEX) => Regex.IsMatch(password, PASSWORD_REGEX);
    }
}
