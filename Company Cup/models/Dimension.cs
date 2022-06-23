using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class Dimension
    {
        public int x;
        public int y;

        public Dimension(string dimensions)
        {
            var dimentionList = dimensions.Split(',');
            x = int.Parse(dimentionList[0]);
            y = int.Parse(dimentionList[1]);
        }
    }
}
