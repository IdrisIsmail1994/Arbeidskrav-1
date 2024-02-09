using Microsoft.EntityFrameworkCore;
using Champions_League.Models;



namespace Champions_League.Data
{
    public class CLDbContext : DbContext
    {

        public CLDbContext(DbContextOptions<CLDbContext> options) 
        : base(options)
        {
            
        }

        public DbSet<ChampionsLeagueVinnere> ChampionsLeague { get; set; }
        // public object ChampionsLeagueVinnere { get; internal set; }
    }
}