using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_dani_andreev
{
    internal class chord
    {
        private int id;
        private string name;
        private int difficulty;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }
    }
}
