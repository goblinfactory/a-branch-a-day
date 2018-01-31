using System;
using System.Threading;

namespace Tests.CollectionTests.Internal
{
    public enum Result
    {
        Faster,
        Similar,
        Slower
    }

    public abstract class TestBoxBase
    {
        public readonly Func<decimal, Result> Comparer;

        protected TestBoxBase() : this(_comparer) {}

        protected TestBoxBase(Func<decimal, Result> comparer)
        {
            Comparer = comparer;
        }

        /// <summary>
        /// override this comparer if needed.
        /// </summary>
        protected static Func<decimal, Result> _comparer = r => r > 0.5M && r < 2M ? Result.Similar : r < 0.5M ? Result.Faster : Result.Slower;

        protected abstract void LoadCollectionsWithTestData(int cntItems);
        public abstract void DoCommandA();
        public abstract void DoCommandB();
        protected abstract void ClearCollections();

        public void StartTest(int cntItems)
        {
            ClearCollections();
            LoadCollectionsWithTestData(cntItems);
        }
    }
}