using CompanyCup.enums;
using CompanyCup.helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class World
    {
        public List<Resource> resources { get; set; }
        public Quota quota { get; set; }
        public int quotaMultiplier { get; set; }
        public Dimension size { get; set; }
        public List<List<LandscapeType>> Lanscape { get; set; }

        public World()
        {
            resources = new List<Resource>();
            Lanscape = new List<List<LandscapeType>>();
        }

        public void AddLandscape(string landscapeDetails)
        {
            Lanscape.Add(landscapeDetails.Split(',').ToLandscapeType());
        }
    }
}
