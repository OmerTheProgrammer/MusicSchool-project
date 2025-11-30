using Model;
using ViewModel;
using System.Data.OleDb;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region song
            SongDB sdb = new();
            SongList sList = sdb.SelectAll();
            foreach (song c in sList)
            {
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Gaenreid);
                Console.WriteLine(c.Artistid);
                Console.WriteLine(c.Difficultyid);
                Console.WriteLine(c.Languageid);
            }
            song songToUpdate = sList[0];
            songToUpdate.Name += " חדש";
            sdb.Update(songToUpdate);
            int xs = sdb.SaveChanges();
            Console.WriteLine($"{xs} rows were updated");

            #endregion

            #region genre
            GenreDB gdb = new();
            GenreList gList = gdb.SelectAll();
            foreach(genre c in gList)
               Console.WriteLine(c.Genrename);
            genre genreToUpdate = gList[0];
            genreToUpdate.Genrename += " חדש";


            gdb.Update(genreToUpdate);
            int xg = gdb.SaveChanges();
            Console.WriteLine($"{xg} rows were updated");

            #endregion

            #region Chord
            ChordDB chdb = new();
            ChordList chList = chdb.SelectAll();
            foreach (chord c in chList)
            {
                Console.WriteLine(c);
                
            }
            chord chordToUpdate = chList[0];
            chordToUpdate.Name += " חדש";


            chdb.Update(chordToUpdate);
            int xc = chdb.SaveChanges();
            Console.WriteLine($"{xc} rows were updated");


            #endregion

            #region difficulty
            DifficultyDB ddb = new();
            DifficultyList dList = ddb.SelectAll();
            foreach (difficulty c in dList)
                Console.WriteLine(c.Diff);
            difficulty difficultyToUpdate = dList[0];
            difficultyToUpdate.Diff =3 ;


            ddb.Update(difficultyToUpdate);
            int xd = ddb.SaveChanges();
            Console.WriteLine($"{xd} rows were updated");
            #endregion

            #region language
            LanguageDB ldb = new();
            LanguageList lList = ldb.SelectAll();
            foreach (language c in lList)
                Console.WriteLine(c.Languagename);
            language languageToUpdate = lList[0];
            languageToUpdate.Languagename += " חדש";


            ldb.Update(languageToUpdate);
            int xl = ldb.SaveChanges();
            Console.WriteLine($"{xl} rows were updated");
            #endregion

            #region lyrics 
            LyricsDB lydb = new();
            LyricsList lyList = lydb.SelectAll();
            foreach (lyrics c in lyList)
            {
                Console.WriteLine(c.Lyricsname);
                Console.WriteLine(c.Songid);
                Console.WriteLine(c.Placment);
                Console.WriteLine(c.Chordid.Id);

            }

            lyrics lyricsToUpdate = lyList[0];
            lyricsToUpdate.Lyricsname = "2 חדש";

            lydb.Update(lyricsToUpdate);
            int xly = lydb.SaveChanges();
            Console.WriteLine($"{xly} rows were updated");

            #endregion

            #region person
            PersonDB pdb = new();
            PersonList pList = pdb.SelectAll();
            foreach (person c in pList)
            {
                Console.WriteLine(c.Code);
                Console.WriteLine(c.Name);
            }
            person personToUpdate = pList[0];
            personToUpdate.Name += " חדש";


            pdb.Update(personToUpdate);
            int xp = pdb.SaveChanges();
            Console.WriteLine($"{xp} rows were updated");

            #endregion

           

            #region artist
            ArtistDB adb = new();
            ArtistList aList = adb.SelectAll();
            foreach (Artist c in aList)
            {
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Code);

            }
            Artist artistToUpdate =  aList[0];
            artistToUpdate.Name += " חדש";


            adb.Update(artistToUpdate);
            int xa = adb.SaveChanges();
            Console.WriteLine($"{xa} rows were updated");

            #endregion

        }
    }
}
