using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");
var annie = new Candidate("Annie M", "Silly Goose");
Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();
annie.VoteFor();
annie.VoteFor();
Console.WriteLine(diana.Votes);


var race = new Race("City Council District 10");

race.RegisterCandidate(diana);
race.RegisterCandidate(annie);
foreach(var candidate in race.Candidates)
{
    Console.WriteLine($"{candidate.Name}");
}

var newElection = new Election("2023");

newElection.AddRace(race);

newElection.VoteCounts();

