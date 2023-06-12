using IMS.Domain.Entities;
using IMS.Domain.Entities.Dependencies;
using Microsoft.EntityFrameworkCore;

namespace IMS.Infrastructure.Repository
{
    public class GlassesContext : DbContext
    {
        public GlassesContext(DbContextOptions<GlassesContext> options) : base(options)
        {
        }

        public DbSet<Glasses> Glasses { get; set; }
        public DbSet<GlassesColor> GlassesColors { get; set; }
        public DbSet<GlassesLensType> GlassesLensTypes { get; set; }
        public DbSet<GlassesSize> GlassesSizes { get; set; }

    }
}
