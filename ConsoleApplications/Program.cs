using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Tutorial__ZK_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi! what is your name? Write and Press Enter to Continue");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello there, " + Name + "! my name is Mr. Tutorial Man!");
            Console.ReadKey();
        }
    }
}
