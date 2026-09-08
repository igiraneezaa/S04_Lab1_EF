using Microsoft.EntityFrameworkCore;

namespace ZombieParty.Models.Data
{
    public class ZombiePartyDBContext: DbContext
    {
        public ZombiePartyDBContext(DbContextOptions<ZombiePartyDBContext> options) : base(options)
        {

        }

    }
}
