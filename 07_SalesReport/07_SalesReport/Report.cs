using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_SalesReport
{
    class Report
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            List<Sale> sales=new List<Sale>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var currentSale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };

                sales.Add(currentSale);
            }

            var result=new SortedDictionary<string,decimal>();

            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }

                result[sale.Town] += sale.Price*sale.Quantity;
            }

            foreach (var town in result)
            {
                Console.WriteLine("{0} -> {1:f2}",town.Key,town.Value);
            }
            {
                
            }
        }
    }
}
