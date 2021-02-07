using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5.task2
{
    public class Country
    {
        public string CountryV { get; set; }
        public int DistrictId { get; set; }

        public Country()
        {
        }

        public Country(string countryV, int districtId)
        {
            CountryV = countryV;

            DistrictId = districtId;
        }

        public override string ToString()
        {
            return $"County: {CountryV}, \tDistrictID: {DistrictId}";
        }
    }
}
