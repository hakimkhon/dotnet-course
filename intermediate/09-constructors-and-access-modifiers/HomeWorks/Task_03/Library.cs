namespace HomeWork;

public class Library
{
    private Dictionary<string, Book> Books;
    private int Capacity;
    public Library(int capacity)
    {
        this.Books = new Dictionary<string, Book>(capacity);
        this.Capacity = capacity;
    }

    public bool AddBook(Book book)
    {
        if (Capacity > 0 && !this.Books.ContainsKey(book.ISBN))
        {
            this.Books.Add(book.ISBN, book);
            Capacity --;
            return true;
        }

        return false;
    }

    public bool BorrowBook(string isbn)
    {
        if (this.Books.ContainsKey(isbn))
        {
            var book = this.Books[isbn];
            return book.Borrow();
        }

        return false;
    }

    public bool ReturnBorrow(string isbn)
    {
        if (this.Books.ContainsKey(isbn))
        {
            return this.Books[isbn].Returnnn();
        }

        return false;
    }

    public int GetAvailableCopies()
    {
        int count = 0;
        foreach (var book in Books)
        {
            count += book.Value.Count;
        }

        return count;
    }

    public void PrintUnavailableBooks()
    {
        foreach (var book in Books)
        {
            if (book.Value.Count == 0)
            {
                Console.WriteLine($"{book.Value.ISBN} - {book.Value.Title}");
            }
        }
    }
}
