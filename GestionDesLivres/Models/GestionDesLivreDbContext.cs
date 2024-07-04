using Microsoft.EntityFrameworkCore;

namespace GestionDesLivres.Models
{
    public class GestionDesLivreDbContext: DbContext
    {
        public GestionDesLivreDbContext(DbContextOptions<GestionDesLivreDbContext> options) : base(options) { }

        public DbSet<Livre> livre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
