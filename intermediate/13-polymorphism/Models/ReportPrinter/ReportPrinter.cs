namespace Models.Notifications;

public class ReportPrinter
{
    public void Print(string title)
    {
        Console.WriteLine(title);
    }
    public void Print(string title, decimal total)
    {
        Console.WriteLine($"{title}: {total} so'm");
    }
}