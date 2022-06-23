using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCup.models
{
    public class Party
    {
        public Dimension Position { get; set; }
        public List<PartyMember> Members { get; set; }
        public int StepAllowance { get; set; }
        public Quota Quota { get; set; }
    }
}
