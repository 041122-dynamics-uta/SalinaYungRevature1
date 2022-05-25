using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CandyModels;

namespace CandyRepository
{
//communicate with db
    public class CandyRepoClass
    {
        public CandyMapperClass _mapper { get; set; }
        string connectionString = $"Server=tcp:salinayungserver.database.windows.net,1433;Initial Catalog=SalinaYungP1;Persist Security Info=False;User ID=salinayungdb;Password=Revature+Azure;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public CandyRepoClass() 
        {
            this._mapper = new CandyMapperClass(); //go to mapper class for format
        }
        public List<Products> ProductsList()
        {
            //query db for products list
            string myQuery1 = "SELECT * FROM Products;";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(myQuery1, query1);
                query1.Open();
                //command.Connection.Open();
                SqlDataReader results = command.ExecuteReader();
                
                //use mapper to transfer into <list>products
                List<Products> pl = new List<Products>();
                //while the database reader is reading
                while(results.Read()) 
                {
                //send in the row to be mapped
                //mapper returns to repo class
                //database object becomes a member of the list we are making based on mapper definition
                Products p = this._mapper.DboToProducts(results);
                pl.Add(p);
                //Console.WriteLine($"The products is: {results[0]}, {results[1]}, {results[2]}");
                }
                query1.Close();
                return pl;
            }
        }
        public List<Stores> StoresList()
        {
            //query db for store list
            string myQuery1 = "SELECT * FROM Stores;";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(myQuery1, query1);
                query1.Open();
                SqlDataReader results = command.ExecuteReader();
                
                //use mapper to transfer into <list>store
                List<Stores> sl = new List<Stores>();
                while(results.Read()) 
                {
                //send in the row to be mapped
                //mapper returns to repo class
                Stores s = this._mapper.DboToStores(results);
                sl.Add(s);
                //Console.WriteLine($"The stores is: {results[0]}, {results[1]}, {results[2]}");
                }
                query1.Close();
                return sl;
            }
        }
        public List<Customers> CustomersList()
        {
            //query db for customers list
            string myQuery1 = "SELECT * FROM Customers;";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(myQuery1, query1);
                query1.Open();
                SqlDataReader results = command.ExecuteReader();
                
                //use mapper to transfer into <list>customers
                List<Customers> cl = new List<Customers>();
                while(results.Read()) 
                {
                //send in the row to be mapped
                //mapper returns to repo class
                Customers c = this._mapper.DboToCustomers(results);
                cl.Add(c);
                //Console.WriteLine($"The customer is: {results[0]}, {results[1]}, {results[2]}");
                }
                query1.Close();
                return cl;
            }
        }
        public List<Orders> OrdersList()
        {
            //query db for orders list
            string myQuery1 = "SELECT * FROM Orders;";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(myQuery1, query1);
                query1.Open();
                SqlDataReader results = command.ExecuteReader();
                
                //use mapper to transfer into <list>store
                List<Orders> ol = new List<Orders>();
                while(results.Read()) 
                {
                //send in the row to be mapped
                //mapper returns to repo class
                Orders o = this._mapper.DboToOrders(results);
                ol.Add(o);
                //Console.WriteLine($"The orders is: {results[0]}, {results[1]}, {results[2]}");
                }
                query1.Close();
                return ol;
            }
        }
//------------------------------------------------------------------------------------------------------
        public List<Products> ProductsAtStore1List()
        {
            //query db for products list
            string myQuery1 = "SELECT * FROM Products INNER JOIN Stores ON Products.StoreID = Stores.StoreID;";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(myQuery1, query1);
                query1.Open();
                //command.Connection.Open();
                SqlDataReader results = command.ExecuteReader();
                
                //use mapper to transfer into <list>store
                List<Products> pasl = new List<Products>();
                //while the database reader is reading
                while(results.Read()) 
                {
                //send in the row to be mapped
                //mapper returns to repo class
                //database object becomes a member of the list we are making based on mapper definition
                Products p = this._mapper.DboToProducts(results);
                pasl.Add(p);
                //Console.WriteLine($"The products is: {results[0]}, {results[1]}, {results[2]}");
                }
                query1.Close();
                return pasl;
            }
        }

//------------------------------------------------------------------------------------------------------------
        public Customers NewCustomer(string FirstName, string LastName, string Email, string Pass)
        {
            string myQuery1 = $"INSERT INTO Customers (FirstName, LastName, Email, Pass) VALUES(@f, @l, @e, @p);";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(myQuery1, query1);
                //command.Parameters.AddWithValue("@id", CustomerId);
                command.Parameters.AddWithValue("@f", FirstName);
                command.Parameters.AddWithValue("@l", LastName);
                command.Parameters.AddWithValue("@e", Email);
                command.Parameters.AddWithValue("@p", Pass);
                command.Connection.Open();
                //return num of rows affected
                //if data already exists, notify user
                int results = command.ExecuteNonQuery();
                Console.WriteLine("Data successflly inserted in db");
                query1.Close();
                
                if (results == 1)
                {
                    Customers c = new Customers
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        Email = Email,
                        Pass = Pass
                    };  
                    return c;
                }
                return null;
            }
        }

        //this method will query db to see if email/pass exists
        public Customers EmailPassComboExists(string email, string password)
        {
           string myQuery1 = "SELECT * FROM Customers WHERE Email = @e AND Pass = @p;";
            
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@e", email);
                command.Parameters.AddWithValue("@p", password);
                query1.Open();
                //conduct query, only reading
                SqlDataReader results = command.ExecuteReader();

                if (results.Read()) //if results.read()
                {
                    Customers nc = _mapper.DboToCustomers(results);
                    query1.Close();
                    return nc;
                } else 
                {
                    query1.Close();
                    return null;
                }
            }
        }
    }
}//EoNamespace