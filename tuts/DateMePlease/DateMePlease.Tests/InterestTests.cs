using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class InterestTests
    {
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            var sut = new Interest();

            Assert.IsType<int>(sut.Id);
        }
        
        [Fact]
        public void ShouldHaveIntestTypeAsInterestType()
        {
            var sut = new Interest();

            Assert.Equal(null, sut.InterestType);
            sut.InterestType = new InterestType();

            Assert.IsType<InterestType>(sut.InterestType);
        }
    }
}
