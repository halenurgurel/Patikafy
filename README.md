## 🎵 Patikafy Music Library - LINQ Uygulaması

Bu C# konsol projesi, 11 sanatçının bulunduğu bir müzik kütüphanesi üzerinde LINQ (Language Integrated Query) sorguları ile veri işleme ve filtreleme işlemlerini içermektedir. Amaç, LINQ sorgularını öğrenmek ve gerçek dünya verileri üzerinde pratik yapmaktır.

---

## 🛠 Kullanılan Teknolojiler

- C# (.NET Core / .NET 6+ ile uyumlu)
- LINQ
- Nesne Tabanlı Programlama (OOP)
- Konsol Uygulaması

---

## 📄 Program Akışı (Program.cs)
Aşağıdaki sorgular LINQ ile gerçekleştirilmiştir:

## 🔍 LINQ Sorguları
* Adı "S" harfiyle başlayan sanatçılar
* Albüm satışı 10 milyonun üzerinde olan sanatçılar
* 2000 yılı öncesi çıkış yapmış ve Pop müzik türünde eser vermiş sanatçılar
* Çıkış yılına göre gruplanmış
* Alfabetik olarak sıralanmıştır
* En çok albüm satan sanatçı
* En yeni ve en eski çıkış yapan sanatçılar
---

## 🧠 Öğrenilen Konular
* LINQ Where, OrderBy, GroupBy, Select, First, Contains gibi yapılar
* Liste ve dizi işlemleri
* Class ve constructor overloading
* foreach ile koleksiyonları dolaşma
* Veri modelleme
---

## 📊 Örnek Çıktı (Konsol)
```csharp
Adı S ile Başlayan Şarkıcılar:
- Sertab Erener
- Serdar Ortaç
- Sezen Aksu
- Sıla

Albüm Satışları 10 Milyonun Üzerinde Olan Sanatçılar:
- Ajda Pekkan -> 20,000,000 milyon.
- Tarkan -> 40,000,000 milyon.

2000 Yılı Öncesi Çıkış Yapmış ve Pop Müzik Yapan Şarkıcılar 
(Çıkış Yıllarına Göre Gruplandırılmış ve Alfabetik Olarak Sıralanmıştır):

Yıl: 1968
- Ajda Pekkan

Yıl: 1971
- Sezen Aksu

Yıl: 1994
- Serdar Ortaç
- Sertab Erener
- Tarkan

En çok Albüm Satan Sanatçı: 
Tarkan - 40,000,000 milyon.

En yeni çıkış yapan şarkıcı: Sıla - 2009  
En eski çıkış yapan şarkıcı: Neşet Ertaş - 1960
