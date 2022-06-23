using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public static string Write(string file, object objectToPrint)
        {
            DateTime currentTime = DateTime.Now;

            var outputFilepath = Path.Combine(Path.GetFileNameWithoutExtension(FilePath(file)) + $"-output-{currentTime.ToString("HHmmss")}.txt");

            using (StreamWriter fileWriter = new StreamWriter(outputFilepath))
            {
                fileWriter.Write(JsonConvert.SerializeObject(objectToPrint));
            }

            return outputFilepath;
        }

        public static string FilePath(string file)
        {
            return $@"{Directory.GetCurrentDirectory()}\grids\{file}";
        }
    }
}
