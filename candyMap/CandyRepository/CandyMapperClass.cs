using System;
using System.Data.SqlClient;
using CandyModels;

namespace CandyRepository
{
    public class CandyMapperClass
    {
        internal Stores DboToStores(SqlDataReader reader)
        {
            Stores s = new Stores 
            {
                StoreId = (int)reader[0],
                StoreName = (string)reader[1],
                StoreLocation = (string)reader[2]
            };
            return s;
        }
        internal Products DboToProducts(SqlDataReader reader)
        {
            Products p = new Products
            {
                ProductId = (int)reader[0],
                ProductName = (string)reader[1],
                Price = (decimal)reader[2],
                ProductDescription = (string)reader[3],
                StoreId = (int)reader[4],
                DateCreated = (DateTime)reader[5]
            };
            return p;
        }
         internal Customers DboToCustomers(SqlDataReader reader)
        {
            Customers c = new Customers
            {
                CustomerId = (int)reader[0], //db handles
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                Email = (string)reader[3],
                Pass = (string)reader[4],
                DateCreated = (DateTime)reader[5]
            };
            return c;
        }
        internal Orders DboToOrders(SqlDataReader reader)
        {
            Orders o = new Orders
            {
                OrderId = (int)reader[0],               
                CustomerId_FK = (int)reader[1],
                ProductID_FK = (int)reader[2],
                StoreId_FK = (int)reader[3],
                Quantity = (int)reader[4],
                Price = (decimal)reader[5],
                DateCreated = (DateTime)reader[6]
            };
            return o;
        }
    }
}