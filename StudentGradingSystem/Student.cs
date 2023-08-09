﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double CalculateAverageGrade()
        {
            double sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Length;
        }
    }
}
