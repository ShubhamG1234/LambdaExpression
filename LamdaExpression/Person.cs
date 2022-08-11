using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Person
    {
        public string SSN;
        public string Name;
        public int Age;
        public string Address;

        public Person(string sSN, string name, string address, int age)
        {
            SSN = sSN;
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
