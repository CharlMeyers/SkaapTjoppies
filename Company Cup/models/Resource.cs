using CompanyCup.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class Resource
    {
        public ResourceType Type { get; set; }
        public Dimension Position { get; set; }
    }
}
