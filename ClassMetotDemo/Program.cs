using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Okan";
            musteri1.Soyadi = "Erk";
            musteri1.TcNo = "111111111";
            musteri1.Bakiye = 5000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Özge";
            musteri2.Soyadi = "By";
            musteri2.TcNo = "121211122";
            musteri2.Bakiye = 3000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------------");
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri2);

        }
    }
}
