using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> test = new MyGeneric<int>();
            test.add(1);
            test.add(4);
            test.add(6);
            test.add(3);

            Console.WriteLine($"item in index 3 is: {test.getItemByIndex(3)}");
            
            foreach(int i in test.Mysort())
            {
                Console.WriteLine($"{i}");
            }
           

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
        private List<T> collection = new List<T>();
        
        public void add(T t)
        {
            collection.Add(t);
        }

        public T getItemByIndex(int index)
        {
          return  collection[index];   
        }

        public List<T> Mysort()
        {
            collection.Reverse();
            return collection.OrderByDescending(x => x).ToList();
        }

    }
}
