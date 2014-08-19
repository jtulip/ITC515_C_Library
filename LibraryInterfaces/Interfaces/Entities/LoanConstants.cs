
namespace Library.Interfaces.Entities
{
    public abstract class LoanConstants
    {
        public const int LOAN_PERIOD = 14;

        public enum LoanState { PENDING, CURRENT, OVERDUE, COMPLETE }

    }
}
