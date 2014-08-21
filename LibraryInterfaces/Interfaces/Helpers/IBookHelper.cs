using Library.Interfaces.Entities;

namespace Library.Interfaces.Helpers
{
    interface IBookHelper
    {
        IBook MakeBook(string author, string title, string callNumber, int id);

    }
}
