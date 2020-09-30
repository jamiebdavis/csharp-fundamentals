using System;
using Xunit;

namespace GradeBook.tests
{
    public class TypeTests
    {

        [Fact]
        public void CanTestByType()
        {
            var x = GetInt();
            Assert.IsType<int>(x);
        }

        private int GetInt()
        {
            return 4;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "Book 666");

            Assert.Equal("Book 666", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book2, book1);
        }

        [Fact]
        public void TwoVarsCanReferenceTheSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book2, book1);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
