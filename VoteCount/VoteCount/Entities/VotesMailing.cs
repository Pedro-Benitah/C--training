using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCount.Entities
{
    internal class VotesMailing
    {
        public Dictionary<string, int> Candidates { get; private set; } = new Dictionary<string, int>();

        public void AddCandidate(Candidates candidate)
        {
            if (!(Candidates.ContainsKey(candidate.Name)))
            {
                Candidates[candidate.Name] = candidate.Votes;
            }
            else
            {
                Candidates[candidate.Name] += candidate.Votes;
            }
        }

        public void RemoveCandidate(Candidates candidate)
        {
            if (!(Candidates.ContainsKey(candidate.Name)))
            {
                throw new ArgumentOutOfRangeException("An error occurred: Candidate is not on the list.");
            }
            Candidates.Remove(candidate.Name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var candidate in Candidates)
            {
                sb.Append(candidate.Key);
                sb.Append(": ");
                sb.AppendLine(candidate.Value.ToString());
            }

            return sb.ToString();
        }
    }
}
