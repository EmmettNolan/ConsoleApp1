using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            ComputerGame cg1 = new ComputerGame("Sonic", 29.99m, new DateTime(1998))

            ComputerGame cg2 = new ComputerGame("Mario", 24.99m, new DateTime(1999))

            DisplayGame(cg1);
            DisplayGame(cg2);
        }
    }
}
