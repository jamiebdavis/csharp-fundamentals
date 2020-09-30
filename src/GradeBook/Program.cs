using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("james grade book");
            try
            {
                book.AddGrade(99);
                book.AddGrade(88);
                book.AddGrade(77);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            // while (true)
            // {
            //     Console.WriteLine("enter a grade or q to quit");
            //     var input = Console.ReadLine();

            //     if (input == "q")
            //     {
            //         break;
            //     }

            //     var grade = int.Parse(input);
            //     book.AddGrade(grade);
            // }

            var stats = book.GetStatistics();

            System.Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The low grade is {stats.Low}");
            Console.WriteLine($"The high grade is {stats.High}");
            Console.WriteLine($"The letter is {stats.Letter}");
        }
    }
}
