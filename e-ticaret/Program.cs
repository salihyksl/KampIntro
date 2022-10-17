using System;

namespace e_ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "lenova";
            urun1.UrunAciklamasi = "lenova laptop";
            urun1.UrunFiyat = 225;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "hp";
            urun2.UrunAciklamasi = "lenova laptop";
            urun2.UrunFiyat = 350;

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.UrunAdi = "monster";
            urun3.UrunAciklamasi = "monster laptop";
            urun3.UrunFiyat = 450;


            Urun[] urunler =new Urun[]  { urun1, urun2, urun3 };
            Console.WriteLine("----------------For--------------------");
            for(int i=0;i<urunler.Length;i++)
            {
                Console.WriteLine("Urun İd : " + urunler[i].Id);
                Console.WriteLine("Urun Adi : "+urunler[i].UrunAdi);
                Console.WriteLine("Urun Açıklaması: " + urunler[i].UrunAciklamasi);
                Console.WriteLine("Urun Fiyatı : " + urunler[i].UrunFiyat);
                Console.WriteLine("-----------------------------------------------");

            }
            Console.WriteLine("----------------Foreach--------------------");

            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun İd : " + urun.Id);
                Console.WriteLine("Urun Adi : " + urun.UrunAdi);
                Console.WriteLine("Urun Açıklaması : " + urun.UrunAciklamasi);
                Console.WriteLine("Urun Fiyatı : " + urun.UrunFiyat);
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("----------------While--------------------");
            int sayac = 0;
            while(sayac<urunler.Length)
            {
                Console.WriteLine("Urun İd : " + urunler[sayac].Id);
                Console.WriteLine("Urun Adi : " + urunler[sayac].UrunAdi);
                Console.WriteLine("Urun Açıklaması : " + urunler[sayac].UrunAciklamasi);
                Console.WriteLine("Urun Fiyatı : " + urunler[sayac].UrunFiyat);
                Console.WriteLine("-----------------------------------------------");
                sayac++;
            }

        }
    }
}
