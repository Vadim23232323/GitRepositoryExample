using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5.task2
{
    public static class CountryRepository
    {
        public static IEnumerable<Country> GetCountrys()
        {
            var countrys = new List<Country>();

            countrys.Add(new Country("Belarus", 1));
            countrys.Add(new Country("Ukraine", 2));
            countrys.Add(new Country("Russia", 3));

            return countrys;
        }
    }
}
