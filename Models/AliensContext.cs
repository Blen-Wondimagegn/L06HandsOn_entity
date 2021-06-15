using AliensEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace AliensContextEntityFramework.Models
{
    public class AliensContext: DbContext {
        public AliensContext(DbContextOptions<AliensContext> options) : base(options) {

        }
        public DbSet<Alien> Aliens { get; set; }
    }
}