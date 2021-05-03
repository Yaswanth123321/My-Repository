using System;
using System.Collections.Generic;

public class LinkedListExample
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var names = new LinkedList<string>();
        names.AddLast("Abc");
        names.AddLast("Agef");
        names.AddLast("Pefdsr");
        names.AddLast("Irddsc");

        //insert new element before "Peter"  
        LinkedListNode<String> node = names.Find("Agef");
        names.AddBefore(node, "John");
        names.AddAfter(node, "Lsfy");

        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}