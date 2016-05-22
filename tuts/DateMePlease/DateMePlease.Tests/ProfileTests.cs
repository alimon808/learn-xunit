using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class ProfileTests
    {
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            var sut = new Profile();

            Assert.IsType<int>(sut.Id);
        }

        [Fact]
        public void ShouldHaveLookingForAsString()
        {
            var sut = new Profile();

            Assert.Equal(null, sut.LookingFor);

            sut.LookingFor = "somebody";

            Assert.Equal("somebody", sut.LookingFor);
        }

        [Fact]
        public void ShouldHaveIntroductionAsString()
        {
            var sut = new Profile();

            Assert.Equal(null, sut.Introduction);

            sut.Introduction = "the best";

            Assert.Equal("the best", sut.Introduction);
        }

        [Fact]
        public void ShouldHavePitchAsString()
        {
            var sut = new Profile();

            Assert.Equal(null, sut.Pitch);

            sut.Pitch = "elevator";

            Assert.Equal("elevator", sut.Pitch);
        }

        [Fact]
        public void ShouldHaveMemberAsMember()
        {
            var sut = new Profile();

            Assert.Equal(null, sut.Member);

            sut.Member = new Member();
            Assert.IsType<Member>(sut.Member);
        }

        [Fact]
        public void ShouldHaveDemographicsAsDemographics()
        {
            var sut = new Profile();

            Assert.Equal(null, sut.Demographics);

            sut.Demographics = new Demographics();
            Assert.IsType<Demographics>(sut.Demographics);
        }


        [Fact]
        public void ShouldHaveInterestsAsCollection()
        {
            var sut = new Profile();

            Assert.Equal(null, sut.Interests);
            sut.Interests = new[] { new Interest(), new Interest() };

            Assert.Equal(2, sut.Interests.Count);
        }
    }
}
