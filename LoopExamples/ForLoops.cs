using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoopExamples
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void ExampleOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ExampleTwo()
        {
            int number = 136;

            for (int i = 0; i <= number; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        [TestMethod]
        public void CountNonSpaceChars()
        {
            string myString = "Eleven Fifty Academy";
            int counter = 0;
            foreach (char c in myString)
            {
                if (char.IsLetter(c))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
//Count the letters that are in the sentence "You are doing awesome."