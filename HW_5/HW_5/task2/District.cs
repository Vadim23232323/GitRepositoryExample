using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5.task2
{
    public class District
    {
        public string DistrictV { get; set; }
        public int CityId { get; set; }
        public int Id { get; set; }

        public District(string districtV, int cityId, int districtId)
        {
            DistrictV = districtV;

            CityId = cityId;

            Id = districtId;

        }

        public override string ToString()
        {
            return $"District: {DistrictV}, \tCityID: {CityId}, , \tID: {Id}";
        }
    }
}
