using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanksgivingConsole
{
    public class Thanksgiving
    {
        public string FoodOne { get; set; }
        public string FoodTwo { get; set; }
        public string FoodThree { get; set; }
        public string FoodFour { get; set; }
        public bool TurkeyIsDone { get; set; }

        public Thanksgiving(string foodOne, string foodTwo, string foodThree, string foodFour, bool turkeyIsDone)
        {
            FoodOne = foodOne;
            FoodTwo = foodTwo;
            FoodThree = foodThree;
            FoodFour = foodFour;
            TurkeyIsDone = turkeyIsDone;
        }

        public Thanksgiving()
        {

        }
    }
}