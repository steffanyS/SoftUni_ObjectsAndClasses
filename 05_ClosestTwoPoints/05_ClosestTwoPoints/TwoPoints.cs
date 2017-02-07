using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ClosestTwoPoints
{
    class TwoPoints
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points=new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                var newPoint = new Point
                {
                    x = input[0],
                    y = input[1]
                };
                points.Add(newPoint);
            }

            var closestPointDistance = double.MaxValue;
            Point firstMinDistPoint=new Point();
            Point secondMinDistPoint = new Point();

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    if (CalcDistance(points[i], points[j]) < closestPointDistance)
                    {
                        closestPointDistance = CalcDistance(points[i], points[j]);
                        firstMinDistPoint = points[i];
                        secondMinDistPoint = points[j];
                    }
                }
            }

            Console.WriteLine("{0:f3}",closestPointDistance);
            Console.WriteLine("({0}, {1})",firstMinDistPoint.x,firstMinDistPoint.y);
            Console.WriteLine("({0}, {1})", secondMinDistPoint.x,secondMinDistPoint.y);
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }
    }
}
