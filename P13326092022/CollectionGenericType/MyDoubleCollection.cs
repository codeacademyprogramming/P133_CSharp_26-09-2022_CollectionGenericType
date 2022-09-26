using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType
{
    class MyDoubleCollection
    {
        double[] arr;

        public MyDoubleCollection()
        {
            arr = new double[0];
        }

        public void Add(double item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

        public double? Get(int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                return arr[index];
            }

            Console.WriteLine("Daxil Etdiyniz Index Yanlisdir");

            return null;
        }

        public bool CheckValue(double value)
        {
            foreach (double item in arr)
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
