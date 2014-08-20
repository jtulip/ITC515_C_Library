using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Entities;
using Library.Impl.Exceptions;

namespace Library.Impl.Entities
{
    public class Member : IMember
    {
        private bool hasOverDueLoans;
        public bool HasOverDueLoans
        {
            get { return hasOverDueLoans; }
        }

        private bool hasReachedLoanLimit;
        public bool HasReachedLoanLimit
        {
            get { return hasReachedLoanLimit; }
        }

        private bool hasFinesPayable;
        public bool HasFinesPayable
        {
            get { return hasFinesPayable; }
        }

        private bool hasReachedFineLimit;
        public bool HasReachedFineLimit
        {
            get { return hasReachedFineLimit; }
        }

        private float fineAmount;
        public float FineAmount
        {
            get { return fineAmount; }
        }

        public void AddFine(float fine)
        {

        }

        public void PayFine(float payment)
        {

        }

        public void AddLoan(ILoan loan)
        {

        }

        private List<ILoan> loans;
        public List<ILoan> Loans
        {
            get { return loans; }
        }

        public void RemoveLoan(ILoan loan)
        {

        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
        }

        private string contactPhone;
        public string ContactPhone
        {
            get { return contactPhone; }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; }
        }

        private int id;
        public int ID
        {
            get { return id; }
        }

        private MemberConstants.MemberState state;
        public MemberConstants.MemberState State
        {
            get { return state; }
        }


    }
}
