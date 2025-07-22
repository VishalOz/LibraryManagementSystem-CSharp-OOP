namespace LibraryApp
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }
        public string Author { get; }
        public bool IsAvailable { get; set; } = true;

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Id}.{Title} by {Author} - {(IsAvailable ? "Available" : "Borrowed")}";
        }

    }
}