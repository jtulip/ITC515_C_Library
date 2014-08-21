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
        public Member(String firstName, String lastName, String contactPhone,
                      String email, int memberID)
        {
            if (!sane(firstName, lastName, contactPhone, email, memberID))
            {
                throw new ArgumentException("Member: constructor : bad parameters");
            }
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactPhone = contactPhone;
            this.emailAddress = email;
            this.id = memberID;
            this.loanList = new List<ILoan>();
            this.fineAmount = 0.0f;
            this.state = MemberConstants.MemberState.BORROWING_ALLOWED;
        }

        private bool sane(string firstName, string lastName, string contactPhone,
                string emailAddress, int memberID)
        {
            return (!string.IsNullOrEmpty(firstName) &&
                    !string.IsNullOrEmpty(lastName)  &&
                    !string.IsNullOrEmpty(contactPhone) &&
                    !string.IsNullOrEmpty(emailAddress) &&
                     memberID > 0
                    );
        }

        private bool hasOverDueLoans;
        public bool HasOverDueLoans
        {
            get 
            {
                foreach (ILoan loan in loanList)
                {
                    if (loan.IsOverDue) return false;
                } 
				return true;
			}
        }

        private bool hasReachedLoanLimit;
        public bool HasReachedLoanLimit
        {
            get { return loanList.Count >= MemberConstants.LOAN_LIMIT; }
        }

        private bool hasFinesPayable;
        public bool HasFinesPayable
        {
            get { return fineAmount > 0.0f; }
        }

        private bool hasReachedFineLimit;
        public bool HasReachedFineLimit
        {
            get { return fineAmount > MemberConstants.FINE_LIMIT; }
        }

        private float fineAmount;
        public float FineAmount
        {
            get { return fineAmount; }
        }

        public void AddFine(float fine)
        {
            if (fine < 0)
            {
                throw new ArgumentException("Member: AddFine : fine cannot be negative");
            }
            fineAmount += fine;
            updateState();
        }

        public void PayFine(float payment)
        {
            if (payment < 0 || payment > fineAmount)
            {
                throw new ArgumentException("Member: PayFine : payment cannot be negative, or greater than amount owed");
            }
            fineAmount -= payment;
            updateState();
        }

        public void AddLoan(ILoan loan)
        {
            if (loan == null)
            {
                throw new ArgumentException("Member: AddLoan : loan cannot be null");
            }
            if (!BorrowingAllowed)
            {
                string mesg = String.Format("Member: AddLoan : illegal operation in state: {0}", state);
                throw new IllegalStateException(mesg);
            }
            loanList.Add(loan);
            updateState();
        }

        private List<ILoan> loanList;
        public List<ILoan> Loans
        {
            get {
                return new List<ILoan>(loanList);
            }
        }

        public void RemoveLoan(ILoan loan)
        {
            if (loan == null)
            {
                throw new ArgumentException("Member: RemoveLoan : loan cannot be null");
            }
            if (!loanList.Contains(loan))
            {
                throw new ArgumentException("Member: RemoveLoan : loan not present");
            }
            loanList.Remove(loan);
            updateState();

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

        private bool BorrowingAllowed
        {
            get
            {
                return !HasReachedFineLimit && !HasReachedLoanLimit && !HasOverDueLoans;
            }
        }

        private void updateState()
        {
            if (BorrowingAllowed)
            {
                state = MemberConstants.MemberState.BORROWING_ALLOWED;
            }
            else
            {
                state = MemberConstants.MemberState.BORROWING_DISALLOWED;
            }
        }

        public override string ToString()
        {
            return String.Format(
                    "Id: {0}\nName: {1} {2}\nContact Phone: {3}\nEmail: {4}\nOutstanding Charges: {5:0.00}", id,
                    firstName, lastName, contactPhone, emailAddress, fineAmount);
        }


    }
}
