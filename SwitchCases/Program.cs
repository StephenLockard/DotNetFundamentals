using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Joe";
            string lastName = "Joeson";
            Gender gender = Gender.ApacheHelicopter;
        
                switch (gender)
                {
                    case Gender.Male:
                        Console.WriteLine($"Welcome Mr. {lastName}");
                        break;
                    case Gender.Female:
                        Console.WriteLine($"Welcome Ms. {lastName}");
                        break;
                    case Gender.ApacheHelicopter:
                        Console.WriteLine($"Oh my, what an impressive arsenal you have {firstName} {lastName}");
                        break;
                }
            

            bool userContinue = true;
            do
            {
                Console.WriteLine("How are you feeling today on a scale of 1-5?");
                int userHappy = int.Parse(Console.ReadLine());
                    switch (userHappy)
                    {
                        case 1:
                            Console.WriteLine("Well that sucks.");
                            userContinue = false;
                            break;
                        case 2:
                            Console.WriteLine("Could be a little worse I suppose.");
                            userContinue = false;
                            break;
                        case 3:
                            Console.WriteLine("Could be worse.");
                            userContinue = false;
                            break;
                        case 4:
                            Console.WriteLine("Good for you!");
                            userContinue = false;
                            break;
                        case 5:
                            Console.WriteLine("I'll have what you're having.");
                            userContinue = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a number between 1-5.");
                            userContinue = true;
                            break;
                    }
            } while (userContinue == true);
            Console.ReadLine();
        }
    }
}
