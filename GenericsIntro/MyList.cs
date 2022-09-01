using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)
        {
            T[] tempArray = items; //to save the previous values at the old reference 
            items = new T[items.Length + 1]; //create a new array with length + 1

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            
            items[items.Length - 1] = item;
        }
    }
}
