namespace Yummy.WebUI.Dtos.MenuDto
{
    public class ResultMenuDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        
        public int? MenuId { get; set; }
        public int? CategoryId { get; set; }
    }
}
