class Course
{
    public string? TitleCourse;
    public int LessonsCount;

    public Course()
    {
        Console.WriteLine("C# asoslari — 12 ta dars");
    }

    public Course(string title)
    {
        this.TitleCourse = title;
        if (title.Trim().Length > 0)
        {
            Console.WriteLine($"{title} — 12 ta dars");
        }
        else 
            Console.WriteLine("ArgumentException");        
    }

    public Course(string title, int lessonCount)
    {
        this.LessonsCount = lessonCount;
        this.TitleCourse = title;

        if (title.Trim().Length > 0 && lessonCount > 0)
        {
            Console.WriteLine($"{title} — {lessonCount} ta dars");
        }
        else 
            Console.WriteLine("ArgumentOutOfRangeException");  
    }
}
