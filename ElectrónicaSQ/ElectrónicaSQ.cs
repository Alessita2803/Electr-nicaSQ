using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrónicaSQ
{
    internal class ElectrónicaSQ
    {
        public List<Product> products = new List<Product>();
        public List<Ticket> tickets = new List<Ticket>();

        public void Register(string name, string brand, float price, int quantity)
        {
            var id = Guid.NewGuid().ToString().Substring(0, 3);
            var product = new Product(id, name, brand, price, quantity);
            products.Add(product);
        }
        public void Sell(string id)
        {
            var product = products.Find(product => product.Id == id);
            if (product == null)
            {
                Console.WriteLine("Product not found");
                return;
            }

            Console.WriteLine("Sell Quantity: ");
            int quantity = 0;
            if (int.TryParse(Console.ReadLine(), out int sellNumber)) quantity = sellNumber;

            if (product.Quantity < quantity || quantity <= 0)
            {
                Console.WriteLine("There isn't enough stock for sell");
                return;
            }
            if (product.Quantity == 0)
            {
                Console.WriteLine("No stock");
                return;
            }

            product.Quantity -= quantity;
            Console.WriteLine("¡SOLD!");
            var date = DateOnly.FromDateTime(DateTime.Now);
            var ticket = new Ticket(date, product, quantity);

            tickets.Add(ticket);
            ticket.ShowTicket();
        }
        public void CheckAvailability()
        {
            foreach (var product in products)
            {
                Console.WriteLine("ID: " + product.Id + " Name:" + product.Name + " Brand:" + product.Brand + " Price: $" + product.Price + " Quantity: " + product.Quantity);
            }
        }
        public void SellHistory()
        {
            foreach (var ticket in tickets)
            {
                ticket.ShowTicket();
            }
        }

    }
}
