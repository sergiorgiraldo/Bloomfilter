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
                (element, iteration, keySize) => (element * iteration) % keySize;
            Filter(1975, 2, 64, fn);
            Filter(1985, 2, 64, fn);
            Filter(1995, 2, 64, fn);
            Filter(2005, 2, 64, fn);
            Filter(2015, 2, 64, fn);
            //Filter(1998, 3, 32, fn);

            //all = all.Distinct().ToList();
            //all.Sort();
            //foreach (var i in all)
            //{
            //    Console.WriteLine(i);
            //}

            //Filter(3200, 3, 32, fn);

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
