namespace HomeWork;
class PlayList
{
    public string? Title;
    private List<Song> Songs;
    private int Capacity;
    public PlayList(string title, int capacity)
    {
        this.Songs = new List<Song>(capacity);
        this.Capacity = capacity;
        this.Title = title;        
    }

    public bool AddSong(Song song)
    {
        if (Capacity > 0 && !this.Songs.Contains(song))
        {
            this.Songs.Add(song);
            Capacity++;
            return true;
        }

        return false;
    }
}