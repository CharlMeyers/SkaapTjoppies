using CompanyCup.models;
using System;

namespace CompanyCup.helpers
{
    public static class distanceCalculator
    {
        public static double calculateDistance(Dimension point1, Dimension point2)
        {
            return Math.Sqrt(cartesianValue(point1.x, point2.x) + cartesianValue(point1.y, point2.y) + cartesianValue(point1.z, point2.z));
        }


        private static double cartesianValue(int point1, int point2)
        {
            return Math.Pow(Math.Abs(point1 - point2), 2);
        }
    }
}
