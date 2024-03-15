using Bowler2.Data;

namespace Bowler2.Data
{
    public class EFBowlerRepo : IBowlerRepo
    {
        private readonly Bowlercontext _context;

        public EFBowlerRepo(Bowlercontext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;

        public IEnumerable<BowlerTeams> GetBowlersWithTeams()
        {
            // Perform the join operation between Bowlers and Teams based on TeamId
            var query = from bowler in _context.Bowlers
                        join team in _context.Teams on bowler.TeamId equals team.TeamId
                        where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                        select new BowlerTeams
                        {
                            BowlerId = bowler.BowlerId,
                            BowlerLastName = bowler.BowlerLastName,
                            BowlerFirstName = bowler.BowlerFirstName,
                            BowlerMiddleInit = bowler.BowlerMiddleInit,
                            BowlerAddress = bowler.BowlerAddress,
                            BowlerCity = bowler.BowlerCity,
                            BowlerState = bowler.BowlerState,
                            BowlerZip = bowler.BowlerZip,
                            BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                            TeamId = bowler.TeamId,
                            TeamName = team.TeamName
                        };

            var blah = query.ToList();

            return blah;

        }
    }

}
