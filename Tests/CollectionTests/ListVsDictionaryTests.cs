using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    public class ListVsDictionaryTests
    {
        private const int ITERATIONS = 100;
        private const decimal ITSY_BIT = 0.0000000001M;

        [Test]
        public void TestDictionaryVsList_Add_ReturnRatio()
        {
            Console.WriteLine("Testing .Add() on large collections of classes.");
            Console.WriteLine("");
            Console.WriteLine("coll size | LIST     | DICT     | L/D     | D/L       ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("small collections");
            var r1 = TestDictionaryVsList_Add_ReturnRatio(100);
            var r2 = TestDictionaryVsList_Add_ReturnRatio(1000);
            Console.WriteLine();
            Console.WriteLine("large collections");
            var r3 = TestDictionaryVsList_Add_ReturnRatio(100000);
            var r4 = TestDictionaryVsList_Add_ReturnRatio(1000000);
            Console.WriteLine();

            Assert.IsTrue(r1 < 1);
            Assert.IsTrue(r2 < 1);
            Assert.IsTrue(r3 > 1);
            Assert.IsTrue(r4 > 1);

            Console.WriteLine("small collections dictionary is faster");
            Console.WriteLine("large collections List is faster");
            Console.WriteLine($"Units are ticks per {ITERATIONS} invocations.");
        }

        public decimal TestDictionaryVsList_Add_ReturnRatio(int items)
        {
            var list = new List<ThingClass>();
            var dict = new Dictionary<int,ThingClass>();
            var d = new DateTime(2000,1,1);
            // load
            for (int i = 0; i < items; i++)
            {
                var t = new ThingClass("text", i * 0.01F, d);
                list.Add(t);
                dict.Add(i, t);
            }
            
            var swList = new Stopwatch();
            swList.Start();
            for (int i = 0; i < ITERATIONS; i++)
            {
                list.Add(TestThingClass);
            }
            swList.Stop();

            var swDictionary = new Stopwatch();
            swDictionary.Start();
            for (int i = 0; i < ITERATIONS; i++)
            {
                dict.Add(items + i, TestThingClass);
            }
            swDictionary.Stop();
            PrintDifference(swList, swDictionary, items);
            return (decimal)swDictionary.ElapsedTicks / (decimal)swList.ElapsedTicks;
        }

        public static ThingClass TestThingClass = new ThingClass("foo", 1.234F, new DateTime(2000,1,1));

        private void PrintDifference(Stopwatch sw1, Stopwatch sw2, long items)
        {
            decimal t1 = (decimal) sw1.ElapsedTicks + ITSY_BIT;
            var t2 = (decimal) sw2.ElapsedTicks + ITSY_BIT;
            Console.WriteLine($"{items,-10}|{t1,-10:0.00}|{t2,-10:0.00}|{t1 / t2,-10:0.00}|{t2 / t1, -10:0.00}");
        }
    }



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
