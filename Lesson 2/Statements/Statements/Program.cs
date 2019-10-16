using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statements
{
    class Statements
    {
        static void Main(string[] args)
        {
            // local declarations
            int a;
            int b = 2, c = 3;
            a = 1;
            const float pi = 3.1415927f;
            const int r = 25;
            int d = 5;
            const double g = 9.80665;


            // if statement
            string s = "string";
            if (s.Length == 0)
            {
                Console.WriteLine("No string.");
            } else
            {
                Console.WriteLine($"One or more string. String has length of {s.Length}.");
            }
            Console.WriteLine();

            // switch statement
            string[] t = { "one", "two", "three" };
            int n = t.Length;
            switch(n)
            {
                case 0:
                    Console.WriteLine("No arguments.\n");
                    break;
                case 1:
                    Console.WriteLine("One argument.\n");
                    break;
                case 2:
                    Console.WriteLine("Two argument.\n");
                    break;
                case 3:
                    Console.WriteLine("Three argument.\n");
                    break;
                case 4:
                    Console.WriteLine("Four argument.\n");
                    break;
                case 5:
                    Console.WriteLine("Five argument.\n");
                    break;
                default:
                    Console.WriteLine($"{n} arguments.\n");
                    break;
            }

            // while statement
            int i = 0;
            while (i < t.Length)
            {
                Console.WriteLine($"{i+1}: {t[i]}");
                i++;
            }

            // do while statement
            string u = "";
            int counter = 1; // initialize counter
            do
            {
                Console.Write("Enter a string: ");
                u = Console.ReadLine();

                if (string.IsNullOrEmpty(u))
                {
                    Console.WriteLine(u);
                }
                else
                    Console.WriteLine($"{counter}: {u}");
                counter++;
            } while (!string.IsNullOrEmpty(u));
            Console.WriteLine();


            // for statement
            for (int j = 1; j <= 10; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }

            // foreach statement
            foreach (string v in t)
            {
                Console.WriteLine($"{v}({Array.IndexOf(t, v)})");
            }
            Console.WriteLine();
        }
    }
}
