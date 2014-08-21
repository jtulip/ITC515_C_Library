﻿using System;

namespace Library.Impl.Exceptions
{
    public class IllegalStateTransitionException : Exception
    {
        private string mesg;

        public IllegalStateTransitionException(string mesg)
        {
            this.mesg = mesg;
        }
    }
}
