using System;
using System.Collections.Generic;

namespace DictionaryFormati
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> AdiYasi = new Dictionary<string,int>();
            AdiYasi.Add("salih",26);
            AdiYasi.Add("isa", 22);

            var item = AdiYasi.Count;
            Console.WriteLine(item);

            

            foreach (var deger in AdiYasi)
            {
                Console.WriteLine(deger);
            }
            AdiYasi.Remove("isa");
            var item1 = AdiYasi.Count;
            Console.WriteLine(item1);



            foreach (var deger in AdiYasi)
            {
                Console.WriteLine(deger);
            }
        }
    }
}
