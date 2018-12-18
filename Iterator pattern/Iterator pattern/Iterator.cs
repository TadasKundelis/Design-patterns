using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }

    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

      
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }


        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }

        public int Step {
            get { return _step; }
            set { _step = value; }
        }

        public Item CurrentItem {
            get { return _collection[_current] as Item; }
        }

        public bool IsDone {
            get { return _current >= _collection.Count; }
        }
    }
}
 
      

