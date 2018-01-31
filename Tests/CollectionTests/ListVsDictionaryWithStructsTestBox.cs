using System;
using System.Collections.Generic;
using Tests.CollectionTests.Internal;

namespace Tests.CollectionTests
{

    public class ListVsDictionaryWithStructsTestBox : TestBoxBase
    {
        private int _itemsLoaded;

        private List<ThingStruct> _list = new List<ThingStruct>();
        private Dictionary<int, ThingStruct> _dict = new Dictionary<int, ThingStruct>();

        private static readonly ThingStruct TestThing = new ThingStruct(12, 1.234F, new DateTime(2000, 1, 1));

        protected override void LoadCollectionsWithTestData(int items)
        {
            _itemsLoaded = items;
            var d = new DateTime(2000, 1, 1);
            // load
            for (int i = 0; i < items; i++)
            {
                var t = new ThingStruct(i, i * 0.01F, d);
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
            _list.Add(TestThing);
        }

        private static int _id;

        public override void DoCommandB()
        {
            _dict.Add(++_id + _itemsLoaded, TestThing);    
        }
    }
}