using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Challenge
{

    public enum GenderType { Male, Female, Other }

    public class Customer
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }

        public Customer() { }

        public Customer(string name, int age, GenderType gender)
        {
            FullName = name;
            Age = age;
            Gender = gender;
        }
    }
}
