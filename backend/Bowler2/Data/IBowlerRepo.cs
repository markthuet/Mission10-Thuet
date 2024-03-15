using Bowler2.Data;
using System.Collections.Generic;

namespace Bowler2.Data
{
    public interface IBowlerRepo
    {
        IEnumerable<Bowler> Bowlers { get; }

        public IEnumerable<BowlerTeams> GetBowlersWithTeams();
    }
}