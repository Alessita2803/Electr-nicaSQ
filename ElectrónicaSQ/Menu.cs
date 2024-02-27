using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrónicaSQ
{
    internal class Menu
    
    {
        public ElectrónicaSQ  inventory = new ElectrónicaSQ();
        public Menu() { }
        public void Main()

        {
           
            int option = 0;

            do
            {
               
                Menu.PrintMainMenu();
                if (int.TryParse(Console.ReadLine(), out int optionNumber)) option = optionNumber;

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        InsertData();
                        break;

                    case 2:
                        Console.Clear();
                        
                        int optionTwo = 0;

                        do
                        {
                            inventory.CheckAvailability();
                            Console.WriteLine("1. Sell Product");
                            Console.WriteLine("2. Back to main menu");

                            if (int.TryParse(Console.ReadLine(), out int optionTwoNumber)) optionTwo = optionTwoNumber;

                            if (optionTwo == 1)
                            {
                                Console.WriteLine("Insert the product id:");
                                string id = Console.ReadLine();
                                if (id == null) id = "";
                                
                                inventory.Sell(id);

                                
                            }
                        } while (optionTwo < 2);
                        break;

                    case 3:
                        Console.Clear();
                        inventory.CheckAvailability();

                        break;
                    case 4:
                        Console.Clear();
                        inventory.SellHistory();
                        break;

                    default:

                        break;

                }

            } while (option != 0);
        }
        public static void PrintMainMenu()
        {
            Console.WriteLine("Welcome to ElectrónicaSperen");
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("1. Register Product");
            Console.WriteLine("2. Sell Product");
            Console.WriteLine("3. Check Availability");
            Console.WriteLine("4. Check Sell History");
            Console.WriteLine("0. EXIT");
        }

        public void InsertData()
        {

            Console.WriteLine("Insert the product data:");
            Console.WriteLine("Insert name: ");
            var name = Console.ReadLine();
            if (name == null) name = "";
            Console.WriteLine("Insert brand name:");
            var brand = Console.ReadLine();
            if (brand == null) brand = "";
            Console.WriteLine("Insert the price:");
            Console.Write("$");
            float price = 0;
            if (float.TryParse(Console.ReadLine(), out float priceNumber)) price = priceNumber;
            Console.WriteLine("Insert the quantity: ");
            int quantity = 0;
            if (int.TryParse(Console.ReadLine(), out int quantityNumber)) quantity = quantityNumber;

            inventory.Register(name, brand, price, quantity);
        }
    }
}
