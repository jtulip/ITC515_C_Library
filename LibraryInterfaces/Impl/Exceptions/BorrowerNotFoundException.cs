using System;

namespace Library.Impl.Exceptions
{
    public class BorrowerNotFoundException : Exception
    {
        private string mesg;

        public BorrowerNotFoundException(string mesg)
        {
            this.mesg = mesg;
        }
    }
}
