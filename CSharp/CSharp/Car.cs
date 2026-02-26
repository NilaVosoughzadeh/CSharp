using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Car
    {
        //public
        //private
        //protected
        //internal
        public string CarName
        {
            get
            {
                return _carName;
            }
        }
        private string _carName = "Pride";

        private int _carSpeed;
        public int CarSpeed
        {
            get
            {
                return _carSpeed;
            }
            set
            {
                if (value > 120)
                {
                    Console.WriteLine("Dead!!");
                    _carSpeed = 0;
                }
                else
                {
                    _carSpeed = value;
                }
            }
        }

        public string CarModel;
    }
}
