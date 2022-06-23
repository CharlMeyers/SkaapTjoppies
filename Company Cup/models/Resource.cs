using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class Resource
    {
        public string Name { get; set; }
        public Dimension Position { get; set; }
        public int Points { get; set; }
        public int Quota { get; set; }

        public Resource(string name, string dimention)
        {
            Name = name;
            Position = new Dimension(dimention);
        }
    }
}
