using System.Collections.Generic;

namespace CandyModels
{
    public class Inventory
    {
        public Dictionary<Products, int> Products { get; set; } = new Dictionary<Products, int>();
        public Stores Store { get; set; } = new Stores();
    }
}