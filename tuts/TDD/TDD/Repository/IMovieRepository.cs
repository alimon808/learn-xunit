using System.Linq;
using TDD.Models;

namespace TDD.Repository
{
    public interface IMovieRepository
    {
        IQueryable<Movie> FindAll();
    }
}
