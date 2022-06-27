using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCount.Entities
{
    internal class Candidates
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Candidates(string name, int votes)
        {
            Name = name;
            Votes = votes;
        }

        public override string ToString()
        {
            return Name
                + ": "
                + Votes;
        }
    }
}
