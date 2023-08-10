namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Student List");
                Console.WriteLine("3. Calculate Overall GPA");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudentDetails(school);
                        break;
                    case "2":
                        school.DisplayStudentList();
                        break;
                    case "3":
                        double overallGPA = school.CalculateOverallGPA();
                        Console.WriteLine($"Overall GPA of all students: {overallGPA:F2}");
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1-4).");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddStudentDetails(School school)
        {
            Student student = new Student();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.Readline());
           
            student.Age = age;

            Console.Write("Enter Gender: ");
            student.Gender = Console.ReadLine();

            Console.Write("Enter Student ID: ");
            student.StudentID = Console.ReadLine();

            Console.Write("Enter Course Enrollment (separate courses with commas): ");
            string enrollmentInput = Console.ReadLine();
            string[] courses = enrollmentInput.Split(',');
            student.CourseEnrollment.AddRange(courses);

            foreach (var course in courses)
            {
                Console.Write($"Enter grade for {course.Trim()}: ");
                int grade = Convert.ToInt32(Console.Readline());
                student.AddCourseGrade(grade);
            }

            school.AddStudent(student);

            Console.WriteLine("Student added successfully!");
        }
    }
}
