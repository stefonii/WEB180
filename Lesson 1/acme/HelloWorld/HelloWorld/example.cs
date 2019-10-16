﻿using System;

using Acme.Collections;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // From Acme.Collections
            Stack s = new Stack();
            s.Push(1);
            s.Push(10);
            s.Push(100);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
        }
    }
}
