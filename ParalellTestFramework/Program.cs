using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParalellTestFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Application");
            var numbers = new List<int>();

            for (var i = 0; i < 1000000; i++)
            {
                var randomGenerator = new Random(10000000);
                numbers.Add(randomGenerator.Next());
            }

            var stopWatch = new Stopwatch();

            stopWatch.Start();


            //Parallel.ForEach(numbers, (number) =>
            //{
            //    Console.WriteLine($"Number: {number}");
            //});

            foreach (var number in numbers)
            {
                Console.WriteLine($"Number: {number}");
            }

            stopWatch.Stop();


            Console.WriteLine("Run = " + stopWatch.ElapsedMilliseconds);

            Console.WriteLine("End Application");
            Console.ReadLine();

        }
    }
}
