using System;
using System.Collections.Generic;
using System.Text;
using HW_5.task2;

namespace HW_5.task2
{
    public static class DistrictRepository
    {
        public static IEnumerable<District> GetDistricts()
        {
            var districts = new List<District>();

            districts.Add(new District("Minskiy", 1,1));
            districts.Add(new District("Kievskiy", 2,2));
            districts.Add(new District("Mosсowskiy", 3,3));

            return districts;
        }
    }
}
