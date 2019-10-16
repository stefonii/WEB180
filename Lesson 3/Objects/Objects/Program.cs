using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // create a new customer
            Customer cust = new Objects.Customer(11011, "Michael", "Schore", "100 Main St.", "Raleigh", "NC", "27603");
            // another way to create a new customer
            Customer nextCust = new Customer();

            // create 3 different customers
            Customer cust2 = new Objects.Customer(11012, "Bob", "Smith", "123 Sesame St.", "Charlotte", "NC", "28105");
            Customer cust3 = new Objects.Customer(20821, "Jane", "Doe", "700 Hollywood Rd.", "Richmond", "VA", "23173");
            Customer cust4 = new Objects.Customer(37849, "Chloe", "Brown", "289 King Dr.", "Atlanta", "GA", "30301");

            // output customer block
            cust.PrintBlock();
            Console.WriteLine();

            cust2.PrintBlock();
            Console.WriteLine();

            cust3.PrintBlock();
            Console.WriteLine();

            cust4.PrintBlock();
            Console.WriteLine();
        }
    }
}
