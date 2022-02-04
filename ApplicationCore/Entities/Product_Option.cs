namespace ApplicationCore.Entities
{
    public class Product_Option
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}