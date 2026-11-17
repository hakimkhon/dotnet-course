using System;
namespace Homework11;

class GradeBook
{
    private string _studentName;
    private int[] _count;
    public string StudentName => _studentName;
    public int[] Count => _count;

    public GradeBook(string nameStudent, int[] counts)
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
                _count = counts;
                _studentName = nameStudent;
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
    // public int[] GetGrades(){}
    public int[] GetGrades()
    {
        int[] copy = new int[_count.Length];
        for (int i = 0; i < _count.Length; i++)
        {
            copy[i] = _count[i];
        }
        return copy;
    }
    public int GetAverage()
    {
        int result = 0;
        foreach (var item in _count)
        {
            result += item;   
        }
        return (int)result / _count.Length;
    }

}