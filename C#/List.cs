using System;
using System.Collections.Generic;

class Lists
{

    // Main Method
    public static void Main(String[] args)
    {

        // Creating a List of integers
        // Here we are not setting
        // Capacity explicitly
        List<int> list1 = new List<int>();

        // adding elements in list1
        list1.Add(20);
        list1.Add(82);
        list1.Add(79);
        list1.Add(100);

        foreach (int i in list1)
        {
            //Printing the list
            Console.WriteLine(i);
        }

        // Printing the Capacity of list
        Console.WriteLine("Capacity Is: " + list1.Capacity);
        // Printing the Count of list
        Console.WriteLine("Count Is: " + list1.Count);

        // Adding more element
        //in the list
        list1.Add(5);
        list1.Add(6);

        // Printing the Capacity of list1
        // It will give output 8 as internally
        // List is resized
        Console.WriteLine("Capacity Is: " + list1.Capacity);

        // Printing the Count of list1
        Console.WriteLine("Count Is: " + list1.Count);
        //checks whether a list contains a value
        //return true if existed, false otherwise
        Console.WriteLine("contains:" + list1.Contains(1));
        //remove an element at index x
        //return true if the element is remvoved, false otherwise
        Console.WriteLine("Remove:" + list1.Remove(6));
        //clear list1
        foreach(int i in list1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Element in list1: " + list1.Count);
        //Removes all element in the list
        list1.Clear();
        //Prints the new list
        Console.WriteLine("list1 is now: " + list1.Count);
       

    }
}