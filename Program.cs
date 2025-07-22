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
        }
    }
}