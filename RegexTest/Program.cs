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
                    Console.WriteLine("Enter your First Name.");

                    RegexPatterns name = new RegexPatterns();

                    Console.WriteLine("Enter First Name :");
                    bool result = name.ValidateName(Console.ReadLine());
                    Console.WriteLine(result);
                    break;
            }
            Console.ReadKey();
        }

    }
}
