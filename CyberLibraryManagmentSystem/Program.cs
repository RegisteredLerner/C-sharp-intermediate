using System;
using System.Collections.Generic;

namespace LibraryManagementSystem{
  class Program {
        static void Main()
        {
            // Initialize library
            Library library = new Library();
            Book bk1 = new Book("1984", "George Orwell");
            Book bk3 = new Book("11984", "George Orwelle");
            Book bk2 = new Book("To Kill a Mockingbird", "Harper Lee");
            library.AddBook(bk1);
            library.AddBook(bk2);
            library.AddBook(bk3);
            var results = library.SearchBooksByTitle("1984");
            foreach (Book bk in results)
            {
                Console.WriteLine(bk.Title + ":" + bk.Author);
            }
            Console.WriteLine();
            library.DisplayAllBooks();
        
            

        }
  }
}
