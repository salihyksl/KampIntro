using System;

namespace TernaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "salihyksl";
            string sifre = "12345678";
            

            Boolean giris = (kullaniciAdi == "salihyksl" && sifre == "123456") ? true : false;
            Console.WriteLine(giris);

        }
    }
}
