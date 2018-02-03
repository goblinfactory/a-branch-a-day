using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.CollectionTests.Internal
{
    public class TestBoxTester
    {
        private const decimal ITSY_BIT = 0.0000000001M;

        private readonly TestBoxBase _testbox;
        private readonly int _iterations;
        private readonly string A;
        private readonly string B;
        private readonly string someMethod;
        private readonly string collectionof;
        private int[] _collectionSizes;

        public TestBoxTester(TestBoxBase testbox, int iterations, string someMethod, string collectionof, params int[] collectionSizes)
        {
            _testbox = testbox;
            _iterations = iterations;
            this.A = testbox.CollectionATypeis;
            this.B = testbox.CollectionBTypeis;
            this.someMethod = someMethod;
            this.collectionof = collectionof;
            _collectionSizes = collectionSizes;
        }

        public TestResult[]  TestAvsB_SomeMethod_ReturnRatio()
        {
            Console.WriteLine($"Units are ticks per {_iterations} invocations.");
            Console.WriteLine($"Testing {A}.{someMethod}() vs {B}.{someMethod}() on small and large collections of {collectionof}.");
            Console.WriteLine("");
            Console.WriteLine($"coll size |{A,-10}|{B,-10}| {A[0]}/{B[0]}     | {B[0]}/{A[0]}      | {A}.{someMethod}() is");
            Console.WriteLine("----------------------------------------------------------------");

            // warm up the system and throw away this first test result
            var r0 = TestAvsB_Action_ReturnRatio(_testbox, _collectionSizes[0], _iterations, false);

            var results = new List<TestResult>();
            foreach (var size in _collectionSizes)
            {
                var ratio = TestAvsB_Action_ReturnRatio(_testbox, size, _iterations);
                results.Add(ratio);
            }
            return results.ToArray();
        }

        private TestResult TestAvsB_Action_ReturnRatio(TestBoxBase tb, int items, int iterations, bool print = true)
        {
            tb.StartTest(items);
            var stopwatchA = TimeHowLongXIterationsTake(tb, iterations, b => b.DoCommandA());
            var stopwatchB = TimeHowLongXIterationsTake(tb, iterations, b => b.DoCommandB());

            decimal t1 = (decimal)stopwatchA.ElapsedTicks + ITSY_BIT;
            var t2 = (decimal)stopwatchB.ElapsedTicks + ITSY_BIT;
            var ratioAB = t1 / t2;
            var result = _testbox.Comparer(ratioAB);

            if (print) PrintDifference(result,t1, t2, items);
            return new TestResult(items, ratioAB, result);
        }

        private Stopwatch TimeHowLongXIterationsTake(TestBoxBase tb, int iterations, Action<TestBoxBase> action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < iterations; i++)
            {
                action(tb);
            }
            stopwatch.Stop();
            return stopwatch;
        }

        private void PrintDifference(Result result, decimal t1, decimal t2, long items)
        {
            Console.WriteLine($"{items,-10}|{t1,-10:0.00}|{t2,-10:0.00}|{t1 / t2,-10:0.00}|{t2 / t1,-10:0.00}|{result}");
        }


    }
}
