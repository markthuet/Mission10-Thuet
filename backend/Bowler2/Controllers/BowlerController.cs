using Bowler2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bowler2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepo _bowlerRepo;

        public BowlerController(IBowlerRepo temp)
        {
            _bowlerRepo = temp;
        }

        [HttpGet]
        public IEnumerable<BowlerTeams> Get()
        {
            // Get all bowlers
            IEnumerable<BowlerTeams> bowlerData = _bowlerRepo.GetBowlersWithTeams();

            return bowlerData;

            /* // Join with teams based on TeamId
             foreach (var bowler in bowlerData)
             {
                 // Populate the Team navigation property for each bowler
                 bowler.Team = _bowlerRepo.GetTeamById(bowler.TeamId);
             }

             return bowlerData;*/

        }
    }
}

