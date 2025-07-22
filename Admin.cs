using System;

namespace LibraryApp
{
    public class Admin : User
    {
        public Admin(int id, string name) : base(id, name) { }

        public void AddBook(Library library, Book book)
        {
            library.Books.Add(book);
            Console.WriteLine($"Admin added '{book.Title}'");
        }
        public void RemoveBook(Library library, int BookId)
        {
            Book book = library.Books.Find(b => b.Id == book.Id);
            if (book != null)
            {
                library.Books.Remove(book);
                Console.WriteLine($"Admin removed '{book.Title}'");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}