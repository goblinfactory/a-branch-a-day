using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
/// <summary
/// 
/// ConcurrentDictionary Is Not Always Thread-Safe
/// </summary>
/// <quoteFromBlog>
/// ConcurrentDictionary is a thread-safe dictionary implementation but surprisingly (at least to me) not all of its members can be safely used by multiple threads concurrently. <a href="http://blog.i3arnon.com/2018/01/16/concurrent-dictionary-tolist/">blog</a>
/// </quoteFromBlog>
class ConcurrentDictionaryTests
    {
        internal enum WhichMethod { ToArray, ToList }

        [Test]
        public void ToArray_is_threadsafe()
        {
            Do_the_test(WhichMethod.ToArray);
        }

        [Test]
        public void ToList_is_not_threadsafe()
        {
            Do_the_test(WhichMethod.ToList);
        }

        public void Do_the_test(WhichMethod method)
        {
            int i = 0;
            var cd = new ConcurrentDictionary<int, int>();
            var b = new Barrier(2);

            try
            {
                Task.Run(() =>
                {
                    b.SignalAndWait();
                    for (int x = 0; x < 100000; x++)
                    {
                        cd[x] = 10;
                    }
                });

                b.SignalAndWait();

                for (i = 0; i < 6000; i++)
                {
                    if (method == WhichMethod.ToArray) cd.ToArray(); else cd.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"exception thrown when i = {i}");
                throw;
            }
            
        }
    }
}
