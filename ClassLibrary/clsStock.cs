using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Available { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}