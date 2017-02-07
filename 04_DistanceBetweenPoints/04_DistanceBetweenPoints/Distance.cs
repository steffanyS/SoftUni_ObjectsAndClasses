using System;
using System.Linq;

namespace _04_DistanceBetweenPoints
{
    class Distance
    {
        static void Main(string[] args)
        {
            Point firstPoint=new Point();
            Point secondPoint = new Point();

            var firstPointData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            firstPoint.x = firstPointData[0];
            firstPoint.y = firstPointData[1];

            var secondPointData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            secondPoint.x = secondPointData[0];
            secondPoint.y = secondPointData[1];

            Console.WriteLine("{0:f3}",CalcDistance(firstPoint, secondPoint));
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }
    }
}
