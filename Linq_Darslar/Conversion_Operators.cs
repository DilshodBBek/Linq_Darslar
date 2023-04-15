using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Darslar
{
    internal class Conversion_Operators
    {
        public static void Start()
        {
            //ToArray();
            //ToList();
            //ToDictionay();
        }

        public static void ToArray()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] array = numbers.ToArray();

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static void ToList() 
        {
            List<string> fruits = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
            List<string> shortFruits = fruits.Where(f => f.Length <= 5).ToList();

            shortFruits.ForEach(f => Console.WriteLine(f));
        }

        public static void ToDictionay()
        {
            string[] countries = { "France", "Germany", "Italy", "Spain" };
            Dictionary<string, int> countryLengths = countries.ToDictionary(c => c, c => c.Length);

            foreach (KeyValuePair<string, int> kvp in countryLengths)
            {
                Console.WriteLine("Country: {0}, Length: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
