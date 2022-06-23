using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class Quota
    {
        public int Coal { get; set; }
        public int Fish { get; set; }
        public int ScrapMetal { get; set; }

        public Quota(string quotas)
        {
            var quotaList = quotas.Split(',');
            Coal = int.Parse(quotaList[0]);
            Fish = int.Parse(quotaList[1);
            ScrapMetal = int.Parse(quotaList[2]);
        }
    }
}
