using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCases
{
    public enum Gender { Male, Female, ApacheHelicopter };

    class SwitchStatements
    {
        string firstName = "Joe";
        string lastName = "Joeson";
        Gender gender = Gender.ApacheHelicopter;
        public void SwitchAndEnum()
        {
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
        }
    }
}
