using System;

namespace DateMePlease.Entities
{
    public class Demographics
    {
        public int Id { get; set; }

        public string AddressLine { get; set; }
        public string CityTown { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public DateTime Birthdate { get; set; }
    }
}