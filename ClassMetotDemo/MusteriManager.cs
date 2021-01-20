using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine("Müşteri Eklendi : " + musteri.Ad + " " + musteri.Soyad + "\n");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            //müşterilerimizin özelliklerini for-each döngümüzle sırasıyla listeledik.

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID : " + musteri.Id);
                Console.WriteLine("Müşteri Adı : " + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
                Console.WriteLine("**************************");
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Ad + " " + musteri.Soyad + "\n");
        }
    }
}