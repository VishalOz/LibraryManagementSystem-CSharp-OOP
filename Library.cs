using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Library
    {
        public List<Book> Books { get; } = new List<Book>();
        public List<User> Users { get; } = new List<User>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void ListAllBooks()
        {
            foreach(Book book in Books) {
                Console.WriteLine(book.ToString());
            }
        }
    }
}