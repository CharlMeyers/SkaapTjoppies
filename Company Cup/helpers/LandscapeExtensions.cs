using CompanyCup.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCup.helpers
{
    public static class LandscapeExtensions
    {
        public static List<LandscapeType> ToLandscapeType(this string[] landscapeDetails)
        {
            var landscapes = new List<LandscapeType>();
            foreach (var landscape in landscapeDetails)
            {
                switch (landscape.ToLowerInvariant())
                {
                    case "i":
                        landscapes.Add(LandscapeType.Ice);
                        break;
                    case "s":
                        landscapes.Add(LandscapeType.Snow);
                        break;
                    case "ts":
                        landscapes.Add(LandscapeType.ThickSnow);
                        break;
                    case "m":
                        landscapes.Add(LandscapeType.Mountain);
                        break;
                    default:
                        break;
                }

            }
            return landscapes;
        }
    }
}
