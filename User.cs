namespace LibraryApp
{
    public abstract class User
    {
        public int Id { get; }
        public string Name { get; }

        protected User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public virtual void ViewBooks(Library library)
        {
            library.ListAllBooks();
        }

    }
}