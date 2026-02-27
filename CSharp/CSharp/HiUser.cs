using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class HiUser : IMyInterface
    {
        public void ControlSpeed(int speed)
        {
            Console.WriteLine("Speed Control");
        }

        public string HelloUser(string username)
        {
            return "Salam " + username;
        }
    }
}
