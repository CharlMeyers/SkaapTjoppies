using CompanyCup.models;
using Practice;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCup
{
    public static class Parser
    {
        public static World ParseFile(string filename)
        {
            var lines = FileHelper.Read(filename);
            var stepAllowance = lines[0].Substring(lines[0].IndexOf("=") + 1);
            var world = new World();

            //Reading resources
            var line = lines[2];
            var resourceTypes = new[] { "coal", "fish", "scrap_metal" };
            var index = Array.IndexOf(lines, line) + 1;
            while (Array.IndexOf(lines, line) + 1 < lines.Length)
            {
                if (resourceTypes.Any(r => line.Contains(r, StringComparison.InvariantCultureIgnoreCase)))
                {
                    var resourceInfo = line.Split(',');
                    var resourceName = resourceInfo[0];
                    var resourceCount = resourceInfo[1];

                    for (int i = Array.IndexOf(lines, line) + 1; i < lines.Length; i++)
                    {
                        line = lines[i];
                        index = i;

                        if (string.IsNullOrEmpty(line)) break;

                        var resource = new Resource(resourceName, line);

                        world.resources.Add(resource);
                    }

                }

                if (line.Contains("quota=", StringComparison.InvariantCultureIgnoreCase))
                {
                    var quota = new Quota(line.Substring(line.IndexOf("=") + 1));
                    world.quota = quota;
                }

                if (line.Contains("quota_multiplier", StringComparison.InvariantCultureIgnoreCase))
                {
                    var quotaMultiplier = decimal.Parse(line.Substring(line.IndexOf("=") + 1), CultureInfo.InvariantCulture);
                    world.quotaMultiplier = quotaMultiplier;
                }

                if (line.Contains("map_size=", StringComparison.InvariantCultureIgnoreCase))
                {
                    var mapSize = new Dimension(line.Substring(line.IndexOf("=") + 1));
                    world.size = mapSize;
                    for (int i = Array.IndexOf(lines, line) + 1; i < lines.Length; i++)
                    {
                        line = lines[i];
                        index = i;

                        world.AddLandscape(line);
                    }
                }

                line = lines[index++];
            }



            return world;
        }
    }
}
