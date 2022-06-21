using System.Collections.Generic;

namespace CompanyCup.models
{
    public class Dimension
    {
        public int x;
        public int y;
        public int z;

        public Dimension(IReadOnlyList<string> dimensions)
        {
            x = int.Parse(dimensions[0]);
            y = int.Parse(dimensions[1]);
            z = int.Parse(dimensions[2].Split("|")[0]);
        }
    }
}
