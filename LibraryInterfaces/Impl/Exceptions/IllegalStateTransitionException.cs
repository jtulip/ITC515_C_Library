using System;

namespace Library.Impl.Exceptions
{
    class IllegalStateException : Exception
    {
        private string mesg;

        public IllegalStateException(string mesg)
        {
            this.mesg = mesg;
        }
    }
}
