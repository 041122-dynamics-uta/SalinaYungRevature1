using System;
using System.Collections.Generic;

namespace CandyModels
{
    public class Stores
    {
        public int StoreId { get; set; }
        public string StoreLocation { get; set; }
        public string StoreName { get; set; }
        //catalog of products that can be bought in this store
        public List<Products> Products { get; set; }

        public Stores()
        {
            //new type of empty list
            Products = new List<Products>();
        }

        public Stores(int storeId, string storeLocation, string storeName)
        {
            StoreId = storeId;
            StoreLocation = storeLocation;
            StoreName = storeName;
            Products = new List<Products>();
        }
    }
}
