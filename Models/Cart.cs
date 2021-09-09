namespace web_project.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public User Customer { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}