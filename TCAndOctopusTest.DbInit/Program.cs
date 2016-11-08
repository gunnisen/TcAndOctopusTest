using System;
using System.Data.Entity.Migrations;
using TCAndOctopusTest.Db;
using TCAndOctopusTest.Db.Migrations;

namespace TCAndOctopusTest.DbInit
{
    class Program
    {
        static void Main(string[] args)
        {

            var configuration = new Configuration();
            configuration.ContextType = typeof(MyDbContext);
            var migrator = new DbMigrator(configuration);
            migrator.Update();

            using (var db = new MyDbContext())
            {
                var albums = db.Albums.Include("Artist");
                foreach (var album in albums)
                {
                    Console.WriteLine($"{album.Artist.Name} - {album.Title}");
                }
            }
            //Console.WriteLine("(Press <ENTER> to quit.)");
            //Console.ReadLine();
        }
    }
}
