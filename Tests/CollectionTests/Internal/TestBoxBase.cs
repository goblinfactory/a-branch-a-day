using System;
using System.Threading;

namespace Tests.CollectionTests.Internal
{
    public abstract class TestBoxBase
    {
        public readonly Func<decimal, Result> Comparer;

        private const decimal MAX = 3M;
        private const decimal MIN = 1/MAX;

        protected TestBoxBase() : this(_comparer) {}

        protected TestBoxBase(Func<decimal, Result> comparer)
        {
            Comparer = comparer;
        }

        /// <summary>
        /// override this comparer if needed.
        /// </summary>
        protected static Func<decimal, Result> _comparer = r => r > MIN && r < MAX ? Result.Similar : r < MIN ? Result.Faster : Result.Slower;

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