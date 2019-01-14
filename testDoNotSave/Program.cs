using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            void CountLetters()
            {
                string myString = "Count the letters that are in the sentence You are doing awesome";
                int counter = 0;
                foreach (char c in myString)
                {
                    if (char.IsLetter(c))
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
                Console.ReadKey();
            }
            CountLetters();
        }
    }
}
