namespace LibraryCorner.Models.RequestModels
{
    public class RequestBook
    {
        public RequestBook( string title, int year)
        {
            Title = title;
            Year = year;
        }

        public string Title { get; set; }
        public int Year {  get; set; }
    }
}
