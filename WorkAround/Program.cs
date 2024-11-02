using Business.Concrete;
using Entities.Concreate;

internal class Program
{
    static void Main(string[] args)
    {
        string mesaj = "selam";
        int sayi = 100;
        bool girisYapmismi = false;

        //diziler arrays

        string ogrenci1 = "engin";
        string ogrenci2 = "kerem";
        string ogrenci3 = "berkay";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "engin";
        ogrenciler[1] = "kerem";
        ogrenciler[2] = "berkay";

        for(int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }
        string[] sehirler1 = new[] { "İstanbul,İzmir,Ankara" };
        string[] sehirler2 = new[] { "Bursa,Antalya,Diyarbakir" };

        sehirler1 = sehirler2;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);
        //referans deger yani sonuc adana

        foreach (string sehir in sehirler1) 
        {
            Console.WriteLine(sehir);
        }
        List<string> yeniSehirler1 = new List<string> { "Ankara 1,İstanbul 1,İzmir 1" };
        yeniSehirler1.Add(item: "Adana 1");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        Person person1 = new Person();
        person1.FirstName = "Engin";

        Person person2 = new Person();
        person2.FirstName = "Murat";


        PttManager pttManager = new PttManager(new ForeignerManager());
        pttManager.GiveMask(person1);

        


        

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;

        //sayi2 = int deger tip odugu icin sayı2 nin cevabı 10 olur basta atadıgımız deger degismez




            //public string ad = "frank";
            //public string soyAd = "ocean";
            //public int dogumYılı = 1985;
            //public long tcNo = 1234567891011;

        //string Ad = "frank";
        //string SoyAd = "ocean";
        //int DogumYılı = 1985;
        //long TcNo = 1234567891011;

        Console.WriteLine(mesaj);

        Vatandas vatanas = new Vatandas();
    }
}

public class Vatandas

{
    public string Ad { get; set; }
    public string SoyAd { get; set; }
    public int DogumYili { get; set; }
    public int TcNo {  get; set; } 


}

