using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Impl.Exceptions
{
    class IllegalStateTransitionException : Exception
    {
        private string mesg;

        public IllegalStateTransitionException(string mesg)
        {
            this.mesg = mesg;
        }
    }
}
