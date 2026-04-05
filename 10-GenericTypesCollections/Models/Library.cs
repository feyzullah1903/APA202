using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Models
{
    internal class Library<T> where T:Book
    {
        public string Name { get; set; }
        public List<T> Items { get; set; }
        public Library(string name)
        {
            Name = name;
            Items = new List<T>();
        }
        public void AddItem(T item)
        {
            Items.Add(item);
            Console.WriteLine($"Kitab elave edildi----{Name}");
        }
        public void RemoveItem(T item)
        {
           Items.Remove(item);
            Console.WriteLine($"Kitab silindi----{Name}");

        }
        public List<T>  GetAllItems()
        {
            return Items;
        }
        public int  GetCount ()
        {
            return Items.Count;
        }
        public T FinfItemindex(int id)
        {
            if (id>=0&& id<=Items.Count )
            {
                return Items[id];
            }
            return null;
            
        }


    }
}
