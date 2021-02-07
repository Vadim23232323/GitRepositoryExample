using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW_5.task2;

namespace HW_5.task2
{
    public static class JoinClause
    {
        public static void ShowJoinWithQuerySyntax()
        {
            var countrys = CountryRepository.GetCountrys();
            var districts = DistrictRepository.GetDistricts();
            var citys = CityRepository.GetCitys();
            var neighborhoods = NeighborhoodRepository.GetNeighborhoods();

            var joinResult = from country in countrys
                join district in districts
                    on country.DistrictId equals district.Id
                join city in citys
                    on district.CityId equals city.Id
                join neighborhood in neighborhoods
                    on city.NeighborhoodId equals neighborhood.Id
                select new
                    {
                country.CountryV,
                country.DistrictId,
                neighborhood.StreetName,
                neighborhood.HouseNumber,
                Districtid = district.Id
                    };

            Console.WriteLine("collection of all street names that are found in the collection of countries:");

            foreach (var item in joinResult)
            {
                Console.WriteLine($"Country:{item.CountryV}, StreetName: {item.StreetName}, HouseNumber: {item.HouseNumber}, ID: {item.DistrictId}");
            }
        }

    }
}
