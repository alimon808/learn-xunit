using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class MemberTests
    {
        private Member _sut;

        public MemberTests()
        {
            _sut = new Member();
        }
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            Assert.IsType<int>(_sut.Id);
        }

        [Fact]
        public void ShouldHaveUsernameAsString()
        {
            Assert.Equal(null, _sut.Username);

            _sut.Username = "jsmith";

            Assert.IsType<string>(_sut.Username);
        }

        [Fact]
        public void ShouldHaveMemberNameAsString()
        {
            Assert.Equal(null, _sut.MemberName);

            _sut.MemberName = "jsmith";

            Assert.IsType<string>(_sut.MemberName);
        }
        [Fact]
        public void ShouldHaveLastLoginAsDateTime()
        {
            Assert.IsType<DateTime>(_sut.LastLogin);
        }


        [Fact]
        public void ShouldHaveCreatedAsDateTime()
        {
            Assert.IsType<DateTime>(_sut.Created);
        }

        [Fact]
        public void ShouldHaveProfileAsProfile()
        {
            Assert.Equal(null, _sut.Profile);

            _sut.Profile = new Profile();

            Assert.IsType<Profile>(_sut.Profile);
        }

        [Fact]
        public void ShouldHaveMessagesAsCollection()
        {
            Assert.Equal(null, _sut.Messages);

            _sut.Messages = new[] { new Message(), new Message() };

            Assert.Equal(2, _sut.Messages.Count);
        }

        [Fact]
        public void ShouldHaveFavoritesAsCollection()
        {
            Assert.Equal(null, _sut.Favorites);
        }
    }
}
