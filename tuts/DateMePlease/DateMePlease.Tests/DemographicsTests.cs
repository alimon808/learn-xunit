using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class DemographicsTests
    {
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            var sut = new Demographics();

            Assert.IsType<int>(sut.Id);
        }

        [Fact]
        public void ShouldHaveAddressLineAsString()
        {
            var sut = new Demographics();

            Assert.Equal(null, sut.AddressLine);

            sut.AddressLine = "123 Main St";

            Assert.Equal("123 Main St", sut.AddressLine);
        }

        [Fact]
        public void ShouldHaveCityTownAsString()
        {
            var sut = new Demographics();

            Assert.Equal(null, sut.CityTown);

            sut.CityTown = "york";

            Assert.Equal("york", sut.CityTown);
        }

        [Fact]
        public void ShouldHaveStateProvinceAsString()
        {
            var sut = new Demographics();

            Assert.Equal(null, sut.StateProvince);

            sut.StateProvince = "IL";

            Assert.Equal("IL", sut.StateProvince);
        }


        [Fact]
        public void ShouldHaveCountryAsString()
        {
            var sut = new Demographics();

            Assert.Equal(null, sut.Country);

            sut.Country = "USA";

            Assert.Equal("USA", sut.Country);
        }

        [Fact]
        public void ShouldHaveBirthdateAsDateTime()
        {
            var sut = new Demographics();
            Assert.IsType<DateTime>(sut.Birthdate);
        }
    }
}
