using System.Data.Entity;

namespace TCAndOctopusTest.Db
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("TCAndOctopusTest")
        {

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

    }
}
