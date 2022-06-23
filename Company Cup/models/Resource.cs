using CompanyCup.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class Resource
    {
        public string Name { get; set; }
        public Dimension Position { get; set; }
        public ResourcePoints Points { get; set; }
        public int Quota { get; set; }
    }
}
