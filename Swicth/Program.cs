using System;

namespace Swicth
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi = random.Next(1,9);
            switch(sayi)
            {
                case 1:
                    Console.WriteLine("sayı : "+sayi);
                    break;
                case 2:
                    Console.WriteLine("sayı : " + sayi);
                    break;
                case 3:
                    Console.WriteLine("sayı : " + sayi);
                    break;
                case 4:
                    Console.WriteLine("sayı : " + sayi);
                    break;
                case 5:
                    Console.WriteLine("sayı : " + sayi);
                    break;
                case 6:
                    Console.WriteLine("sayı : " + sayi);
                    break;
                case 7:
                    Console.WriteLine("sayı : " + sayi);
                    break;
                case 8:
                    Console.WriteLine("sayı : " + sayi);
                    break;
                case 9:
                    Console.WriteLine("sayı : " + sayi);
                    break;


            }
            
        }
    }
}
