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
        public List<string> Genres { get; set; } //Farklı türleri de yanyana yazdırabilmek için Liste olarak tanımladık.
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

        //Tek türlü sanatçılar için overload constructor kullandık, bu şekilde hem tek türlü sanatçıları yazdırırken hata almayacağız hem de çift türleri ayrı ayrı yazdırabileceğiz
        public MusicLibrary(string fullName, string genres, int releaseYear, int sales) : this(fullName, new List<string> { genres }, releaseYear, sales) {}

        public void GetLibrary() //Direkt yazdırabilmek için metot tanımladık.
        {
            string genresFormatted = string.Join(", ", Genres); //genreyı liste olarak tanımladığımız için string olarak birleştirmeye yarıyor.

            Console.WriteLine($"Sanatçının adı: {FullName}");
            Console.WriteLine($"Yaptığı Müzik Türü: {genresFormatted}");
            Console.WriteLine($"Çıkış Yılı: {ReleaseYear}");
            Console.WriteLine($"Albüm Satışları: {Sales:N0}"); //Sales:N0 yazdırarak 40000000 olan 40 milyon yazısını 40.000.000 şeklinde yazdıracak
            Console.WriteLine(" ");
        }
    }
}
