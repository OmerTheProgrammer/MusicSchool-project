using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class person:BaseEntity
    {
        private string name;
        private string code;

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
    }
}
