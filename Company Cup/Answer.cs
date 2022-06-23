using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCup
{
    public class Answer
    {
        public List<string> Party { get; set; }
        public List<List<int>> Path { get; set; }

        public Answer()
        {
            Party = new List<string>();

            Party.Add("Scout");
            Party.Add("Gatherer");

            Path = new List<List<int>>();
        }

    }
}
