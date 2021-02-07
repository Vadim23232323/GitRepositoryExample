using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5.task2
{
    public  class Neighborhood
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int Id { get; set; }


        public Neighborhood(string streetName, int houseNumber, int neighborhoodId)
        {
            StreetName = streetName;

            HouseNumber = houseNumber;

            Id = neighborhoodId;
        }

        public override string ToString()
        {
            return $"StreetName: {StreetName}, \tHouseNumber: {HouseNumber}, \tId: {Id}";
        }
    }
}
