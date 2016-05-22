using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class PhotoTests
    {
        private Photo _sut;

        public PhotoTests()
        {
            _sut = new Photo();
        }
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            Assert.IsType<int>(_sut.Id);
        }

        [Fact]
        public void ShouldHaveUrlAsString()
        {
            Assert.Equal(null, _sut.Url);
            _sut.Url = "http://www.example.com/img/1.jpg";

            Assert.Equal("http://www.example.com/img/1.jpg", _sut.Url);

            //todo test if valid url
        }

        [Fact]
        public void ShouldHaveDescriptionAsString()
        {
            Assert.Equal(null, _sut.Description);
            _sut.Description = "profile";

            Assert.Equal("profile", _sut.Description);

        }

        [Fact]
        public void ShouldHaveDateAddedAsDateTime()
        {
            Assert.IsType<DateTime>(_sut.DateAdded);
        }

        [Fact]
        public void ShouldHaveIsMainAsBoolean()
        {
            Assert.IsType<bool>(_sut.IsMain);
            Assert.Equal(false, _sut.IsMain);
        }
    }
}
