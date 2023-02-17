using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Musteriler = new string[] { };

            Musteri mus0= new Musteri();
            mus0.MusteriID = 12;
            mus0.MusteriIsim = "Faik";
            mus0.MusteriSoyad = "Abasıyanık";
            mus0.MusteriKrediAlabilme = true;
            mus0.MusteriFaizOrani = 1.59;
            mus0.MusteriBakiye = 4537;

            Musteri mus1=new Musteri();
            mus1.MusteriID = 13;
            mus1.MusteriIsim = "Nazım";
            mus1.MusteriSoyad = "Hikmet";
            mus1.MusteriKrediAlabilme = false;
            mus1.MusteriFaizOrani = 0.75;
            mus1.MusteriBakiye = 8700;

            Musteri[] cust = new Musteri[] { mus0, mus1 };
            foreach(var custs in cust)
            {
                Console.WriteLine("Musteri ID'si: "+custs.MusteriID);
                Console.WriteLine("Musteri Ismi: "+custs.MusteriIsim);
                Console.WriteLine("Musteri Soyadi: "+custs.MusteriSoyad);
                Console.WriteLine("Musteri Kredi Alabilme Durumu: "+custs.MusteriKrediAlabilme);
                Console.WriteLine("Musteri Faiz Orani: "+custs.MusteriFaizOrani);
                Console.WriteLine("Musteri Bakiyesi: " + custs.MusteriBakiye);
                Console.WriteLine("---------------------------");
            }
            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(mus0);
            musteriManager.Ekle(mus1);
            musteriManager.Sil(mus0);

            musteriManager.Listele(14, "Omer", "Yılmaz", true);
            musteriManager.Listele(15, "Talha", "Kurt", false);

        }
    }
}
