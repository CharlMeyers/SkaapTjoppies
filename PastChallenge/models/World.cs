using Practice;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyCup.models
{
    public class World
    {
        public World(string detailString)
        {
            Dimensions = new Dimension(detailString.Split(","));

            var environmentString = detailString.Split("|");

            // 2. Get number of unique resources
            NumUniqueResources = int.Parse(environmentString[1]);

            // 3. Sort out the ships
            var numShips = int.Parse(environmentString[2]);
            var shipCapacity = int.Parse(environmentString[3]);

            Ships = new List<Ship>();

            for (var i = 0; i < numShips; i++)
            {
                Ships.Add(new Ship(shipCapacity));
            }

            // 4. Get number of labs
            NumLabs = int.Parse(environmentString[4]);

            // 5. Get outpost processed material threshold
            OutputProcessedMaterialThreshold = int.Parse(environmentString[5]);

            // 6. Get number of quotas
            NumQuotas = int.Parse(environmentString[6]);
        }

        public Dimension Dimensions { get; set; }

        public int NumUniqueResources { get; set; }

        public List<Ship> Ships { get; set; }

        public int NumLabs { get; set; }

        public int OutputProcessedMaterialThreshold { get; set; }

        public int NumQuotas { get; set; }

        public List<Cluster> Clusters { get; set; }

        public void Run()
        {
            Console.WriteLine($"Ships to run {Ships.Count}");
            var tasks = new List<Task>();
            foreach (var s in Ships)
            {
                Console.WriteLine($"Running Ship {Ships.IndexOf(s)}");
                tasks.Add(Task.Run(() => s.Run(new ConcurrentBag<Cluster>(Clusters))));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public void Print(string fileName)
        {
            var output = new List<string>();

            foreach (var s in Ships)
            {
                output.Add(s.ToString());
            }

            FileHelper.Write(fileName, output);
        }
    }
}
