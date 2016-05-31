using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TDD.Repository;

namespace TDD.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repository;

        public HomeController(IBookRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index()
        {
            var model = _repository.GetAll();

            return View(model);
        }

        public ViewResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ViewResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }

        public ViewResult FindByGenre(string genre)
        {
            var books = _repository.GetAll();
            var model = books.Where(b => b.Genre == genre);

            return View(model);
        }
    }

}
