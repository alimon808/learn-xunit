using System.Collections.Generic;
using System.Linq;
using Moq;
using TDD.Controllers;
using TDD.Models;
using TDD.Repository;
using Xunit;

namespace TDD.Tests.Controllers
{
    // when the movie controller index action executes
    // - it should render the default view
    // - it should pass a list of movies to the view
    public class MovieControllerTests
    {
        [Fact]
        public void ShouldRenderDefaultView()
        {
            var repository = new Mock<IMovieRepository>();
            var sut = new MovieController(repository.Object);

            var result = sut.Index();

            Assert.Equal("", result.ViewName);
        }

        [Fact]
        public void ShouldModelListOfMovies()
        {
            var movies = new List<Movie>()
            {
                new Movie { Title = "foo" },
                new Movie { Title = "bar" }
            }.AsQueryable();

            var repository = new Mock<IMovieRepository>();
            var sut = new MovieController(repository.Object);
            repository.Setup(r => r.FindAll())
                      .Returns(movies); 

            var result = sut.Index();
            var model = result.ViewData.Model as IEnumerable<Movie>;

            Assert.Equal(model, movies);
        }
    }
}
