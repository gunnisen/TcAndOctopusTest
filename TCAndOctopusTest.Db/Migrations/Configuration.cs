namespace TCAndOctopusTest.Db.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<TCAndOctopusTest.Db.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TCAndOctopusTest.Db.MyDbContext";

            //var dbMigrator = new DbMigrator(this);
            //var pendingMigrationsExist = dbMigrator.GetPendingMigrations().Any();
            //if (pendingMigrationsExist)
            //{
            //    dbMigrator.Update();
            //}
        }

        protected override void Seed(TCAndOctopusTest.Db.MyDbContext context)
        {
            context.Artists.AddOrUpdate(x => x.Id,
                new Artist() { Id = 1, Name = "John Kinn" },
                new Artist() { Id = 2, Name = "Eva Dyveke Sakshaug (Eva D)" }
            );

            context.Albums.AddOrUpdate(x => x.Id,
                new Album() { Id = 1, ArtistId = 1, Title = "Marokko" },
                new Album() { Id = 2, ArtistId = 1, Title = "Kongens Plass" },
                new Album() { Id = 3, ArtistId = 1, Title = "Love & Lyg" },
                new Album() { Id = 4, ArtistId = 1, Title = "Høst" },
                new Album() { Id = 5, ArtistId = 2, Title = "Hvis du behøve mæ" }
            );

            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
