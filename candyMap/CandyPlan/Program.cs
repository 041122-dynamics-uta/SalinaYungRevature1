using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CandyModels;
using CandyBusiness;
using CandyRepository;

namespace candyMap
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate for business constructor -> repo
            CandyRepoClass crc = new CandyRepoClass();
            //instantiate to communicate with public business class and use their methods
            CandyBusinessClass cb = new CandyBusinessClass(crc);

            static List<Customers> getCustomers()
            {
                CandyRepoClass customerrc = new CandyRepoClass();
                CandyBusinessClass customerbc = new CandyBusinessClass(customerrc);
                List<Customers> customer = customerbc.CustomersList();
                return customer;
            }

            //welcome msg
            Console.WriteLine("Welcome to the Candy Shop!");

            Customers newCustomer = new Customers(); //repo class
            Customers existingCustomer = new Customers();
            bool logins = false;
            while(logins == false)
            {
            Console.WriteLine("Would you like to: \n\t 1) LOGIN or \n\t 2) REGISTER?");
            string loginOrRegister = Console.ReadLine();
            switch(loginOrRegister)
            {
                case "1": //login
                    Console.WriteLine("What is your email address?");
                    string Email = Console.ReadLine();
                    Console.WriteLine("What is your password?");
                    string Pass = Console.ReadLine();
                    //see if cust exists
                    List<Customers> customers = getCustomers();
                    for (int i = 0; i < customers.Count; i++)
                    {
                        //looping bug
                        if (customers[i].Email == Email && customers[i].Pass == Pass)
                        {
                            Console.WriteLine("Welcome back!");
                            //end loop
                            logins = true;
                        }
                        else 
                        {
                            Console.WriteLine("Invalid login. Try again.");
                        }
                    }
                break;
                case "2": //register
                    Console.WriteLine("What is your first name?");
                    string registerFirstName = Console.ReadLine();
                    Console.WriteLine("What is your last name?");
                    string registerLastName = Console.ReadLine();
                    Console.WriteLine("What is your email address?");
                    string registerEmail = Console.ReadLine();
                    Console.WriteLine("What is your password?");
                    string registerPassword = Console.ReadLine();
                    logins = true;
                    //insert into db
                    newCustomer = cb.NewCustomer(registerFirstName, registerLastName, registerEmail, registerPassword);
                    Console.WriteLine($"Hello {newCustomer.FirstName} {newCustomer.LastName}, your email is {newCustomer.Email}");
                break;
                default:
                Console.WriteLine("Not valid, try again.");
                break;
            }
            }

            //ask to shop or see history
            historyOrShop();
            void historyOrShop()
            {
                bool choice1 = false;
                while(choice1 == false) 
                {
                Console.WriteLine("Would you like to: \n\t 1)Start shopping? or \n\t 2)View past purchases?");
                string shopOrHistory = Console.ReadLine();
                switch(shopOrHistory)
                {
                    case "1": //shop
                    startShop();
                    choice1 = true;
                    break;
                    case "2": //past purchases
                    viewHistory();
                    choice1 = true;
                    break;
                    default:
                    Console.WriteLine("Not valid, try again.");
                    break;
                }
                }
            }//EoHistoryOrShop
                
            void startShop()
            {
                Console.WriteLine("Please pick a store to shop at! Select Store ID:");
                List<Stores> stores = cb.StoresList();
                foreach (Stores s in stores)
                {
                    Console.WriteLine($"{s.StoreId} - {s.StoreName} - located in {s.StoreLocation}");
                }
                string storeChoice = Console.ReadLine();
                bool choice2 = false;
                while(choice2 == false)
                { 
                switch(storeChoice)
                {
                    case "1":
                    shoppingMenu("1");
                    choice2 = true;
                    break;
                    case "2":
                    shoppingMenu("2");
                    choice2 = true;
                    break;
                    case "3":
                    shoppingMenu("3");
                    choice2 = true;
                    break;
                    default:
                    Console.WriteLine("Not valid. Try again.");
                    break;
                }
                }
            }//EoStartShop

            void viewHistory()
            {
                List<Orders> orders = cb.OrdersList(); //business class
                foreach(Orders o in orders)
                {
                    //orders in mapper class
                    Console.WriteLine($"At Store {o.StoreId_FK} Customer number {o.CustomerId_FK}, ordered ${o.Price} of products.");
                    Console.WriteLine($"Order was taken at {o.DateCreated}");                                                    
                }                                                                       
                if (orders.Count == 0)
                {
                    Console.WriteLine("No order history to display.");
                }
                historyOrShop();
            }//EoViewHistory

            //NEEDS EDIT
            void shoppingMenu(string whichStore)
            {
                List<Products> store1Products = cb.ProductsAtStore1List();
                if (whichStore == "1")
                {
                    foreach(Products pas in store1Products)
                    {
                        if (pas.StoreId == 1)
                        {
                        Console.WriteLine($"Products available at ~Candy Girl, You Are My World~: {pas.ProductId}- {pas.ProductName}, {pas.ProductDescription} for ${pas.Price} each.");
                        Console.WriteLine("What would you like to purchase? Please write the productID.");
                        }                   
                    }

                    //Cart List . Add
                }
                else if (whichStore == "2")
                {
                   foreach(Products pas in store1Products)
                    {
                        if (pas.StoreId == 2)
                        {
                        Console.WriteLine($"Products available at ~I Want Candy, I Want Candy~: {pas.ProductId}- {pas.ProductName}, {pas.ProductDescription} for ${pas.Price} each.");
                        Console.WriteLine("What would you like to purchase? Please write the productID.");
                        }
                    } 
                }
                else if (whichStore == "3")
                {
                   foreach(Products pas in store1Products)
                    {
                        if (pas.StoreId == 3)
                        {
                        Console.WriteLine($"Products available at ~Pour Some Sugar On Me~: {pas.ProductId}- {pas.ProductName}, {pas.ProductDescription} for ${pas.Price} each");
                        Console.WriteLine("What would you like to purchase? Please write the productID.");
                        }
                    } 
                }
            }
        }//EoMain
    }//EoProgram
}//EoNamespace