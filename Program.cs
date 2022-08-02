using System;
using exenumcomposit.entties;
using exenumcomposit.entties.enums;
using System.Globalization;

namespace exenumcomposit
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Client Data: ");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            
            System.Console.WriteLine("Enter Order data:");

            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            System.Console.WriteLine("How mani itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            Client client = new Client(name,email,birthDate);
            Order order = new Order(now,status,client);

           
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Enter #{i+1} item data:");
                System.Console.Write("Product name: ");
                string productName  = Console.ReadLine();
                System.Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product = new Product(productName,productPrice);
                System.Console.Write("Quantity: ");
                int orderQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(orderQuantity,productPrice,product);

                order.AddItem(orderItem);

            }
            System.Console.WriteLine();
            System.Console.WriteLine("Oder sumary:");

            System.Console.WriteLine(order);


            
        }
    }


}