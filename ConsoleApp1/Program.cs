using MyDLL;
using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //object b = 2;
            //Console.WriteLine($"Hello World! {a} + {b} = {a + (int)b}");


            Logger.LogError("my msg");

            CultureInfo culture = new CultureInfo("ro-RO");
            double a = 123456789.123;
            Console.WriteLine(a.ToString("#,##0.00", culture));
        }
    }
}
