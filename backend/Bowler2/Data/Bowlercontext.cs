using Bowler2.Data;
using Microsoft.EntityFrameworkCore;

namespace Bowler2.Data
{
    public class Bowlercontext : DbContext
    {
        public Bowlercontext(DbContextOptions<Bowlercontext> options) : base(options) { }

        // DbSet for the Bowlers table
        public DbSet<Bowler> Bowlers { get; set; }

        // DbSet for the Teams table
        public DbSet<Team> Teams { get; set; }
    }
}