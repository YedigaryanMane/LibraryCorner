namespace LibraryCorner.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public List<Book> Books { get; set; }
    }
}
