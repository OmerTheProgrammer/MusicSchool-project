using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_dani_andreev
{
    internal class song
    {
        private int id;
        private string name;
        private int artistid;
        private int gaenreid;
        private int difficultyid;
        private int languageid;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Artistid { get => artistid; set => artistid = value; }
        public int Gaenreid { get => gaenreid; set => gaenreid = value; }
        public int Difficultyid { get => difficultyid; set => difficultyid = value; }
        public int Languageid { get => languageid; set => languageid = value; }
    }
}
