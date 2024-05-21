using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCD
{
    class Program
    {
        private static int majorVersion = 1;
        private static int minorVersion = 5;
        static void Main(string[] args)
        {
            string versionNumber = majorVersion.ToString() + "." + minorVersion.ToString();
            string message = "Hello CD! This program is version number";
            Console.WriteLine(message + " " + versionNumber);

			Console.WriteLine("Now Rochak  is  changing even more to really notice if it is a new verison.");
	    Console.WriteLine("Now Rochak--2 is  changing even more to really notice if it is a new verison. ");
	    Console.WriteLine("Now Rochak--3 is  changing even more to really notice if it is a new verison. ");
		Console.WriteLine("Task completed---Done");

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
