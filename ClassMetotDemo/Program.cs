using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Musteri sınıfımızdan m1,m2,m3 nesnelerimizi oluşturduk ve özelliklerini tanımladık.
            Musteri m1 = new Musteri();
            m1.Id = 1;
            m1.Ad = "Ayşe";
            m1.Soyad = "Yılmaz";

            Musteri m2 = new Musteri();
            m2.Id = 2;
            m2.Ad = "Murat";
            m2.Soyad = "Çelik";

            Musteri m3 = new Musteri();
            m3.Id = 3;
            m3.Ad = "Selin";
            m3.Soyad = "Akça";

            //MusteriManager sınıfımızdan musteriManager nesnemizi oluşturduk ve Ekleme-Listeleme-Silme metodlarımızı çağırdık.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(m1);
            musteriManager.MusteriEkle(m2);  //Parametre olarak nesneleri yolladık.
            musteriManager.MusteriEkle(m3);


            Musteri[] musteriler = new Musteri[] { m1, m2, m3 }; //nesnelerimizi diziye ekledik.

            musteriManager.MusteriListele(musteriler); //diziye eklemiş olduğumuz nesnelerimizi listeledik.

            musteriManager.MusteriSil(m3);


        }
    }
}