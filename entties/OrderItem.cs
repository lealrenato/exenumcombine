using System.Text;
namespace exenumcomposit.entties
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal(){
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("produto: "+ Product.Name);
            sb.Append(" valor: "+ Product.Price);
            sb.Append(" subtotal: "+ subTotal());

            return sb.ToString();
        }


    }
}