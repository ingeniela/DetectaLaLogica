namespace WebApi.Cors.Example
{
    public class Buyer
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public string ClothingItem { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
