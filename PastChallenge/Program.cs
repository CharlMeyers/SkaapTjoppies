using CompanyCup.enums;
using CompanyCup.models;
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
            var lines = FileHelper.Read($"{gridNum}.txt");

            // 1. Create the world
            var worldDetails = lines[0];
            var world = new World(worldDetails);

            // 2. Create the clusters
            var clusters = new List<Cluster>();

            foreach (var clusterDetail in lines.Skip(1 + world.NumQuotas).Take(world.NumUniqueResources))
            {
                var resourceType = (ResourceType)int.Parse(clusterDetail.Split("|")[0]);
                var clusterSubDetails = clusterDetail.Split("|");
                clusterSubDetails.Skip(1).ToList().ForEach(csd => { clusters.Add(new Cluster(resourceType, csd)); });
            }

            Console.WriteLine($"Run started at {DateTime.Now.TimeOfDay}");

            world.Clusters = clusters;
            world.Run();

            world.Print($"{gridNum}-1.txt");

            Console.WriteLine($"Run stopped at {DateTime.Now.TimeOfDay}");
            Console.ReadKey();
        }
    }
}
