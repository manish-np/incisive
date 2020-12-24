using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public int? Code { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string Capital { get; set; }
        public string Nationality { get; set; }
        public string Flag { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
    }
}
