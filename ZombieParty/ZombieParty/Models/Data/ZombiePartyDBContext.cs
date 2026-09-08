using Microsoft.EntityFrameworkCore;

namespace ZombieParty.Models.Data
{
    public class ZombiePartyDBContext: DbContext
    {
        public ZombiePartyDBContext(DbContextOptions<ZombiePartyDBContext> options) : base(options)
        {

        }

        public DbSet<Zombie> Zombies { get; set; }
        public DbSet<ZombieType> ZombieTypes { get; set; }

    }
}
