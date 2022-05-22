using System;

namespace CandyModels
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int StoreId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}