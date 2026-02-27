using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Person
    {
        //Property
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public static string website;

        //public Person(string name, string family, int age)
        //    {
        //        this.name = name;
        //        this.family = family;
        //        this.age = age;
        //    }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
