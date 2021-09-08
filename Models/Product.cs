namespace web_project.Models
{
    public enum Category
    {
        Vegetable, Fruit, Meat, CannedOrganic, Organic, Mushroom, OrganicJuice
    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category? Category { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}