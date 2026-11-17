using System;
namespace Homework11;

class GradeBook
{
    private string _studentName;
    private int[] _count = new int[];
    public string StudentName => _studentName;
    public int[] Count => _count;

    public GradeBook(string nameStudent, int[] count = new int[])
    {
        bool isNegativeElement = true;
        if (!string.IsNullOrEmpty(nameStudent) && counts != null)
        {
            foreach (var item in counts)
            {
                if (0 > item || item >= 100)
                {
                    isNegativeElement = false;
                }
            }
            if (isNegativeElement)
            {
                this.Count = count;
                this.StudentName = nameStudent;
            }
        }
    }
    public bool TryUpdateGrade(int index, int grade)
    {
        if (grade is >= 0 and <= 100 && index >= 0)
        {
            Count[index] = grade;
            Console.WriteLine("True; ");
            return true;
        }

        Console.WriteLine("False; ");
        return false;
    }
    public int[] GetGrades()
    {
        
    }

}