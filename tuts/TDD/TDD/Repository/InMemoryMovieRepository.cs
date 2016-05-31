using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Models;

namespace TDD.Repository
{
    public class InMemoryMovieRepository : IMovieRepository
    {
        public IQueryable<Movie> FindAll()
        {
            return null;
        }
    }
}
