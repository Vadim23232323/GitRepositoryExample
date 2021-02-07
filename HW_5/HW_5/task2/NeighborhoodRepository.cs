using System;
using System.Collections.Generic;
using System.Text;

namespace HW_5.task2
{
    public static class NeighborhoodRepository
    {
        public static IEnumerable<Neighborhood> GetNeighborhoods()
        {
            var Neighborhoods = new List<Neighborhood>();

            Neighborhoods.Add(new Neighborhood("Lenina", 118, 1));
            Neighborhoods.Add(new Neighborhood("Gagarina", 47, 2));
            Neighborhoods.Add(new Neighborhood("lenina", 13, 3));

            return Neighborhoods;
        }
    }
}
