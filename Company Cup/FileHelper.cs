using System;
using System.Collections.Generic;
using System.IO;

namespace Practice
{
    public static class FileHelper
    {
        public static string[] Read(string filename)
        {
            string[] lines = new string[0];

            try
            {
                lines = File.ReadAllLines(FilePath(filename));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"{filename} could not be found");
            }

            return lines;
        }

        public static string Write(string file, List<string> objectToPrint)
        {
            DateTime currentTime = DateTime.Now;

            var outputFilepath = Path.Combine(Path.GetFileNameWithoutExtension(FilePath(file)) + $"-output-{currentTime.ToString("HHmmss")}.txt");

            using (StreamWriter fileWriter = new StreamWriter(outputFilepath))
            {
                foreach (var item in objectToPrint)
                {
                    fileWriter.WriteLine(item);
                }
            }

            return outputFilepath;
        }

        public static string FilePath(string file)
        {
            return $@"{Directory.GetCurrentDirectory()}\grids\{file}";
        }
    }
}
