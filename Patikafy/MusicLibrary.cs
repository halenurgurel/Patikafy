using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patikafy
{
    public class MusicLibrary
    {
        public string FullName { get; set; }
        public List<string> Genres { get; set; }
        public int ReleaseYear { get; set; }
        public int Sales { get; set; }

        //Nesne yazımı kolay olması için constructor tanımladım.
        public MusicLibrary(string fullName, List<string> genres, int releaseYear, int sales)
        {
            FullName = fullName;
            Genres = genres;
            ReleaseYear = releaseYear;
            Sales = sales;
        }

        //Tek türlü sanatçılar için overload constructor kullandık
        public MusicLibrary(string fullName, string genres, int releaseYear, int sales) : this(fullName, new List<string> { genres }, releaseYear, sales) {}

        public void GetLibrary() //Direkt yazdırabilmek için metot tanımladık.
        {
            string genresFormatted = string.Join(", ", Genres);

            Console.WriteLine($"Sanatçının adı: {FullName}");
            Console.WriteLine($"Yaptığı Müzik Türü: {genresFormatted}");
            Console.WriteLine($"Çıkış Yılı: {ReleaseYear}");
            Console.WriteLine($"Albüm Satışları: {Sales:N0}");
            Console.WriteLine(" ");
        }
    }
}
