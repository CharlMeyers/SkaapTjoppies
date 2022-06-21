using CompanyCup.helpers;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CompanyCup.models
{
    public class Ship
    {
        public Ship(int capacity)
        {
            Capacity = capacity;
            Coordinates = new Dimension(new List<string> { "0", "0", "0" });
            VisitedClusters = new List<Cluster>();
        }

        public int Capacity { get; set; }
        public int TakenResources { get; set; }

        public Dimension Coordinates { get; set; }

        public List<Cluster> VisitedClusters { get; set; }

        public void Run(ConcurrentBag<Cluster> clusters)
        {
            SortedList<double, Cluster> priorityList = new SortedList<double, Cluster>(Comparer<double>.Create((x, y) => y.CompareTo(x)));

            foreach (var c in clusters)
            {
                if (c.NumResources > 0)
                {

                    var distance = distanceCalculator.calculateDistance(this.Coordinates, c.Coordinates);

                    if (!priorityList.ContainsKey(distance))
                    {
                        priorityList.Add(distance, c);
                    }
                }
            }

            if (priorityList.Count > 0)
            {
                VisitCluster(priorityList.Values[0], clusters);
            }
        }

        public override string ToString()
        {
            if (VisitedClusters.Count == 0)
            {
                return "";
            }

            var ships = string.Join(",", VisitedClusters);
            ships += ",0";

            return ships;
        }

        private void VisitCluster(Cluster cluster, ConcurrentBag<Cluster> clusters)
        {
            if (this.TakenResources <= this.Capacity && cluster.NumResources > 0)
            {
                this.TakenResources += cluster.NumResources;
                cluster.NumResources = 0;
                this.Coordinates = cluster.Coordinates;

                this.VisitedClusters.Add(cluster);
                /*if (clusters.IndexOf(cluster) != -1)
                {
                    clusters..Remove(cluster);
                }*/
                Run(clusters);
            }

        }
    }
}
