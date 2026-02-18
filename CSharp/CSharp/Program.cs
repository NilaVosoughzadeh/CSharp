using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

            //If Else
            // Operators : != , == , > , < , <= , >=
            string name = "";
            string family = "";
            Console.WriteLine("Plz enter name : ");
            name = Console.ReadLine().ToLower();
            Console.WriteLine("Plz enter family : ");
            family = Console.ReadLine().ToLower();
            if (name == "nila" && family == "vo")
            {
                Console.WriteLine("Hello Nila Vo");
            }
            else
            {
                Console.WriteLine("Hello ...");
            }

            //Switch , Case
            Console.WriteLine("Plz enter number");
            int numberOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (numberOfWeek)
            {
                case 0:
                    Console.WriteLine("Shanbe");
                    break;
                case 1:
                    Console.WriteLine("1Shanbe");
                    break;
                case 2:
                    Console.WriteLine("2Shanbe");
                    break;
                case 3:
                    Console.WriteLine("3Shanbe");
                    break;
                case 4:
                    Console.WriteLine("4Shanbe");
                    break;
                case 5:
                    Console.WriteLine("5Shanbe");
                    break;
                case 6:
                    Console.WriteLine("Jome");
                    break;
                default:
                    Console.WriteLine("Not Found");
                    break;
            }

            //Loop
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
            }

            //Array
            int[] numbers = { 1, 3, 5, 7 };
            int numberIndex = numbers[0];

            //Person Example
            try
            {
                Console.WriteLine("Plz Enter Person Number : ");
                int personNumbers = Convert.ToInt32(Console.ReadLine());
                string[] Names = new string[personNumbers];
                for (int p = 1; p < personNumbers; p++)
                {
                    Console.WriteLine("Please Enter Name" + (p));
                    Names[p] = Console.ReadLine();
                }
                foreach (string n in Names)
                {
                    Console.WriteLine("Hello " + n);
                }
            }
            catch
            {
                Console.WriteLine("Plz Enter Just Number");
            }

            //While
            int i = 0;
            while (i > 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //Method
            SayHello();

            Console.WriteLine(FullName("Nila", "Vo"));
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static int Sum(int a = 10, int b = 5)
        {
            return a + b;
        }

        static string FullName(string name, string family)
        {
            return name + " " + family;
        }
    }
}
