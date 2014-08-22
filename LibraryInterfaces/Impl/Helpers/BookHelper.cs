using System;

using Library.Interfaces.Helpers;
using Library.Interfaces.Entities;

using Library.Impl.Entities;

namespace Library.Impl.Helpers
{
    public class BookHelper : IBookHelper
    {
        public IBook MakeBook(string author, string title, string callNumber, int id)
        {
            return new Book(author, title, callNumber, id);
        }

    }
}
