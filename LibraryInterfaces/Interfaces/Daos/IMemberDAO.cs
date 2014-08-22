using System.Collections.Generic;

using Library.Interfaces.Entities;
using Library.Interfaces.Helpers;

namespace Library.Interfaces.Daos
{
    public interface IMemberDAO
    {
        IMember AddMember(string firstName, string lastName, string contactPhone, string emailAddress);

        IMember GetMemberByID(int id);

        List<IMember> MemberList
        {
            get;
        }

        List<IMember> FindMembersByLastName(string lastName);

        List<IMember> FindMembersByEmailAddress(string emailAddress);

        List<IMember> FindMembersByNames(string firstName, string lastName);

    }
}
