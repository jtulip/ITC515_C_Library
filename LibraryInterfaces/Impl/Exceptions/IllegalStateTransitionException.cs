using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
