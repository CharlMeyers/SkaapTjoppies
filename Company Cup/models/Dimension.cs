using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class Dimension
    {
        public int x;
        public int y;

        public Dimension(IReadOnlyList<string> dimensions)
        {
            x = int.Parse(dimensions[0]);
            y = int.Parse(dimensions[1]);
        }
    }
}
