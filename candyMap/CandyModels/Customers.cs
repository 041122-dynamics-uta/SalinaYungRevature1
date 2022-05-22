using System;
using System.Collections.Generic;

namespace CandyModels
{
    //publicly visible customer class library
    public class Customers
    {
        //customer properties //can get and set value
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set;}
        public DateTime DateCreated { get; set; }
        //view cart
        public List<Products> Cart { get; set; }
        //view order history
        public List<Orders> OrderHistory { get; set; }

        //methods
        //default values for a customer created with no values
        public Customers()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Pass = "";
            Cart = new List<Products>();
            OrderHistory = new List<Orders>();
        }

        //parameterized constructor function to create the customer
        public Customers(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Pass = password;
            Cart = new List<Products>();
            OrderHistory = new List<Orders>();
        }
    }
}