using System;
using System.Linq;

namespace _06_RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var firstRectInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondRectInfo= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle firstRectngle = new Rectangle
            {
                Height = firstRectInfo[0],
                Left = firstRectInfo[1],
                Top = firstRectInfo[2],
                Width = firstRectInfo[3]
            };

            Rectangle secondRectangle = new Rectangle
            {
                Height = secondRectInfo[0],
                Left = secondRectInfo[1],
                Top = secondRectInfo[2],
                Width = secondRectInfo[3]
            };

            if (firstRectngle.IsInside(secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else if (secondRectangle.IsInside(firstRectngle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

      
    }
}
