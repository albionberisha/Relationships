namespace Relationships.Data
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }

    }
}
