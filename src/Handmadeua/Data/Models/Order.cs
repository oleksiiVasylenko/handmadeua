namespace Handmadeua.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comments { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
