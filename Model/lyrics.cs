using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_dani_andreev
{
    internal class lyrics
    {
        private int id;
        private int songid;
        private int placment;
        private int chordid;
        private string lyricsname;

        public int Id { get => id; set => id = value; }
        public int Songid { get => songid; set => songid = value; }
        public int Placment { get => placment; set => placment = value; }
        public int Chordid { get => chordid; set => chordid = value; }
        public string Lyricsname { get => lyricsname; set => lyricsname = value; }
    }
}
