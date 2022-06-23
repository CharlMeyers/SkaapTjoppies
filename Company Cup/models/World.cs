using CompanyCup.enums;
using CompanyCup.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var lanscapeRow = new List<LandscapeType>();
            var currentRow = Lanscape.Count;
            foreach (var item in landscapeDetails.Split(',').Select((value, i) => (value, i)))
            {
                if (resources.Any(r => r.Position.y == item.i && r.Position.x == currentRow))
                {
                    lanscapeRow.Add(LandscapeType.Resource);
                }
                else
                {
                    lanscapeRow.Add(item.value.ToLanscapeType().GetValueOrDefault());
                }
            }
            Lanscape.Add(lanscapeRow);
        }
    }
}
