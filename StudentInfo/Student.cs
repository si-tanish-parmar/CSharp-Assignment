using System;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Fee
    {
        get
        {
            if (Course == "ASP.NET")
            {
                return 2000;
            }
            else
            {
                return 3000;
            }
        }
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id} NAME: {Name} COURSE: {Course} FEE: {Fee}");
    }

    public Student(int Id, string Name, string Course)
    {
        this.Id = Id;
        this.Name = Name;
        this.Course = Course;
    }
}
