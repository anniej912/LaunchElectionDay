using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Race
    {
        public string Office;
        public bool IsOpen;
        public List<Candidate> Candidates {  get; set; }
        public Race(string office)
        {
            Office = office;
            IsOpen = true;
            Candidates = new List<Candidate>();
        }

        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }

        public void Close()
        {
            if (IsOpen == true)
            {
                IsOpen = false;
            }
        }

        public void Winner()
        {
            foreach (Candidate candidate in Candidates)
            {
                if (!IsOpen)
                {
                    
                }
            }
         }












    }
}
