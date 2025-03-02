namespace csharp_7_oop_1;

public class ogrenciler
{
    public string ad;
    public string soyad;
    public string sinif;
    
    public int ogrenciNo;

    public void GetInfo()
    {
        Console.WriteLine("Ad: ");
        string ad = Console.ReadLine();
        Console.WriteLine("Soyad: ");
        string soyad = Console.ReadLine();
        Console.WriteLine("Sınıf: ");
        string sinif = Console.ReadLine();
        Console.WriteLine("Öğrenci No: ");
        int ogrenciNo = Convert.ToInt32(Console.ReadLine());
    }
}
