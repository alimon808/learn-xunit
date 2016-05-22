using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class InterestTypeTests
    {
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            var sut = new InterestType();

            Assert.IsType<int>(sut.Id);
        }
        
        [Fact]
        public void ShouldHaveNameAsString()
        {
            var sut = new InterestType();

            Assert.Equal(null, sut.Name);
            sut.Name = "volleyball";

            Assert.Equal("volleyball", sut.Name);
        }

        [Fact]
        public void ShouldHaveDescriptionAsString()
        {
            var sut = new InterestType();

            Assert.Equal(null, sut.Name);
            sut.Name = "US men volleyball";

            Assert.Equal("US men volleyball", sut.Name);
        }
    }
}
