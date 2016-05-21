using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class MemberTests
    {
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            var sut = new Member();

            Assert.IsType<int>(sut.Id);
        }

        [Fact]
        public void ShouldHaveUsernameAsString()
        {
            var sut = new Member();

            Assert.Equal(null, sut.Username);

            sut.Username = "jsmith";

            Assert.IsType<string>(sut.Username);
        }

        [Fact]
        public void ShouldHaveLastLoginAsDateTime()
        {
            var sut = new Member();

            Assert.IsType<DateTime>(sut.LastLogin);
        }


        [Fact]
        public void ShouldHaveCreatedAsDateTime()
        {
            var sut = new Member();

            Assert.IsType<DateTime>(sut.Created);
        }

        [Fact]
        public void ShouldHaveProfileAsProfile()
        {
            var sut = new Member();

            Assert.Equal(null, sut.Profile);

            sut.Profile = new Profile();

            Assert.IsType<Profile>(sut.Profile);
        }
    }
}
