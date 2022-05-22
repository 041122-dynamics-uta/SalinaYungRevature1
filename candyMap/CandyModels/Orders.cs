using System;
using System.Collections.Generic;

namespace CandyModels
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId_FK { get; set; }
        public int ProductID_FK { get; set; }
        public int StoreId_FK { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Products> Products { get; set; }
        public List<Orders> OrderHistory { get; set;}
    }
}