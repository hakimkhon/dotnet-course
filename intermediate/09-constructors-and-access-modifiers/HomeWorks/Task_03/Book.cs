namespace HomeWork;
public class Book
{
    public string ISBN;
    public string Title;
    private int _count;
    private readonly int _defaultCount;

    public int Count { get; internal set; }

    public Book(string isbn, string title, int count)
    {
        this.ISBN = isbn;
        this.Title = title;
        this._count = count;
        this._defaultCount = count;
    }

    public bool Borrow()
    {
        if (_count > 0)
        {
            _count--;
            return true;
        }

        return false;
    }

    public bool Returnnn()
    {
        if (_defaultCount == _count)
        {
            return false;
        }

        _count++;
        return true;
    }

}