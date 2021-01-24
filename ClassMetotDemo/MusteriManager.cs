using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri " + musteri.Adi+ " eklendi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri numarası = " + musteri.Id);
                Console.WriteLine("Müşteri Adı = " + musteri.Adi);
                Console.WriteLine("Bakiye = " + musteri.Bakiye);
                Console.WriteLine("------------------------");
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri " + musteri.Adi + " silindi.");
        }
    }
}
