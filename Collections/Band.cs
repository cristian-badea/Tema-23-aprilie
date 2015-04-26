using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Band : IComparable
    {
        public string Name { get; private set; }
        public int StudioAlbums { get; private set; }
        public string Genre { get; private set; }
        public string Country { get; private set; }

        public Band(string name, int studioAlbums, string genre, string country)
        {
            Name = name;
            StudioAlbums = studioAlbums;
            Genre = genre;
            Country = country;
        }
        //Collections - Extra (for home) 2.Implement the IComparable interface in the Band class. 
        public int CompareTo(object obj)
        {
            Band secondBand = obj as Band;
            if(this.StudioAlbums > secondBand.StudioAlbums)
            {
                return -1;
            }
            if(this.StudioAlbums < secondBand.StudioAlbums)
            {
                return 1;
            }
            return 0;
        }
    }
}
