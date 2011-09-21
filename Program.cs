using System;
using System.Collections.Generic;
using System.Text;
using TestDll;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Value of UselessStuff.myTrue() is " + UselessStuff.myTrue().ToString());
            // Console.Write("End> "); Console.ReadLine(); // keep from quitting when debugging 
        }
    }
}
