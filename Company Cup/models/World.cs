using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class World
    {
        public List<Resource> resources { get; set; }

        public World()
        {
            resources = new List<Resource>();
        }
    }
}
