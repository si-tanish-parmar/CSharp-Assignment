namespace StudentInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Tanish", "ASP.NET");
            Student s2 = new Student(2, "Kartikay", "C#");
            s1.Display();
            s2.Display();


        }
    }
}