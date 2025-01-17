namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Price { get; set; }
        public IEnumerable<Product_Prop> ProductProperties { get; set; }
    }
}
