using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    public class LibraryMember : User
    {
        public List<Book> BorrowedBooks { get; } = new List<Book>();

        public LibraryMember(int id, string name) : base(id, name) {}

        public void BorrowBook(Library library, int bookId)
        {
            Book book = library.Books.FirstOrDefault(b => b.Id == bookId && b.IsAvailable);
            if (book != null)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed '{book.Title}'");
            }
            else
            {
                Console.WriteLine("Book not available or not found.");
            }
        }

        public void ReturnBook(Library library, int bookId)
        {
            Book book = BorrowedBooks.FirstOrDefault(b => b.Id == bookId);
            if (book != null)
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{Name} returned '{book.Title}'");
            }
            else
            {
                Console.WriteLine("You don't have that book.");
            }
        }
    }
}
