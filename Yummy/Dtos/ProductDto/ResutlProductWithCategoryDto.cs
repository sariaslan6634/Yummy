﻿using Yummy.Entities;

namespace Yummy.Dtos.ProductDto
{
    public class ResutlProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
