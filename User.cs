namespace LibraryApp
{
    public abstract class User
    {
        public int Id { get; }
        public string Name { get; }

        public User(int Id, string Name)
        {
            Id = Id;
            Name = Name;
        }
        public virtual void ViewBooks(Library library)
        {
            library.ListAllBooks();
        }

    }
}