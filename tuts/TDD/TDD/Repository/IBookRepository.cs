using System.Collections.Generic;
using TDD.Models;

namespace TDD.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAll();
    }
}
