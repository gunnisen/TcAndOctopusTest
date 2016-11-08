namespace TCAndOctopusTest.Db
{
    public class Album
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
