using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace QLBSX_DAL_WS.Iterator
{
    public class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        
        public int Count
        {
            get { return _items.Count; }
        }
        
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}