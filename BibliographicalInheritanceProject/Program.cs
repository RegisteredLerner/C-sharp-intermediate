using System;

namespace BiblioInheritance
{
  class Program
  {
        static void Main(string[] args)
        {
            Resource test = new Resource("grass", "material");
            test.UpdateStatus();
            test.GetInfo();
            Book book = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", "Charles Petzold", 396);
            book.GetInfo();
            Periodical p = new Periodical("Wired", "Technology", "Monthly");
            p.UpdateStatus();
            p.GetInfo();
            Video v = new Video("Ex Machina", "Sci-fi", "Alex Garland", 108, "On-Demand");
            v.UpdateStatus();
            v.GetInfo();
          
    }
  }
}