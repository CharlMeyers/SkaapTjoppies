using Practice;
using System;

namespace CompanyCup
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = FileHelper.Read($"test.txt");



            Console.WriteLine($"Run started at {DateTime.Now.TimeOfDay}");



            Console.WriteLine($"Run stopped at {DateTime.Now.TimeOfDay}");
            Console.ReadKey();
        }
    }
}
