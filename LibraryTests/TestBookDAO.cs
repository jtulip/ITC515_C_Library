using System;
using System.Collections.Generic;
using System.Reflection;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Library.Interfaces.Daos;
using Library.Interfaces.Entities;
using Library.Interfaces.Helpers;

using Library.Impl.Daos;
using Library.Impl.Helpers;

namespace LibraryTests
{
    [TestClass]
    public class TestBookDAO
    {
        private Dictionary<int, IBook> bookDict;
        private Mock mockHelper;
        private IBookHelper mhelper;
        private Mock mockBook1, mockBook2;
        private IBook mbook1, mbook2;
        private string name = "John Smith";
        private string title = "Whatever";
        private string callNo = "SMI 1.1234";
        private int id = 1;

        private BookDAO dao;

        [TestInitialize]
        public void Setup()
        {
            bookDict = new Dictionary<int, IBook>();
            mockHelper = new Mock<IBookHelper>();
            mhelper = (IBookHelper)mockHelper.Object;
            mockBook1 = new Mock<IBook>();
            mbook1 = (IBook)mockBook1.Object;
            mockBook2 = new Mock<IBook>();
            mbook2 = (IBook)mockBook2.Object;

            dao = new BookDAO(mhelper);

        }

        [TestCleanup]
        public void TearDown()
        {
            bookDict = null;
            dao = null;
            mockHelper = null;
            mockBook1 = null;
            mockBook2 = null;
        }

        [TestMethod]
        public void TestAddBook()
        {
            var mockHelper = new Mock<IBookHelper>();
            dao = new BookDAO(mockHelper.Object);

            var mockBook = new Mock<IBook>();

            mockHelper.Setup<IBook>(m => m.MakeBook(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())).Returns(mockBook.Object);

            IBook actualBook = dao.AddBook(name, title, callNo);

            Assert.AreEqual(mockBook.Object, actualBook);
            mockHelper.VerifyAll();

            var field = typeof(BookDAO).GetField("bookDict", BindingFlags.NonPublic | BindingFlags.Instance);
            var dict = (Dictionary<int, IBook>) field.GetValue(dao);
            Assert.IsTrue(dict.Count == 1);

        }
    }
}
