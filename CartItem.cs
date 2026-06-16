namespace TPV_Galo
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int quantity { get; set; }

        public string productName
        {
            get { return Product != null ? Product.Name : ""; }
        }

        public decimal totalPrice
        {
            get { return Product != null ? Product.Price * quantity : 0; }
        }
    }
}