namespace NetCoreWorkshop1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Person Author { get; set; }
    }
}