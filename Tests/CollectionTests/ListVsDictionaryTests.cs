using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Tests.CollectionTests;
using Tests.CollectionTests.Internal;

namespace Tests
{
    public class ListVsDictionaryTests
    {
        private const int ITERATIONS = 100;

        [Test]
        public void Add_is_similar_and_eratic_for_dictionary_and_list_across_small_or_large_datasets()
        {
            Console.WriteLine("Mostly similar, but occasionally both List or Dictionary will be faster, maybe due to GC or fecking windows updates?");

            var results = new List<TestResult>();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"running batch {i+1}");
                var tb = new ListVsDictionaryWithClassesTestBox();
                var tester = new TestBoxTester(tb, ITERATIONS, "DICT", "LIST", "Add", "Person", 100, 1000, 100_000, 500_000);
                var batch = tester.TestAvsB_SomeMethod_ReturnRatio();
                results.AddRange(batch);
            }

            int total = results.Count;
            Console.WriteLine();
            Console.WriteLine("Asserting that up to the 90th percentile are all similar");
            int cntSimilar = results.Count(r => r.Result == Result.Similar);
            bool areMostlySimilar = cntSimilar > (0.9 * total);
            Assert.IsTrue(areMostlySimilar);

            Console.WriteLine();
            Console.WriteLine("Observe that consistently when the list size is around 1000 elements, that List performance around 2 to 3 times faster than dictionary.");
            var result1000s = results.Where(r => r.CollectionSize == 1000);
            foreach (var r in result1000s)
            {
                Console.WriteLine(r);
            }

        }

    }
}

