class Book
{
    public string ISBN;
    public int Title;
    private int _count;
    private readonly int _defaultCount;

    public Book(string isbn, int title, int count)
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

    public bool Return()
    {
        if (_defaultCount == _count)
        {
            return false;
        }

        _count++;
        return true;
    }

}