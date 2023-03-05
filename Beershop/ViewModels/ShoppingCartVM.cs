namespace Beershop.ViewModels
{
    public class ShoppingCartVM
    {
       public List<CartVM>? Cart { get; set; }
    }

    public class CartVM
    {
        public int Biernr { get; set; }
        public string? Naam { get; set; }
        public int Aantal { get; set; }
        public float Prijs { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
