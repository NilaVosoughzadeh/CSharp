using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var ratings = new List<int>()
            {
                52,
                30,
                46,
                80,
                85,
                3
            };

            var ratings1 = ratings.Where(r => r > 50);
            var ratings2 = ratings.Where(GetRatingsOver50);
            var ratings3 = ratings.Where(delegate (int rating) { return rating > 50; });

            foreach (var rating in ratings1)
            {
                Console.WriteLine(rating);
            }

            Console.WriteLine("---------------------------------------------");

            foreach (var rating in ratings2)
            {
                Console.WriteLine(rating);
            }

            Console.WriteLine("---------------------------------------------");

            foreach (var rating in ratings3)
            {
                Console.WriteLine(rating);
            }


            Console.ReadLine();

        }

        private static bool GetRatingsOver50(int rate)
        {
            return rate > 50;
        }

    }
}
