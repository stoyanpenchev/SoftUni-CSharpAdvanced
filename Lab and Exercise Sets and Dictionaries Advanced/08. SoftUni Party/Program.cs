using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vipBadjes = new HashSet<string>();
            var badjes = new HashSet<string>();
            bool isIt = false;
            while (true)
            {
                string badge = Console.ReadLine();
                if (badge == "END")
                {
                    break;
                }
                if (badge == "PARTY")
                {
                    while (true)
                    {
                        string arrivedBadges = Console.ReadLine();
                        if (arrivedBadges == "END")
                        {
                            isIt = true;
                            break;

                        }
                        if (vipBadjes.Contains(arrivedBadges))
                        {
                            vipBadjes.Remove(arrivedBadges);
                        }
                        else if (badjes.Contains(arrivedBadges))
                        {
                            badjes.Remove(arrivedBadges);
                        }
                    }
                    if (isIt)
                    {
                        break;
                    }
                }
                if (char.IsDigit(badge[0]) && badge.Length == 8)
                {
                    vipBadjes.Add(badge);
                }
                else if(badge.Length == 8)
                {
                    badjes.Add(badge);
                }
            }
            int redGuests = vipBadjes.Count + badjes.Count;
            Console.WriteLine($"{redGuests}");
            if (vipBadjes.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, vipBadjes));
            }
            if (badjes.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, badjes));
            }
        }
    }
}
