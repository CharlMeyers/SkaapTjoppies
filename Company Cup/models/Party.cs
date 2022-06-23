using CompanyCup.enums;
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
        public List<Resource> ResourcesCollected { get; set; }

        public Party(Dimension position, List<PartyMember> members, int stepAllowance,
            Quota quota)
        {
            Position = position;
            Members = members;
            StepAllowance = stepAllowance;

            CalculateAdditionalStepAllowance();
        }

        public void CalculateAdditionalStepAllowance()
        {
            if (Members.Find(m => m.Type == PartyMemberType.Healer) != null)
            {
                StepAllowance += Convert.ToInt32(Math.Ceiling(0.2 * StepAllowance));
            }
        }


    }
}
