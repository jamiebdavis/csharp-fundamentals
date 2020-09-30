using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89);
            book.AddGrade(90);
            book.AddGrade(77);

            //act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85, result.Average);
            Assert.Equal(90, result.High);
            Assert.Equal(77, result.Low);
            Assert.Equal('B', result.Letter);
        }
    }
}
