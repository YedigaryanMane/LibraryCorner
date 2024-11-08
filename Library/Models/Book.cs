﻿namespace LibraryCorner.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public bool IsReserved {  get; set; }
        public int Quanitity { get; set; }
        public List<User> User { get; set; }
        public List<Author> Author { get; set; }
    }
}
