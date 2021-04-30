using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what to Enter:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. First Name.\n2. Last Name.\n3. Phone Number.\n4. Email Id.\n5. Password.");
            Console.WriteLine("-------------------------");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter your First Name:");
                    RegexPatterns name = new RegexPatterns();
                    bool result = name.ValidateName(Console.ReadLine());
                    Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine("Enter your Last Name:");
                    RegexPatterns lastname = new RegexPatterns();
                    bool resultlastname = lastname.ValidateLastName(Console.ReadLine());
                    Console.WriteLine(resultlastname);
                    break;
                case 3:
                    Console.WriteLine("Enter your Phone Number:");
                    RegexPatterns phonenum = new RegexPatterns();
                    bool resultphonenum = phonenum.ValidatePhoneNum(Console.ReadLine());
                    Console.WriteLine(resultphonenum);
                    break;
                case 4:
                    Console.WriteLine("Enter your Email Id:");
                    RegexPatterns emailid = new RegexPatterns();
                    bool resultemailid = emailid.ValidateEmail(Console.ReadLine());
                    Console.WriteLine(resultemailid);
                    break;
                case 5:
                    Console.WriteLine("Enter your Password:");
                    RegexPatterns pass = new RegexPatterns();
                    bool resultpass = pass.ValidatePassword(Console.ReadLine());
                    Console.WriteLine(resultpass);
                    break;
            }
            Console.ReadKey();
        }
    }
}
