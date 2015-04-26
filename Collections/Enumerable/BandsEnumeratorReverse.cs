using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Enumerable
{
    class BandsEnumeratorReverse : IEnumerator<Band>
    {
        public Band Current { get { return currentBand; } }
        object IEnumerator.Current
        {
            get { return Current; }
        }

        private Band[] collection;
        private int currentIndex;
        private Band currentBand;

        public BandsEnumeratorReverse(IEnumerable<Band> bandsCollection)
        {
            collection = bandsCollection.ToArray();
            currentIndex = collection.Count();
            currentBand = null;
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            currentIndex--;
            if (currentIndex == -1)
            {
                return false;
            }

            currentBand = collection[currentIndex];
            return true;
        }

        public void Reset()
        {
            currentIndex = collection.Count();
            currentBand = null;
        }
    }
}
