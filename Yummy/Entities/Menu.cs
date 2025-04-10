namespace Yummy.Entities
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }

        public List<Product> Products { get; set; }
    }
}
