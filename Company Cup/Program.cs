using Practice;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyCup
{
    class Program
    {
        static void Main(string[] args)
        {
            var gridNum = "5";
            var filename = $"{gridNum}.txt";
            var world = Parser.ParseFile(filename);


            Console.WriteLine($"Run started at {DateTime.Now.TimeOfDay}");



            Answer answer = world.Run();
            Console.WriteLine($"Run stopped at {DateTime.Now.TimeOfDay}");

            var filePath = FileHelper.Write(filename, answer);

            Console.WriteLine($"Answer saved at {filePath}");
            Console.ReadKey();
        }
    }
}
