using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
   

    class MyDictionary<T,K>
    {
        KeyValuePair<T, K>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T _Key, K _Value)
        {
            KeyValuePair<T,K>[] tempArray = items;
            items = new KeyValuePair<T, K>[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            
            items[items.Length - 1] = new KeyValuePair<T, K>(_Key, _Value);
        }
        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
