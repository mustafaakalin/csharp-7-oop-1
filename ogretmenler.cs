namespace csharp_7_oop_1;

public class ogretmenler
{
    public string ad;
    public string soyad;
    public string brans;
    public string unvan;
    public string ders;
    public string derslik;
    public string sinif;
    public string okul;
    public float maas;

    public void GetInfo()
    {
        Console.WriteLine("Ad: ");
        string ad = Console.ReadLine();
        Console.WriteLine("Soyad: ");
        string soyad = Console.ReadLine();
        Console.WriteLine("Branş: ");
        string brans = Console.ReadLine();
        Console.WriteLine("Ünvan: ");
        string unvan = Console.ReadLine();
        Console.WriteLine("Ders: ");
        string ders = Console.ReadLine();
        Console.WriteLine("Derslik: ");
        string derslik = Console.ReadLine();
        Console.WriteLine("Sınıf: ");
        string sinif = Console.ReadLine();
        Console.WriteLine("Okul: ");
        string okul = Console.ReadLine();
    }

}
