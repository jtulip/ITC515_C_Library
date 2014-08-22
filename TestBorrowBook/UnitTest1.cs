using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//using Moq;
using NMock;

using Library;
using Library.Interfaces.Uis;
using Library.Interfaces.Controls;
using Library.Interfaces.Daos;
using Library.Interfaces.Entities;

using Library.Impl.Controls;

namespace TestBorrowBook
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MockFactory fac = new MockFactory();
            Mock<IBookDAO> mockBookDAO = fac.CreateMock<IBookDAO>();
            Mock<IMemberDAO> mockMemberDAO = fac.CreateMock<IMemberDAO>();
            Mock<ILoanDAO> mockLoanDAO = fac.CreateMock<ILoanDAO>();
            Mock<IMember> mockMember = fac.CreateMock<IMember>();


            //var mockBookDAO = new Mock<IBookDAO>();
            //var mockMemberDAO = new Mock<IMemberDAO>();
            //var mockLoanDAO = new Mock<ILoanDAO>();
            //var mockMember = new Mock<IMemberDAO>();

            //expects
            mockMemberDAO.Expects.One.Method(_ => _.GetMemberByID(1)).WillReturn(mockMember.MockObject);

            mockMember.Expects.AtLeastOne.GetProperty<bool>(_ => _.HasOverDueLoans).WillReturn(false);
            mockMember.Expects.AtLeastOne.GetProperty<bool>(_ => _.HasReachedLoanLimit).WillReturn(false);
            mockMember.Expects.AtLeastOne.GetProperty<bool>(_ => _.HasReachedFineLimit).WillReturn(false);
            mockMember.Expects.AtLeastOne.GetProperty<List<ILoan>>(_ => _.Loans).WillReturn(new List<ILoan>());
            mockMember.Expects.AtLeastOne.GetProperty<string>(_ => _.FirstName).WillReturn("John");
            mockMember.Expects.AtLeastOne.GetProperty<string>(_ => _.LastName).WillReturn("Smith");
            mockMember.Expects.AtLeastOne.GetProperty<string>(_ => _.ContactPhone).WillReturn("02 622 9423");


          


            BorrowBookUI gui = new BorrowBookUI();
            BorrowBookCTL ctl = new BorrowBookCTL(mockBookDAO.MockObject, mockMemberDAO.MockObject, mockLoanDAO.MockObject, gui);



            Application.Run(gui);
            gui.Initialise(ctl);
        }
    }
}

