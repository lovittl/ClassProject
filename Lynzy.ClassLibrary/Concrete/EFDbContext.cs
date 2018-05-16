using Lynzy.Domain.Entities;
using System.Data.Entity;

namespace Lynzy.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        static EFDbContext()
        {
            Database.SetInitializer<EFDbContext>(null);
        }

        public DbSet<SongFiles> Song { get; set; }
    }
}
