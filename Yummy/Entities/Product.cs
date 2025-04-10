﻿namespace Yummy.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int? MenuId { get; set; }
        public Menu MenuName { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
