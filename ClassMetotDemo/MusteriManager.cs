using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad +" isimli müşteri eklendi.");
            Console.WriteLine("******************************************************************************");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşterinin kaydı silindi.");
            Console.WriteLine("******************************************************************************");
        }

        public void Listele(params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + "-" +musteri.Tckimlikno +"-" + musteri.Ad + "-" + musteri.Soyad + "-" + musteri.Dogumyili);
            }
            Console.WriteLine("******************************************************************************");
        }
    }
}
