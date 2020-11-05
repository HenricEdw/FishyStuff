using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyStuff
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var fishList = new List<Fish>
            {
                new Fish { Species=Species.Perch, Length = 55d, Weight = 1.2d },
                new Fish { Species=Species.Perch, Length = 60d, Weight = 2.3d },
                new Fish { Species=Species.Pike, Length = 105.00d, Weight = 6.00d },
                new Fish { Species=Species.Pike, Length = 130d, Weight = 10.00d },
                new Fish { Species=Species.Perch, Length = 43.00d, Weight = 0.700d },
                new Fish { Species=Species.Pike, Length = 85.00d, Weight = 3.00d },
                new Fish { Species=Species.Pike, Length = 110d, Weight = 11.00d },

            };

            //Sorterar helt enkelt listan i storlek baserat på längd (sportfiskare gillar längd bäst) först, sedan vikt.
            fishList = fishList.OrderByDescending(x => x.Length).ThenByDescending(x => x.Weight).GroupBy(x => x.Species).SelectMany(x => x).ToList();

            var biggestPike = fishList.FirstOrDefault(x => x.Species == Species.Pike);

            var biggestPerch = fishList.FirstOrDefault(x => x.Species == Species.Perch);

            Console.WriteLine($"Din största gädda är {biggestPike.Length}cm lång och väger {biggestPike.Weight}kg!");

            Console.WriteLine($"Din största abborre är {biggestPerch.Length}cm lång och väger {biggestPerch.Weight}kg!");

            Console.ReadLine();
        }
    }
}
