namespace LibraryApp
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }
        public string Author { get; }
        public bool IsAvailable { get; set; } = true;

        public Book(int Id, string Title, string Author)
        {
            Id = Id;
            Title = Title;
            Author = Author;
        }

        public override string ToString()
        {
            return $"{Id}.{Title} by {Author} - {(IsAvailable ? "Available" : "Borrowed")}";
        }

    }
}