namespace LibraryCorner.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string OrderBook {  get; set; }
        public Guid Salt {  get; set; }
        public List<Book> Books {  get; set; }
    }
}
