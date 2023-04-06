using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Classes
{
    public class Music
    {
        public string ArtistName { get; set; }
        public string SongTitle { get; set; }
        public long ReleaseDate { get; set; }
        public Music(string artistName, string songTitle, long releaseDate)
        {
            ArtistName = artistName;
            SongTitle = songTitle;
            ReleaseDate = releaseDate;
        }
        public override string ToString()
        {
            return "Имя Артиста - " + ArtistName + "  Назавние песни - "  + SongTitle + "  Год выхода песни: " + ReleaseDate; 
        }
    }

}