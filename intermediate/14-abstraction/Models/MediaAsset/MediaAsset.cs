namespace Abstraction.Models;
public abstract class MediaAsset
{
    public string? Title { get; }
    public void ShowTitle() => Console.WriteLine($"Title: {this.Title}");

    public abstract void Play();
    public abstract void GetFormat();

}

public class AudioAsset : MediaAsset
{
    public override void GetFormat()
    {
        Console.WriteLine($"Media: Podcast");
    }

    public override void Play()
    {
        Console.WriteLine($"Audio ijro etildi: Podcast");
    }
}

public class VideoAsset : MediaAsset
{
    public override void GetFormat()
    {
        Console.WriteLine($"Media: Videodars");
    }

    public override void Play()
    {
        Console.WriteLine($"Audio ijro etildi: Videodars");
    }
}

public class PodcastAsset : MediaAsset
{
    public override void GetFormat()
    {
        Console.WriteLine("Podcast format: MP3");
    }

    public override void Play()
    {
        Console.WriteLine("Podkast tinglandi: C# yangiliklari");
    }
}