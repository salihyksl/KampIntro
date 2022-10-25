using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> AdYas = new MyDictionary<string, int>();
            AdYas.Add("salih", 26);
            AdYas.Add("salih", 26);
            AdYas.Add("salih", 26);
            AdYas.Add("salih", 26);
            AdYas.Add("salih", 26);
            AdYas.ShowList();

        }
    }
}
