using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Amount = 25000;
            //Console.WriteLine(MyClass.ToRial(Amount));
            //Console.WriteLine(MyClass.ToRial(14500));

            //Extension Method
            Console.WriteLine(Amount.ToRial());

            Console.WriteLine(DateTime.Now.ToShamsi());

            Console.ReadKey();
        }
    }
}
