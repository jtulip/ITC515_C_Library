using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Library.Impl.Entities;
using Library.Interfaces.Entities;
using Moq;
using System.Reflection;

namespace LibraryTests
{
    [TestClass]
    public class TestBook
    {
        //arrange
        string author = "author";
        string title = "title";
        string callNumber = "A 1.2345";
        int bookID = 1;

        [TestMethod]
        public void TestConstructorOK()
        {
            //act
            var book = new Book(author, title, callNumber, bookID);
            Assert.IsNotNull(book);
            Assert.IsTrue(book is IBook);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorNullParam()
        {
            //act
            var book = new Book(null, title, callNumber, bookID);
        }

        [TestMethod]
        public void TestBorrow()
        {
            //arrange
            var book = new Book(author, title, callNumber, bookID);
            var mock = new Mock<ILoan>();
            ILoan mockLoan = mock.Object;
            Type t = typeof(Book);
            FieldInfo loanF = t.GetField("loan", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo stateF = t.GetField("state", BindingFlags.NonPublic | BindingFlags.Instance);
            BookConstants.BookState expectedState = BookConstants.BookState.ON_LOAN;
 
            //act
            book.Borrow(mockLoan);

            //inspect
            var actualLoan = loanF.GetValue(book);
            var actualState = stateF.GetValue(book);

            //asserts
            Assert.AreEqual(mockLoan, actualLoan);
            Assert.AreEqual(expectedState, actualState);
        }

        [TestMethod]
        public void TestReturnUndamaged()
        {
            //arrange
            var book = new Book(author, title, callNumber, bookID);
            var mock = new Mock<ILoan>();
            ILoan mockLoan = mock.Object;
            Type t = typeof(Book);
            FieldInfo loanF = t.GetField("loan", BindingFlags.NonPublic | BindingFlags.Instance);
            loanF.SetValue(book, mockLoan);
            FieldInfo stateF = t.GetField("state", BindingFlags.NonPublic | BindingFlags.Instance);
            stateF.SetValue(book, BookConstants.BookState.ON_LOAN);
            BookConstants.BookState expectedState = BookConstants.BookState.AVAILABLE;

            //act
            book.ReturnBook(false);

            //inspect
            var actualLoan = loanF.GetValue(book);
            var actualState = stateF.GetValue(book);

            //asserts
            Assert.AreEqual(null, actualLoan);
            Assert.AreEqual(expectedState, actualState);
        }

        [TestMethod]
        public void TestReturnDamaged()
        {
            //arrange
            var book = new Book(author, title, callNumber, bookID);
            var mock = new Mock<ILoan>();
            ILoan mockLoan = mock.Object;
            Type t = typeof(Book);
            FieldInfo loanF = t.GetField("loan", BindingFlags.NonPublic | BindingFlags.Instance);
            loanF.SetValue(book, mockLoan);
            FieldInfo stateF = t.GetField("state", BindingFlags.NonPublic | BindingFlags.Instance);
            stateF.SetValue(book, BookConstants.BookState.ON_LOAN);
            BookConstants.BookState expectedState = BookConstants.BookState.DAMAGED;

            //act
            book.ReturnBook(true);

            //inspect
            var actualLoan = loanF.GetValue(book);
            var actualState = stateF.GetValue(book);

            //asserts
            Assert.AreEqual(null, actualLoan);
            Assert.AreEqual(expectedState, actualState);
        }

        [TestMethod]
        public void TestProperty()
        {
            //arrange
            var book = new Book(author, title, callNumber, bookID);
            //act
            var actualAuthor = book.Author;

            //asserts
            Assert.AreEqual(author, actualAuthor);
        }
    }
}
