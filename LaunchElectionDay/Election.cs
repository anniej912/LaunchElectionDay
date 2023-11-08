using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Election
    {
        public string Year;
        public List<Race> Races;
        //public Dictionary<>

    public Election(string year) 
        { 
        Year = year;
        Races = new List<Race>();
        }

    public void AddRace(Race race) 
        {
        Races.Add(race);
        }
        
    public List<Candidate> AllCandidates()
        {
        var candidates = new List<Candidate>();

            foreach (Race race in Races)
            {
                foreach (var candidate in race.Candidates)
                {
                    candidates.Add(candidate);
                }
            }  
                return candidates;
        }



    public Dictionary<string, int> VoteCounts()
        {
            var voteCounts = new Dictionary<string, int>();
            foreach (Race race in Races)
            {
                foreach (var candidate in race.Candidates)
                {
                   voteCounts.Add(candidate.Name, candidate.Votes); 
                }
                   
            }
            return voteCounts;
        }
    
    }
}
