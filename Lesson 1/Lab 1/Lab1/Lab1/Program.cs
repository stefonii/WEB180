using System;

namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create variables
            int a = 1;
            uint b = 0;
            char c = '5';
            float d = 1.0f;
            double e = 2.2;
            decimal f = 3m;
            bool g = true;
            const int x = 4;

            // Add two integers and display the output (show the formula, actual numbers and the output).
            a += (int)b;
            Console.WriteLine($"(Formula: a + (int)b )\t\t 1 + 0 = {a}");

            // Subtract an integer from another integer and display the output.
            f -= (decimal)e;
            Console.WriteLine($"(Formula: f - (decimal)e )\t 3m - 2.2 = {f}");

            // Multiply one of your integers by a constant. Display the output (formula, actual numbers, and output).
            d *= (float)c;
            Console.WriteLine($"(Formula: d * (float)c )\t 1.0f * '5' = {d}");

            // Divide one of your integers by a constant
            e /= (double)x;
            Console.WriteLine($"(Formula: e / (double)x )\t 2.2 / 4 = {e}\n");

            // Determine whether the following numbers are divisible by 4
            int q = 124;
            int r = 168;
            int s = 2017;
            int t = 1944;

            // Modulus to determine divisibility.
            int remainder = q % 4;
            if (remainder == 0)
                Console.WriteLine("The value of q or 124 is divisible by 4.");
            else
                Console.WriteLine("The value of q or 124 is NOT divisible by 4.");
            Console.WriteLine();

            remainder = r % 4;
            if (remainder == 0)
                Console.WriteLine("The value of r or 168 is divisible by 4.");
            else
                Console.WriteLine("The value of r or 168 is NOT divisible by 4.");
            Console.WriteLine();

            remainder = s % 4;
            if (remainder == 0)
                Console.WriteLine("The value of s or 2017 is divisible by 4.");
            else
                Console.WriteLine("The value of s or 2017 is NOT divisible by 4.");
            Console.WriteLine();

            remainder = t % 4;
            if (remainder == 0)
                Console.WriteLine("The value of t or 1944 is divisible by 4.");
            else
                Console.WriteLine("The value of t or 1944 is NOT divisible by 4.");
            Console.WriteLine();

        }
    }
}
