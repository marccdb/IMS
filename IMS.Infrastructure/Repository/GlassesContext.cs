using Microsoft.EntityFrameworkCore;
using IMS.Domain.Entities;

namespace IMS.Infrastructure.Repository
{
    public class GlassesContext : DbContext
    {
        public GlassesContext(DbContextOptions<GlassesContext> options) : base(options)
        {
        }

        public DbSet<Glasses> Glasses { get; set; }


    }
}
