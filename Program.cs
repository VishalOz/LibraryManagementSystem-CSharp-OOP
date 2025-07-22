using System;
namespace LibraryApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Library library = new Library();

            Admin admin = new Admin(1, "Vishal");
            library.AddUser(admin);

            LibraryMember member = new LibraryMember(2, "Bob");
            library.AddUser(member);

            admin.AddBook(library, new Book(1, "C# in Depth", "Jon Skeet"));
            admin.AddBook(library, new Book(2, "Clean Code", "Robert C. Martin"));
            admin.AddBook(library, new Book(3, "The Pragmatic Programmer", "Andy Hunt"));

            Console.WriteLine("\nAvailable Books:");
            library.ListAllBooks();

            member.BorrowBook(library, 2);  // Borrow Clean Code
            Console.WriteLine("\nAfter borrowing a book:");
            library.ListAllBooks();

            member.ReturnBook(library, 2);  // Return Clean Code
            Console.WriteLine("\nAfter returning a book:");
            library.ListAllBooks();
        }
    }
}