using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Tests.CollectionTests;
using Tests.CollectionTests.Internal;

namespace Tests
{
    public class ListVsDictionaryTests
    {
        private const int ITERATIONS = 100;

        [Test]
        public void TestDictionaryVsList_Add_CollectionsOfClasses()
        {
            var tb = new ListVsDictionaryWithClassesTestBox();
            var tester = new TestBoxTester(tb, ITERATIONS, "DICT", "LIST", "Add", "ClassThing", 100, 1000, 100_000, 1000_000, 3000_000);
            tester.TestAvsB_SomeMethod_ReturnRatio();
        }

        [Test]
        public void TestDictionaryVsList_Add_CollectionOfStructs()
        {
            var tb = new ListVsDictionaryWithStructsTestBox();
            var tester = new TestBoxTester(tb, ITERATIONS, "DICT", "LIST", "Add", "StructThing", 100, 1000, 100_000, 1000_000, 3000_000);
            tester.TestAvsB_SomeMethod_ReturnRatio();
        }

    }
}
