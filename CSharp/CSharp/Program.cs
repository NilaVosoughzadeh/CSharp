using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Nila";
            int a = 4, b = 6;
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(Name);

            //Convert
            int d = 20;
            string number = Convert.ToString(d);
            Console.WriteLine(number);
            Console.ReadKey();

            //Exeption
            int num1, num2;
            Console.WriteLine("Please enter number 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum is : " + sum);
            Console.ReadKey();
        }
    }
}
