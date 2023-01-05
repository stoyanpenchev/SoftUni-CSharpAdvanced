using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var plates = new HashSet<string>();
            while (true)
            {
                string[] comands = Console.ReadLine().Split(", ");
                string action = comands[0];
                if (action == "END")
                {
                    break;
                }
                string thePlate = comands[1];
                if (action == "IN")
                {
                    plates.Add(thePlate);
                }
                else
                {
                    if (plates.Contains(thePlate))
                    {
                        plates.Remove(thePlate);
                    }
                }
            }
            if (plates.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, plates));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
