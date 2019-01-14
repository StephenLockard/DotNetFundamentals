using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello? ..... World?");
            Console.ReadLine();

            string hi = "Hello";

            Console.WriteLine($"{hi} world!");
            Console.ReadLine();

            string lastName = "Lockard";
            string firstName = "Stephen";

            Console.WriteLine($"{hi}, {firstName} {lastName}");
            Console.ReadLine();

            string greeting = hi + " " + firstName + " " + lastName;

            Console.WriteLine(greeting);

            Console.WriteLine("How old are you? ");
            string age = Console.ReadLine();
            Console.WriteLine($"{hi}, {firstName} {lastName} age {age}.");
            Console.ReadLine();

            Console.WriteLine();



        }
    }
}
