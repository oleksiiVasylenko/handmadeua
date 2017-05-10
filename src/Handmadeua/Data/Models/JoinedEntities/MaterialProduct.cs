namespace Handmadeua.Data.Models.JoinedEntities
{
    public class MaterialProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
    }
}
