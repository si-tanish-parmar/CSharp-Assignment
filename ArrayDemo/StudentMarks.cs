using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Develop a student grading system for a school. Write a C# program that takes the number of students in a class as input and then asks the user to enter each student's name and their score out of 100. Display the student names along with their corresponding letter grades using the standard grading scale.

namespace ArrayDemo
{
    internal class StudentMarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[num];
            string[] n = new string[num];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}");
                Console.WriteLine("Enter Marks :");
                s[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                n[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > 91 && s[i] < 100)
                {
                    Console.WriteLine("A1");
                    Console.WriteLine("Name: " + n[i]);
                }
                else if (s[i] > 81 && s[i] < 90)
                {
                    Console.WriteLine("Grade: A2");
                    Console.WriteLine("Name: " + n[i]);
                }
                else if (s[i] > 71 && s[i] < 80)
                {
                    Console.WriteLine("Grade: B1");
                    Console.WriteLine("Name: " + n[i]);
                }
                else if (s[i] > 61 && s[i] < 70)
                {
                    Console.WriteLine("Grade: B2");
                    Console.WriteLine("Name: " + n[i]);

                }
                else if (s[i] > 51 && s[i] < 60)
                {
                    Console.WriteLine("Grade: C1");
                    Console.WriteLine("Name: " + n[i]);
                }
                else if (s[i] > 41 && s[i] < 50)
                {
                    Console.WriteLine("Grade: C2");
                    Console.WriteLine("Name: " + n[i]);
                }
                else if (s[i] > 31 && s[i] < 40)
                {
                    Console.WriteLine("Grade: D");
                    Console.WriteLine("Name: " + n[i]);
                }
                else if (s[i] > 21 && s[i] < 30)
                {
                    Console.WriteLine("Grade: E1");
                    Console.WriteLine("Name: " + n[i]);
                }
                else if (s[i] > 0 && s[i] <20 )
                {
                    Console.WriteLine("Grade: E2");
                    Console.WriteLine("Name: " + n[i]);
                }
                else
                {
                    Console.WriteLine("Wrong Input!");
                }



            }
        }
    }
}
