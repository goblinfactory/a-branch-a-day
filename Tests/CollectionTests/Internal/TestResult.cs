using System.Security.Cryptography.X509Certificates;

namespace Tests.CollectionTests.Internal
{
    public struct TestResult
    {
        public TestResult(int collectionSize, decimal ratioAB, Result result)
        {
            CollectionSize = collectionSize;
            Result = result;
            RatioAB = ratioAB;
        }

        public int CollectionSize { get; }
        public decimal RatioAB { get; }
        public Result Result { get; }
        public override string ToString()
        {
            return string.Format($" {CollectionSize}, {Result}, {RatioAB,-10:0.00}");
        }
    }
}