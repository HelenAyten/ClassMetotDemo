using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdSoyad = "Uğur BALA";
            musteri1.TcNo = "276314";
            musteri1.Sehir = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdSoyad = "Biber Osman";
            musteri2.TcNo = "326748";
            musteri2.Sehir = "İstanbul";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);            
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);


        }
    }
}
