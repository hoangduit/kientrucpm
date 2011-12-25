using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBSX_DAL_WS.Iterator
{
    public class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;
        
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        public BienSoXe First()
        {
            _current = 0;
            return _collection[_current] as BienSoXe;
        }

        public BienSoXe Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as BienSoXe;
            else
                return null;
        }
        
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public BienSoXe CurrentItem
        {
            get { return _collection[_current] as BienSoXe; }
        }
        
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}