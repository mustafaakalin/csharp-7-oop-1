// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace csharp_7_oop_1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        ogretmenler ogretmen1 = new ogretmenler(); // nesne ürettik oop
        ogretmenler ogretmen2 = new ogretmenler(); // nesne ürettik oop
        ogretmen1.ad = "Ali";
        ogretmen1.soyad = "Veli";
        ogretmen1.brans = "Matematik";
        ogretmen1.unvan = "Öğretmen";
        ogretmen1.ders = "Matematik";
        ogretmen1.derslik = "A101";
        ogretmen1.sinif = "9A";
        ogretmen1.okul = "İstanbul Lisesi";
        ogretmen1.maas = 5000;
        ogretmen2.ad = "Ayşe";
        ogretmen2.soyad = "Fatma";
        ogretmen2.brans = "Fen";
        ogretmen2.unvan = "Öğretmen";
        ogretmen2.ders = "Fen";
        ogretmen2.derslik = "B101";
        ogretmen2.sinif = "9B";
        ogretmen2.okul = "İstanbul Lisesi";
        ogretmen2.maas = 5000;

        ogrenciler ogrenci1 = new ogrenciler(); // nesne ürettik oop
        ogrenciler ogrenci2 = new ogrenciler(); // nesne ürettik oop
        ogrenci1.ad = "Ayşe";
        ogrenci1.soyad = "Fatma";
        ogrenci1.sinif = "9A";
        ogrenci1.ogrenciNo = 123;
        ogrenci2.ad = Console.ReadLine();
        ogrenci2.soyad = Console.ReadLine();
        ogrenci2.sinif = Console.ReadLine();
        ogrenci2.ogrenciNo = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Öğrenci Adı: " + ogrenci1.ad);
        // Console.WriteLine("Öğrenci Adı: " + ogrenci2.ad);


        // Console.WriteLine("Öğretmen Adı: " + ogretmen1.ad);
        Okul.adress = "İstanbul"; // static class lar nesne üretmez, direk ulaşılır.
        Okul.personalCount = 10;
        Console.WriteLine("Adres: " + Okul.adress);
        Console.WriteLine("Personel Sayısı: " + Okul.personalCount);
        // Okul.GetInfo();

    }
}

class Ogrenciler
{
    
}

class Ogretmenler
{


}