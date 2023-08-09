using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student
    {
        private string name;
        private int age;
        private string gender;
        private string studentID;
        private List<string> courseEnrollment = new List<string>();
        private List<int> courseGrades = new List<int>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public List<string> CourseEnrollment
        {
            get { return courseEnrollment; }
            set { courseEnrollment = value; }
        }

        public double GPA
        {
            get
            {
                if (courseGrades.Count == 0)
                    return 0;

                int totalGradePoints = 0;
                foreach (var grade in courseGrades)
                {
                    totalGradePoints += GetGradePoints(grade);
                }

                return (double)totalGradePoints / courseGrades.Count;
            }
        }

        private int GetGradePoints(int grade)
        {
            // This is a simple mapping of grades to grade points for the sake of demonstration.
            // You can modify this method to use a more elaborate grading system if needed.
            if (grade >= 90)
                return 4;
            else if (grade >= 80)
                return 3;
            else if (grade >= 70)
                return 2;
            else if (grade >= 60)
                return 1;
            else
                return 0;
        }

        public void AddCourseGrade(int grade)
        {
            courseGrades.Add(grade);
        }
    }
}
