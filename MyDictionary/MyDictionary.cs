using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T>
    {

        T[] items;
        public MyDictionary()
        {
            items = new T[0];
        }

        public void Add(T item)
        {

            T[] tempArray = items; //The temporary array was defined so that the reference number would not be lost.
            items = new T[items.Length+1]; //In order for a new element to be added to the array,
                                          //the number of elements of the array must be one more than the previous one.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;

            Console.WriteLine(item);

        }
    }
}
