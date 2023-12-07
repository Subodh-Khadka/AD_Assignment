using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> items;

    public Stack()
    {
        items = new List<T>();
    }

    public void Push(T item)
    {
        items.Add(item);
        Console.WriteLine($"Pushed: {item}");
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Cannot pop from an empty stack.");
            return default(T);
        }

        T poppedItem = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        Console.WriteLine($"Popped: {poppedItem}");
        return poppedItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Cannot peek into an empty stack.");
            return default(T);
        }

        return items[items.Count - 1];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}

public class Program
{
    public static void Main()
    {
        Stack<int> intStack = new Stack<int>();

        intStack.Push(100);
        intStack.Push(200);
        intStack.Push(300);

        intStack.Pop();

        intStack.Push(400);
        intStack.Push(500);

        Console.WriteLine($"Peek: {intStack.Peek()}");
        Console.WriteLine($"Is Empty: {intStack.IsEmpty()}");

        while (!intStack.IsEmpty())
        {
            intStack.Pop();
        }
        Console.WriteLine($"Is Empty: {intStack.IsEmpty()}");
    }
}
