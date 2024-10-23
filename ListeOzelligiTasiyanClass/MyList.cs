using System;
using System.Collections.Generic;

public class MyList<T>
{
    // Private list that holds the items
    private List<T> _items;

    // Constructor to initialize the list
    public MyList()
    {
        _items = new List<T>();
    }

    // Method to add an item to the list
    public void Add(T item)
    {
        _items.Add(item);
        Console.WriteLine($"{item} added to the list.");
    }

    // Method to remove an item from the list
    public void Remove(T item)
    {
        if (_items.Contains(item))
        {
            _items.Remove(item);
            Console.WriteLine($"{item} removed from the list.");
        }
        else
        {
            Console.WriteLine($"{item} not found in the list.");
        }
    }

    // Method to list all items in the list
    public void ListItems()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            Console.WriteLine("Items in the list:");
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Method to get the number of items in the list
    public int Count()
    {
        return _items.Count;
    }
}
