using System.Collections.Generic;

using Library.Interfaces.Entities;
using Library.Interfaces.Helpers;

namespace Library.Interfaces.Daos
{
    public interface IMemberDAO
    {
        IMember AddMember(string firstName, string lastName, string ContactPhone, string emailAddress);

        IMember getMemberByID(int id);

        List<IMember> listMembers();

        List<IMember> findMembersByLastName(string lastName);

        List<IMember> findMembersByEmailAddress(string emailAddress);

        List<IMember> findMembersByNames(string firstName, string lastName);

    }
}
