using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5.task2
{
    public static class CityRepository
    {
        public static IEnumerable<City> GetCitys()
        {
            var citys = new List<City>();

            citys.Add(new City("Minsk", 1, 1));
            citys.Add(new City("Kiev", 2, 2));
            citys.Add(new City("Moscow", 3, 3));

            return citys;
        }
    }
}
