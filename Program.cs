using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Insert(5);
            list.Insert(10);
            list.Insert(4);
            list.Insert(-1);
            list.Insert(23);
            list.Dump();
            list.Reverse();
            list.Dump();

            Console.WriteLine();

            var list2 = new LinkedList<int>(10, 55, 1, -42, 104, 28, 1024, -51);
            list2.Dump();
            list2.Reverse();
            list2.Dump();
        }
    }

    public static class LinkedListExtensions
    {
        public static void Dump<T>(this LinkedList<T> list)
        {
            Console.WriteLine(string.Join(" -> ", list));
        }
    }
}
