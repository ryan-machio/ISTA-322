using System;
using System.Collections.Generic;


namespace Quiz09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C# Quiz 9");
            Console.WriteLine("Here is the stack");
            Stack<string> s = new Stack<string>();
            s.Push("One");
            s.Push("Two");
            s.Push("Three");

            foreach (string str in s)
                Console.WriteLine(str);

            Queue<string> q = new Queue<string>();
            q.Enqueue("One");
            q.Enqueue("Two");
            q.Enqueue("Three");

            Console.WriteLine("Here is the queue");
            foreach (string str in q)
                Console.WriteLine(str);

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("One", 1);
            d.Add("Two", 2);
            d.Add("Three", 3);

            Console.WriteLine("Here is the dictionary");
            foreach (KeyValuePair<string, int> kvp in d)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
