using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoopExamples
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Example1()
        {
            int i = 1;
            while(i<10)
            {
                Console.WriteLine(i);
                i++;

            }
        }

        [TestMethod]
        public void ExampleTwo()
        {
            int i = 0;
            while (true)
            {
                if (i>10)
                {
                    i++;
                }
                else
                {
                    break; // break exits loop, return exits method. 
                }
            }
        }
    }
}
