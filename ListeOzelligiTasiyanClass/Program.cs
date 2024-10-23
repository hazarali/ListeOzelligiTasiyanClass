using System;

class Program
{
    static void Main(string[] args)
    {
        MyList<string> myList = new MyList<string>();

        // Add items
        myList.Add("Apple");
        myList.Add("Banana");
        myList.Add("Orange");

        // List items
        myList.ListItems();

        // Remove an item
        myList.Remove("Banana");

        // List items again
        myList.ListItems();

        // Get the number of items in the list
        Console.WriteLine($"Number of items: {myList.Count()}");
    }
}
