using System;

namespace Tests.CollectionTests.Internal
{
    public class Person
    {
        public Person(string name, float number, DateTime dob)
        {
            Name = name;
            Number = number;
            DOB = dob;
        }
        public string Name { get; }
        public float Number { get; }
        public DateTime DOB { get; }

        public int Age => DateTime.Now.Year - DOB.Year;
    }
}