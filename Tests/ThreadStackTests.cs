using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    // http://www.albahari.com/threading/

    public class ThreadStackTests
    {
        private const int KB = 1024;
        private const int MB = KB * KB;

        [TestCase(2 * MB, 2 * KB, false)]
        //[TestCase(200,250, false)]
        //[TestCase(250,250, false)]
        [Test]
        public void Foo(int useKb, int maxKb, bool expectException)
        {
            // can I track the amount of stack memory that a thread can use?
            // "memory" is an overloaded term...
            // so lets see exactly what we can acomplish.
            int useSize = useKb * KB;
            int maxSize = maxKb * KB;

            var t = new Thread(() =>
            {
                throw new Exception("foo");
                var i = new int[useSize];
                for (int j = 0; j < useSize; j++) i[j] = j;
                Console.WriteLine(i.Max());
            }, maxSize);

            t.Start();
            t.Join(500);
        }
    }
}
