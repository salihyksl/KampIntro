using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun Urun1 = new Urun();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya elması";

            Urun Urun2 = new Urun();
            Urun2.Adi = "karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır karpuzu";



            Urun[] urunler = new Urun[] {Urun1,Urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("---------------------Metotlar-----------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("armut","yeşil armut",12,8);
            sepetManager.Ekle2("elma", "yeşil elma", 12,7);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,5);


        }
    }
}
