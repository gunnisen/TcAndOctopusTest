using System;
using TCAndOctopusTest.Db;

namespace TCAndOctopusTest.DbInit
{
    class Program
    {
        static void Main(string[] args)
        {
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
