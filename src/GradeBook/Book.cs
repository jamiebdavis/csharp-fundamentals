using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<int>();
            Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                // Single quotes for char
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(int grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"invalid {nameof(grade)}");
            }
        }


        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0;
            result.High = int.MinValue;
            result.Low = int.MaxValue;

            // foreach (var grade in grades)
            // while (index < grades.Count)
            // var index = 0;

            for (var index = 0; index < grades.Count; index++)
            {
                if (grades[index] > result.High)
                {
                    result.High = grades[index];
                }
                if (grades[index] < result.Low)
                {
                    result.Low = grades[index];
                }
                result.Average += grades[index];
            }

            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }


            return result;

        }
        List<int> grades = new List<int>();


        public String Name { get; set; }

        public const String CATEGORY = "Maths";
    }
}