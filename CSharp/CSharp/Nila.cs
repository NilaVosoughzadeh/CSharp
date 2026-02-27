using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Nila : IMyInterface
    {
        public void ControlSpeed(int speed)
        {
            Console.WriteLine("Speed Control");
        }

        public string HelloUser(string username)
        {
            return "Hello " + username;
        }
    }
}
