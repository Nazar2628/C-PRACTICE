//using System;
//using System.Threading;
//using System.Collections.Concurrent;
//using System.Collections.Generic;

//namespace ConcurrentCollections
//{
//    class Program
//    {
//        static ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();

//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(Method1);
//            Thread t2 = new Thread(Method2);
//            t1.Start();
//            t2.Start();
//            t1.Join();
//            t2.Join();

//            foreach (KeyValuePair<int, string> item in dictionary)
//            {
//                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
//            }

//            Console.ReadKey();
//        }

//        public static void Method1()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                dictionary.TryAdd(i, "Added By Method1 " + i);
//                Thread.Sleep(100);
//            }
//        }

//        public static void Method2()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                dictionary.TryAdd(i, "Added By Method2 " + i);
//                Thread.Sleep(100);
//            }
//        }
//    }
//}


//}

//using System;
//using System.Collections.ObjectModel;

//class Program
//{
//    static void Main(string[] args)
//    {
//        ObservableCollection<string> collection = new ObservableCollection<string>();

//        // Subscribe to the CollectionChanged event to receive notifications of changes to the collection
//        collection.CollectionChanged += CollectionChangedHandler;

//        // Add some items to the collection
//        collection.Add("Item 1");
//        collection.Add("Item 2");
//        collection.Add("Item 3");

//        // Modify the collection
//        collection.RemoveAt(0);
//        collection[0] = "Modified item";

//        // Remove all items from the collection
//        collection.Clear();
//    }

//    static void CollectionChangedHandler(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//    {
//        // Handle the collection changed event
//        Console.WriteLine($"Action: {e.Action}");

//        if (e.OldItems != null)
//        {
//            Console.WriteLine("Old items:");
//            foreach (var item in e.OldItems)
//            {
//                Console.WriteLine($"\t{item}");
//            }
//        }

//        if (e.NewItems != null)
//        {
//            Console.WriteLine("New items:");
//            foreach (var item in e.NewItems)
//            {
//                Console.WriteLine($"\t{item}");
//            }
//        }
//    }
//}

//using System;
//using System.Collections.ObjectModel;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create an observable collection of integers
//        ObservableCollection<int> numbers = new ObservableCollection<int>();

//        // Add event handler to the CollectionChanged event
//        numbers.CollectionChanged += Numbers_CollectionChanged;

//        // Add some numbers to the collection
//        numbers.Add(1);
//        numbers.Add(2);
//        numbers.Add(3);

//        Console.ReadKey();
//    }

//    private static void Numbers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//    {
//        // Output the action that caused the change
//        Console.WriteLine("Collection changed: {0}", e.Action);
//    }
//}


using System.Collections.ObjectModel;
using System.Collections.Specialized;

//class ObservableCol
//{
//    static void Main(string[] args)
//    {
//        ObservableCollection<int> values = new ObservableCollection<int>() {15,154,6,5,16};

//        values.CollectionChanged += Values_CollectionChanged;

//        values.Add(1);
//        values.Add(2);
//        values.Add(3);

//        values[0] = 10;
//        values.Remove(154);
//        values.RemoveAt(3);

//        Console.WriteLine("New List");

//        foreach (int i in values) 
//        { 
//            Console.Write($"{i} ");
//        }
//    }

//    private static void Values_CollectionChanged(object b,NotifyCollectionChangedEventArgs changes)
//    {
//        Console.WriteLine(changes.Action);
//        if (changes.OldItems != null)
//        {
//            foreach (var item in changes.OldItems)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        if (changes.NewItems != null)
//        {
//            foreach (var item in changes.NewItems)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }

//}
using System;

public class GenericClass <T>
{
    public T Generic(T one)
    {
        return one;
    }
    public T Generic1(T two)
    {
        return two;
    }
}
class Program
{
    static void Main(string[] args)
    {
        GenericClass<int> gclass = new GenericClass<int>();
        Console.WriteLine(gclass.Generic(10)+gclass.Generic1(20));
    }
}