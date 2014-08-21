using Library.Interfaces.Entities;

namespace Library.Interfaces.Helpers
{
    interface IMemberHelper
    {
        IMember MakeMember(string firstName, string lastName, string contactPhone, string emailAddress, int id);

    }
}
