using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Member
    {
        public int Id { get; set; }

        public int BandId { get; set; }

        public string Name { get; set; }

        public Member(int Id, int BandId, string Name)
        {
            this.Id = Id;
            this.BandId = BandId;
            this.Name = Name;
        }
    }
}
