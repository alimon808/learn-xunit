using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class FavoriteTests
    {
        private Favorite _sut;

        public FavoriteTests()
        {
            _sut = new Favorite();
        }

        [Fact]
        public void ShouldHaveIdAsInt()
        {
            Assert.IsType<int>(_sut.Id);
        }

        [Fact]
        public void ShouldHaveMemberIdAsInt()
        {
            Assert.IsType<int>(_sut.MemberId);
            Assert.Equal(0, _sut.MemberId);
        }

        [Fact]
        public void ShouldHaveDateFavoritedAsDateTime()
        {
            Assert.IsType<DateTime>(_sut.Favorited);
        }
        
    }
}
