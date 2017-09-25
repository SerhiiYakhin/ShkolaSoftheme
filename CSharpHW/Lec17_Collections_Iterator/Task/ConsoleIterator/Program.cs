﻿using System;

namespace ConsoleIterator
{
    class Program
    {
        static void Main()
        {
            var a = new ConcreteAggregate<String>();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            var i = new ConcreteIterator<string>(a);

            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}
