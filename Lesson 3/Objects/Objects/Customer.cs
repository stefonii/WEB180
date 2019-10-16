using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    class Customer
    {
        // Properties
        public int custID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }     // use 5 or 5+4 digit zip   

        // Constructors
        public Customer()
        {
            custID = 0;        // 0 should not be used for valid customer
            fName = lName = address = city = zip = "";
        }

        public Customer(int id, string fn, string ln, string addr, string cy, string st, string zp)
        {
            custID = id;
            fName = fn;
            lName = ln;
            address = addr;
            city = cy;
            state = st;
            zip = zp;
        }

        // Methods
        //
        // Output customer block to screen
        //
        public void PrintBlock()
        {
            Console.WriteLine("Customer ID: " + custID.ToString());
            Console.WriteLine($"Name: " + fName.ToString() + " " + lName.ToString());
            Console.WriteLine("Address: " + address.ToString());
            Console.WriteLine("City, State Zip: " + city.ToString() + ", " + state.ToString() + " " + zip.ToString());

        }
    }
}
