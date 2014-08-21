using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Library.Impl.Entities;
using Library.Interfaces.Entities;
using Moq;
using System.Reflection;

namespace LibraryTests
{
    [TestClass]
    public class TestMember
    {
        private string fName = "Fred";
        private string lName = "Nurke";
        private string contact = "02 633 84931";
        private string email = "Fnurke@gmail.com";
        private int id = 1;

        private IMember borrower;

        [TestMethod]
        public void TestConstructorOK()
        {
            //act
            var borrower = new Member(fName, lName, contact, email, id);
            Assert.IsNotNull(borrower);
            Assert.IsTrue(borrower is IMember);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorNullParam()
        {
            //act
            var borrower = new Member(null, lName, contact, email, id);
        }

        [TestMethod]
        public void TestAddLoan()
        {
            //setup
            var borrower = new Member(fName, lName, contact, email, id);
            var mock = new Mock<ILoan>();
            ILoan mockLoan = mock.Object;
            Type t = typeof(Member);
            FieldInfo loanF = t.GetField("loan", BindingFlags.NonPublic | BindingFlags.Instance);

            //act
            borrower.AddLoan(mockLoan);

            Assert.IsNotNull(borrower);
            Assert.IsTrue(borrower is IMember);
        }

    }
}
