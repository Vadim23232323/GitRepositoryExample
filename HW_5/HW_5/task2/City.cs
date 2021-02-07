using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5.task2
{
    public class City
    {
        public string Cityv { get; set; }
        public int NeighborhoodId { get; set; }
        public int Id { get; set; }


        public City(string cityv, int neighborhoodId, int cityId)
        {
            Cityv = cityv;

            NeighborhoodId = neighborhoodId;

            Id = cityId;
        }

        public override string ToString()
        {
            return $"City: {Cityv}, \tNeighborhoodID: {NeighborhoodId}, \tId: {Id}";
        }
    }
}
