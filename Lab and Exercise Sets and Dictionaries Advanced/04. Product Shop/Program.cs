using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] comands = Console.ReadLine().Split(", ");
                string shopName = comands[0];
                if(shopName == "Revision")
                {
                    break;
                }
                string product = comands[1];
                double price = double.Parse(comands[2]);
                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                    shops[shopName][product] = price;
                }
                else
                {
                    shops[shopName].Add(product, price);
                }
            }
            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
