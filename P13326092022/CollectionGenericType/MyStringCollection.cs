using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType
{
    class MyStringCollection
    {
        string[] arr;

        public MyStringCollection()
        {
            arr = new string[0];
        }

        public void Add(string item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

        public string Get(int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                return arr[index];
            }

            Console.WriteLine("Daxil Etdiyniz Index Yanlisdir");

            return null;
        }

        public bool CheckValue(string value)
        {
            foreach (string item in arr)
            {
                if (item == value)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
