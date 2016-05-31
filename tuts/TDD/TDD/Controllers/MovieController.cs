using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TDD.Repository;

namespace TDD.Controllers
{
    public class MovieController : Controller
    {
        private IMovieRepository _repository;

        public MovieController()
        {

            _repository = new InMemoryMovieRepository();
        }

        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index()
        {
            var movies = _repository.FindAll();

            return View(movies);
        }
    }
}
