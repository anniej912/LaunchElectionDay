using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay.UnitTests
{
    public class RaceTesting
    {
        [Fact]
        public void RegisterCandidate_RegistersNewCandidate()
        {
            var annie = new Candidate("Annie M", "Silly Goose");
            var coty = new Candidate("Coty E", "Sillier Goose");
            var race1 = new Race("Silliest Little Guy");
            
            race1.RegisterCandidate(annie);
            race1.RegisterCandidate(coty);
            
            Assert.Equal(new List<Candidate>() { annie, coty }, race1.Candidates);
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
