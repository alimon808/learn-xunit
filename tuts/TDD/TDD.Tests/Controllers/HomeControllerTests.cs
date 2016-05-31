using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Moq;
using TDD.Controllers;
using TDD.Models;
using TDD.Repository;
using Xunit;

namespace TDD.Tests.Controllers
{
    public class HomeControllerTests
    {
        private Mock<IBookRepository> _repository;
        private HomeController _sut;

        public HomeControllerTests()
        {
            _repository = new Mock<IBookRepository>();
            _sut = new HomeController(_repository.Object);
        }

        [Fact]
        public void ShouldReturnDefaultView()
        {
            ViewResult result = _sut.Index() as ViewResult;

            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldReturnContactView()
        {
            ViewResult result = _sut.Contact() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("Your contact page.", result.ViewBag.Message);
        }

        [Fact]
        public void ShouldReturnAboutView()
        {
            ViewResult result = _sut.About() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("Your about page.", result.ViewBag.Message);
        }

        [Fact]
        public void ShouldReturnAllBooksFromDbInDefaultView()
        {
            var books = new List<Book>()
            {
                new Book {
                    Id = 1,
                    Name = "Moby Dick",
                    Genre = "Fiction",
                    Price = 12.50m
                },
                new Book {
                    Id = 2,
                    Name = "War and Peace",
                    Genre = "Fiction",
                    Price = 17m
                },
            };

            
            _repository.Setup(r => r.GetAll())
                      .Returns(books);

            var result = _sut.Index();
            var model = result.Model as IEnumerable<Book>;

            Assert.Equal(model, books);
            Assert.Equal(2, model.Count<Book>());
        }

        [Fact]
        public void shouldReturnAllBooksByGenre()
        {
            var books = new List<Book>()
            {
                new Book {
                    Id = 1,
                    Name = "Moby Dick",
                    Genre = "Fiction",
                    Price = 12.50m
                },
                new Book {
                    Id = 2,
                    Name = "War and Peace",
                    Genre = "Fiction",
                    Price = 17m
                },
                new Book {
                    Id = 3,
                    Name = "Chemistry",
                    Genre = "Non-Fiction",
                    Price = 35m
                }
            };
            
            _repository.Setup(r => r.GetAll())
                       .Returns(books);

            var result = _sut.FindByGenre("Fiction");
            var model = result.Model as IEnumerable<Book>;

            Assert.Equal(2, model.Count<Book>());
            Assert.Equal("Moby Dick", model.ToList()[0].Name);
            Assert.Equal("War and Peace", model.ToList()[1].Name);

            
        }
    }
}
