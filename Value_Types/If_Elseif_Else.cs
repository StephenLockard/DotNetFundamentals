using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class If_Elseif_Else
    {
        [TestMethod]
        public void If_Else()
        {
            if (1 != 2)
            {
                Console.WriteLine("That statement resolves as true.");
            }
            DateTime birthday = new DateTime(1986, 5, 28);
            DateTime current = DateTime.Now;

            if (birthday.Month == current.Month && birthday.Day == current.Day)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else
            {
                Console.WriteLine("That's too bad!");
            }

            int age = 32;
            if (age >= 16 && age <= 17)
            {
                Console.WriteLine("Hooray, you can join the Army as long as it's okay with mom!");
            }
            else if (age >= 18 && age <= 20)
            {
                Console.WriteLine("Just because you can buy cigarettes doesn't mean you should!");
            }
            else if (age >= 21 && age <= 29)
            {
                Console.WriteLine("Mmmmmm, legal booze.");
            }
            else
            {
                Console.WriteLine("Wow you're really old, is your credit score good?");
            }
        }
    }
}
