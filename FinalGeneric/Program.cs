using System;
using System.Collections.Generic;

namespace FinalGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

//    Write a generic class that meets the following requirements:
//1)    That constrains a developer to only instantiate the class based on value types
//2)    Contains a private generic collection
//3)    Has a method to add items to the private collection
//4)    Has a method that will return an item from the list(e.g.item 3 or item 4 in the list)
//5)    Has a method that returns a sorted collection with the items in descending order
    class MyGeneric<T> where T : struct 
    {
        private List<T> collection;
        
        public void add(T t)
        {
            collection.Add(t);
        }

        public T getItemByIndex(int index)
        {
            foreach(T t in collection)
            {
                if(collection.FindIndex(t) == index)
                {
                    return t;
                }
            }
            
        }

        public ICollection<T> Mysort()
        {
            collection.Sort();
            return collection;
        }

    }
}
