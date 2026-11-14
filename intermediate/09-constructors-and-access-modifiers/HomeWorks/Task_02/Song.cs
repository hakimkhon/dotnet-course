class Song
{
    public int Code;
    public string? Title;
    public int DurationSeconds;
    int PlayCount = 0;

    public Song(int code, string title, int durationSeconds)
    {
        this.Code = code;
        this.Title = title;
        this.DurationSeconds = durationSeconds;        
    }

    public void Play()
    {
        PlayCount++;
    }
   

    public string GetInfo() => $"{Code} — {Title}, {DurationSeconds} soniya, {PlayCount} marta ijro etildi";
    
}