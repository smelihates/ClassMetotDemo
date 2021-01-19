using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 977,
                Tckimlikno = "12345678911",
                Ad = "Hilmi",
                Soyad = "Doğan",
                Dogumyili = 1950
            };

            Musteri musteri2 = new Musteri
            {
                Id = 978,
                Tckimlikno = "34567891317",
                Ad = "Ahmet",
                Soyad = "Ergin",
                Dogumyili = 1965,
            };

            Musteri musteri3 = new Musteri
            {
                Id = 979,
                Tckimlikno = "56789111234",
                Ad = "Mehmet",
                Soyad = "Güneş",
                Dogumyili = 1970,
            };



            MusteriManager musteriManager = new MusteriManager();

            //müşteri ekleme
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            //müşterileri listele
            musteriManager.Listele(musteri1, musteri2, musteri3);

            //müşteri silme
            musteriManager.Sil(musteri2);

            Console.ReadLine();

        }
    }
}
