using System;

using Library.Interfaces.Helpers;
using Library.Interfaces.Entities;
using Library.Impl.Entities;

namespace Library.Impl.Helpers
{
    public class MemberHelper : IMemberHelper
    {
        public IMember MakeMember(string firstName, string lastName, string contactPhone, string emailAddress, int id)
        {
            return new Member(firstName, lastName, contactPhone, emailAddress, id);
        }
    }
}
