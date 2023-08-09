using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class School
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayStudentList()
        {
            Console.WriteLine("Student List:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, StudentID: {student.StudentID}, GPA: {student.GPA:F2}");
            }
        }

        public double CalculateOverallGPA()
        {
            if (students.Count == 0)
                return 0;

            double totalGPA = 0;
            foreach (var student in students)
            {
                totalGPA += student.GPA;
            }

            return totalGPA / students.Count;
        }
    }
}
