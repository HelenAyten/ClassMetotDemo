using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.AdSoyad);
            Console.WriteLine();
        }       
        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine("Müşteri Silindi :  " + musteri.AdSoyad);
            Console.WriteLine();
        }
        
        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("---Müşteri Listesi---");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri ID : " + musteri.Id);
                Console.WriteLine("Musteri Adı : " + musteri.AdSoyad);
                Console.WriteLine("Musteri TC NO : " + musteri.TcNo);
                Console.WriteLine("Bulunduğu Şehir : " + musteri.Sehir);
                Console.WriteLine("----------------------- ");

            }

        }
        
    }
}
