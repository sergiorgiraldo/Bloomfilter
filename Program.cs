using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloomFilter
{
    class Program
    {
        private static List<int> all = new List<int>();
    
        static void Main(string[] args)
        {
            Func<int, int, int, double> fn =
                (element, iteration, keySize) => ((Math.Pow(element, 2) + Math.Pow(element, 3)) * iteration) % keySize;
            Filter(2010, 3, 32, fn);
            Filter(2013, 3, 32, fn);
            Filter(2007, 3, 32, fn);
            Filter(2004, 3, 32, fn);
            //Filter(2001, 3, 32, fn);
            //Filter(1998, 3, 32, fn);

            all = all.Distinct().ToList();
            all.Sort();
            foreach (var i in all)
            {
                Console.WriteLine(i);
            }

            Filter(3200, 3, 32, fn);

            Console.ReadLine();
        }

        static void Filter(int element, int iterations, int keySize, Func<int, int, int, double> fn)
        {
            Console.WriteLine("\n" + element);
            for (var i = 1; i <= iterations; i++)
            {
                var res = fn(element, i, keySize);
                all.Add((int)res);
                Console.WriteLine("\t" + res);
            }
        }
    }
}
