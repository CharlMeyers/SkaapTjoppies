using CompanyCup.models;
using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCup
{
    public static class Parser
    {
        public static void ParseFile(string filename)
        {
            var lines = FileHelper.Read(filename);
            var stepAllowance = lines[0].Substring(lines[0].IndexOf("="));
            var world = new World();

            //Reading resources
            var line = lines[2];
            var resourceTypes = new[] { "coal", "fish", "scrap_metal" };
            while (!line.Contains("quota", StringComparison.InvariantCultureIgnoreCase))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    if (resourceTypes.Any(r => line.Contains(r, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        var resourceInfo = line.Split(',');
                        var resourceName = resourceInfo[0];
                        var resourceCount = resourceInfo[1];

                        for (int i = Array.IndexOf(lines, line) + 1; i < lines.Length; i++)
                        {
                            line = lines[i];
                            var resource = new Resource(resourceName, line);

                            world.resources.Add(resource);
                        }
                    }
                }

                if (line.Contains("quota=", StringComparison.InvariantCultureIgnoreCase))
                {
                    var quota = new Quota(line.Substring(line.IndexOf("=")));
                    world.quota = quota;
                }

                if (line.Contains("quota_multiplier", StringComparison.InvariantCultureIgnoreCase))
                {
                    var quotaMultiplier = int.Parse(line.Substring(line.IndexOf("=")));
                    world.quotaMultiplier = quotaMultiplier;
                }
            }
        }
    }
}
