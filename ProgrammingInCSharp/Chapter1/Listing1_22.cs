using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_22 : IExecuter
    {
        public void Execute(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            //runs sequential
            var numbers1 = Enumerable.Range(0, 100000000);
            sw.Start();
            var parallelResult1 = numbers1
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("#1 (sequential) - Elapsed time: {0}", sw.Elapsed);

            //this might run sequentiallys
            //from the book: "The runtime determines whether it makes sense to turn your query into a parallel one."
            var numbers2 = Enumerable.Range(0, 100000000);
            sw.Restart();
            var parallelResult2 = numbers2.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("#2 (maybe parallel) - Elapsed time: {0}", sw.Elapsed);

            //runs parallel
            var numbers3 = Enumerable.Range(0, 100000000);
            sw.Restart();
            var parallelResult3 = numbers3.AsParallel()
                .WithExecutionMode(executionMode: ParallelExecutionMode.ForceParallelism)
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("#3 (parallel) - Elapsed time: {0}", sw.Elapsed);

            //runs parallel with x threads (x has to be 0 < x < 64)
            int x = 23;
            var numbers4 = Enumerable.Range(0, 100000000);
            sw.Restart();
            var parallelResult4 = numbers4.AsParallel()
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                .WithDegreeOfParallelism(23)
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("#4 (parallel {0} threads)- Elapsed time: {1}", x, sw.Elapsed);
            sw.Stop();
        }
    }
}
