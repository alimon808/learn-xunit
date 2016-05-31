using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TDD.Controllers;
using Xunit;

namespace TDD.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void ShouldReturnDefaultView()
        {
            var sut = new HomeController();

            ViewResult result = sut.Index() as ViewResult;

            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldReturnContactView()
        {
            var sut = new HomeController();

            ViewResult result = sut.Contact() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("Your contact page.", result.ViewBag.Message);
        }

        [Fact]
        public void ShouldReturnAboutView()
        {
            var sut = new HomeController();

            ViewResult result = sut.About() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("Your about page.", result.ViewBag.Message);
        }

    }
}
