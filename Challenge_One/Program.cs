using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What phrase do you like to use as greetings?");
            string greetings = Console.ReadLine();
            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}, age {3}", greetings, firstName, lastName, age);
            Console.ReadLine();
        }
    }
}
