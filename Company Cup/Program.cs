using Practice;
using System;
using System.Linq;

namespace CompanyCup
{
    class Program
    {
        static void Main(string[] args)
        {
            var gridNum = "0";
            var world = Parser.ParseFile($"{gridNum}.txt");


            Console.WriteLine($"Run started at {DateTime.Now.TimeOfDay}");



            Console.WriteLine($"Run stopped at {DateTime.Now.TimeOfDay}");
            Console.ReadKey();
        }
    }
}
