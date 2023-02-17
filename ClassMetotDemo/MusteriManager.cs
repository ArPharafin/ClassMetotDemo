using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle (Musteri mus)
        {
            Console.WriteLine(mus.MusteriIsim+" Isimli Musteri Sisteme Eklenmistir.");
        }
        public void Sil(Musteri mus)
        {
            Console.WriteLine(mus.MusteriID+" ID'li Musteri Sistemden silinmistir. ");

        }
        public void Listele(int MusteriID,string MusteriIsim,string MusteriSoyad,bool MusteriKrediAlabilme)
        {

        }
    }
}
