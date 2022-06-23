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


            }
            return landscapes;
        }

        public static LandscapeType? ToLanscapeType(this string detail)
        {
            return detail.ToLowerInvariant() switch
            {
                "i" => LandscapeType.Ice,
                "s" => LandscapeType.Snow,
                "ts" => LandscapeType.ThickSnow,
                "m" => LandscapeType.Mountain,
                _ => null
            };
        }
    }
}
