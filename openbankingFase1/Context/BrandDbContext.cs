using Microsoft.EntityFrameworkCore;


namespace openbankingFase1.Context

{
    public class BrandDbContext : DbContext
    {
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<Companies> Companies { get; set; }

        public BrandDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
