using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_dani_andreev
{
    
    
        public class ArtistList : List<artist>
        {
            public ArtistList() { }
            public ArtistList(IEnumerable<artist> list) : base(list) { }
            public ArtistList(IEnumerable<BaseEntity> list) : base(list.Cast<artist>().ToList()) { }
        }
    
}

