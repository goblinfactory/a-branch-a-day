using System;

namespace Tests.CollectionTests.Internal
{
    public class ThingClass
    {
        public ThingClass(string text, float number, DateTime date)
        {
            Text = text;
            Number = number;
            Date = date;
        }
        public string Text { get; }
        public float Number { get; }
        public DateTime Date { get; }
    }
}