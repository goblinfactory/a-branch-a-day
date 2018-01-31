using System;

namespace Tests.CollectionTests.Internal
{
    public class ThingStruct
    {
        public ThingStruct(int flag, float number, DateTime date)
        {
            Flag = flag;
            Number = number;
            Date = date;
        }
        public int Flag { get; }
        public float Number { get; }
        public DateTime Date { get; }
    }
}