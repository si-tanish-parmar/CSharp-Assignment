namespace StudentGradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System");
            Console.WriteLine("----------------------");

            Student student = new Student();

            Console.Write("Enter the name of the student: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter the number of grades to be entered: ");
            int numOfGrades = Convert.ToInt32(Console.ReadLine());

            student.Grades = new double[numOfGrades];

            for (int i = 0; i < numOfGrades; i++)
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write($"Enter grade {i + 1}: ");
                    string gradeInput = Console.ReadLine();

                    try
                    {
                        double grade = Convert.ToDouble(gradeInput);
                        if (grade < 0 || grade > 100)
                        {
                            throw new Exception("Invalid input! Grade must be between 0 and 100.");
                        }
                        student.Grades[i] = grade;
                        validInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a numeric value.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Grades: {string.Join(", ", student.Grades)}");
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade()}");
        }
    }
}