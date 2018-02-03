using System;
using System.Collections.Generic;
using Tests.CollectionTests.Internal;

namespace Tests.CollectionTests
{

    public class ListVsDictionaryWithClassesTestBox : TestBoxBase
    {
        private int _itemsLoaded;

        private List<Person> _list = new List<Person>();
        private Dictionary<int, Person> _dict = new Dictionary<int, Person>();

        private static readonly Person TestPerson = new Person("foo", 1.234F, new DateTime(2000, 1, 1));

        protected override void LoadCollectionsWithTestData(int items)
        {
            _itemsLoaded = items;
            var d = new DateTime(2000, 1, 1);
            // load
            for (int i = 0; i < items; i++)
            {
                var t = new Person("text", i * 0.01F, d);
                _list.Add(t);
                _dict.Add(i, t);
            }
        }

        protected override void ClearCollections()
        {
            _list.Clear();
            _dict.Clear();
        }


        public override void DoCommandA()
        {
            _list.Add(TestPerson);
        }

        private static int _id;

        public override void DoCommandB()
        {
            _dict.Add(++_id + _itemsLoaded, TestPerson);    
        }
    }
}