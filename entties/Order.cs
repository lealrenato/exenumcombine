using exenumcomposit.entties.enums;
using System.Text;
using System.Globalization;
namespace exenumcomposit.entties
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }


        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (var item in Itens)
            {
                sum += item.subTotal();
            }
            return sum;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Nome: {Client.Name} {Client.BirthDate.ToString("dd/MM/yyyy")} - {Client.Email}");
            sb.AppendLine("Order Itens");

            foreach (var item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}