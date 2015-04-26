using System.Collections;
using System.Collections.Generic;


namespace Collections.Enumerable
{
    class BandsEnumerableReverse : IEnumerable<Band>
    {
        private Band[] bands;
        
        //Collections - Extra (for home) 1.Add an indexer to the BandsEnumerable class and print the items using the index.

        public Band this[int index]
        {
            get
            {
                return bands[index];
            }
            set
            {
                bands[index] = value;
            }
        }

        public BandsEnumerableReverse(Band[] bandsArray)
        {
            bands = new Band[bandsArray.Length];

            for(int i=0; i < bandsArray.Length; i++)
            {
                bands[i] = bandsArray[i];
            }
        }

        public IEnumerator<Band> GetEnumerator()
        {
            return new BandsEnumeratorReverse(bands);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
