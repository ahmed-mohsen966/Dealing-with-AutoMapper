namespace Dealing_with_AutoMapper.DTOs
{
    public class BookDto
    {
        public int BookID { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public Double Price { get; set; }
        public bool? IsFree { get; set; }
    }
}
