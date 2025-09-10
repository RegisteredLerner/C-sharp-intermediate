using System;

class Library
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public List<Book> SearchBooksByTitle(string value)
    {
        var res = new List<Book>();
        foreach (Book bk in books)
        {
            if (bk.Title.Contains(value) || bk.Author.Contains(value))
            {
                res.Add(bk);
            }
        }
        return res;
        
    }
    public void DisplayAllBooks()
    {
        foreach (Book bk in books)
        {
            Console.WriteLine(bk.Title+":"+bk.Author);
        }
    }
}