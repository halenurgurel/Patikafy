using Patikafy;
using System.Collections.Concurrent;
using System.ComponentModel;

//11 sanatçımızın bulunduğu Listeyi tanımladık ve nesneleri girdik.

var artists = new List<MusicLibrary>
{
    new("Ajda Pekkan", "Pop", 1968, 20000000),
    new("Sezen Aksu", new List<string> {"Türk Halk Müziği", "Pop" }, 1971, 10000000),
    new("Funda Arar", "Pop", 1999, 3000000),
    new("Sertab Erener", "Pop", 1994, 5000000),
    new("Sıla", "Pop", 2009, 3000000),
    new("Serdar Ortaç", "Pop", 1994, 10000000),
    new("Tarkan", "Pop", 1994, 40000000),
    new("Hande Yener", "Pop", 1999, 7000000),
    new("Hadise", "Pop", 2005, 5000000),
    new("Gülben Ergen", new List<string> {"Pop", "Türk Halk Müziği"}, 1997, 10000000),
    new("Neşet Ertaş", new List<string> {"Türk Halk Müziği", "Türk Sanat Müziği" }, 1960, 2000000),
};

//Tüm sanatçıları, türlerini, albüm çıkış yıllarını ve satışlarını yazdırdık.
Console.WriteLine("--Şarkıcı Listesi--");
foreach (var artist in artists)
{
    artist.GetLibrary();
}

//Linq sorguları
Console.WriteLine("--Linq Sorguları--");

//Adı 'S' ile başlayan Şarkıcılar.

var namesStartsWithS = artists.Where(artists => artists.FullName.StartsWith("S"));

Console.WriteLine("Adı S ile Başlayan Şarkıcılar: ");
Console.WriteLine(" ");
foreach (var artist in namesStartsWithS)
{
    Console.WriteLine(artist.FullName);
}

Console.WriteLine();
Console.WriteLine();



//Albüm satışları 10 milyonun üzerinde olan şarkıcılar.

var mmoreThanTenMillion = artists.Where(artists => artists.Sales > 10000000);

Console.WriteLine("Albüm Satışları 10 Milyonun Üzerinde Olan Sanatçılar: ");
Console.WriteLine(" ");
foreach(var artist in mmoreThanTenMillion)
{
    Console.WriteLine($"{artist.FullName} -> {artist.Sales:N0}");
}

Console.WriteLine();
Console.WriteLine();



//2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

var popMusic = artists.Where(artists => artists.ReleaseYear < 2000 && artists.Genres.Contains("Pop"))
                      .OrderBy(artist => artist.FullName) //Önce İsme göre sıraladık
                      .GroupBy(artists => artists.ReleaseYear) //sonra yıla göre grupladık.
                      .OrderBy(group => group.Key); //sonra yıla göre sıraladık.

Console.WriteLine("2000 Yılı Öncesi Çıkış Yapmış ve Pop Müzik Yapan Şarkıcılar ");
Console.WriteLine("(Çıkış Yıllarına Göre Gruplandırılmış ve Alfabetik Olarak Sıralanmıştır).");
Console.WriteLine();

foreach (var group in popMusic)
{
    Console.WriteLine($"Yıl: {group.Key}"); //2000'den öncesini alır

    foreach (var artist in group)
        Console.WriteLine($"- {artist.FullName}");
}

Console.WriteLine();
Console.WriteLine();



//En çok albüm satan şarkıcı

var topSeller = artists.OrderByDescending(artists => artists.Sales).First();

Console.WriteLine("En çok Albüm Satan Sanatçı: ");
    Console.WriteLine($"{topSeller.FullName} - {topSeller.Sales:N0}");

Console.WriteLine();
Console.WriteLine();



//En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı

var newestArtist = artists.OrderByDescending(artists => artists.ReleaseYear).First();
Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newestArtist.FullName} - {newestArtist.ReleaseYear}");

var eldestArtist = artists.OrderBy(artists => artists.ReleaseYear).First();
Console.WriteLine($"En eski çıkış yapan şarkıcı: {eldestArtist.FullName} - {eldestArtist.ReleaseYear}");

Console.WriteLine();
Console.WriteLine();