using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrónicaSQ
{
    internal class Ticket
    {
        public DateOnly Date { get; set; }
        public Product ProductSell { get; set; }

        public int Quantity { get; set; }
        public float Amount { get; set; }

        public Ticket(DateOnly date, Product productSell, int quantity)
        {
            Date = date;
            ProductSell = productSell;
            Quantity = quantity;
            Amount = productSell.Price * quantity;
        }
        public void ShowTicket()
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Date :" + Date.ToString("dd/MM/yy"));
            Console.WriteLine("Name: " + ProductSell.Name + " Brand:" + ProductSell.Brand + " Price:" + ProductSell.Price);
            Console.WriteLine(Quantity);
            Console.WriteLine("Amount:" + Amount);
            Console.WriteLine("------------------------------------------------------------------------");
            
        }
    }
}
