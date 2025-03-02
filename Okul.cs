namespace csharp_7_oop_1;

static internal class Okul // static class lar nesne üretmez, direk ulaşılır.
{
    static public string adress;
    static public int personalCount;

    static public void GetInfo()
    {
        Console.WriteLine("Adres: ");
        string adress = Console.ReadLine();
        Console.WriteLine("Personel Sayısı: ");
        int personalCount = Convert.ToInt32(Console.ReadLine());
    }
}
