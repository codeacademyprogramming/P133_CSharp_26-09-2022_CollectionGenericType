using CollectionGenericType.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType
{
    //Generic Type Collection
    class MyCollection<T/*,U*/> /*where T : U where U : class,new()*/
    {
        T[] arr;

        public MyCollection()
        {
            arr = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

        public T Get(int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                return arr[index];
            }

            throw new IndexOutOfRangeException("Daxil Etdiyniz Index Yanlisdir");
        }

        //public bool CheckValue(T value)
        //{
        //    foreach (T item in arr)
        //    {
        //        if (item == value)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}
