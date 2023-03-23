using System;

namespace VirtualVendingMachine
{
    public class VendingMachine
    {
        private Bank bank { get; set; }
        private User user { get; set; }
        private Inventory inventory { get; set; }

        private Dictionary<string, int> items = new Dictionary<string, int>();

        public VendingMachine(User user, Bank bank, Inventory inventory)
        {
            this.user = user;
            this.bank = bank;
            this.inventory = inventory;

            items.Add("Pepsi", 30);
            items.Add("Snickers", 25);
            items.Add("Doritos", 20);
            items.Add("Pretzels", 20);
            items.Add("Chewing gum", 15);
            items.Add("Snus", 999);
            items.Add("Reading glasses", 30);
            items.Add("Propeller cap", 100);
            items.Add("Chewing tobacco", 1);
            items.Add("Fantomen", 50);
        }

        public bool Purchase(User user, Bank bank, string itemChoice, Inventory inventory, VendingMachine vendingMachine)
        {
            if (!CheckAvailable(user, bank, itemChoice))
            {
                return false;
            }

            if (!CheckBalance(bank, itemChoice, vendingMachine))
            {
                Console.WriteLine($"\nThe vending machine has {itemChoice} but your balance is too low.\n");

                string back = null;


                while (back != "back")
                {
                    Console.WriteLine("Type “back” to go back.\n");
                    back = Console.ReadLine();

                    if (back == "back")
                    {
                        user.TypePrompts(user, bank, inventory, vendingMachine);
                        back = "back";
                    }
                }
              
                return false;
            }

            inventory.AddToInventory(itemChoice);
            return true;
        }

        public bool CheckAvailable(User user, Bank bank, string itemChoice)
        {
            if (items.ContainsKey(itemChoice))
            {
                return true;
            }

            return false;
        }

        public bool CheckBalance(Bank bank, string itemChoice, VendingMachine vendingMachine)
        {
            if (bank.Balance >= items[itemChoice])
            {
                bank.Balance -= items[itemChoice];
                return true;
            }

            return false;
        }

        public void ShowItems()
        {
            Console.WriteLine("\n-- Vending machine contents --");

            foreach (var item in this.items)
            {
                Console.WriteLine($"{item.Key}, {item.Value} SEK");
            }

            Console.WriteLine("------------------------------");
        }

        public void AskShowItems()
        {
            string approach = null;

            while (approach == null)
            {
                Console.WriteLine("\nType “approach” to approach the vending machine and see its contents.\n");
                approach = Console.ReadLine();

                if (approach == "approach")
                {
                    this.ShowItems();
                }

                if (approach != "approach")
                {
                    approach = null;
                }
            }
        }

        public int counter = 0;

        public void TryPurchase(User user, Bank bank, Inventory inventory, VendingMachine vendingMachine)
        {
            if (counter < 1)
            {
                Console.WriteLine("\nNow it’s time to go on a shopping spree. Buy one of the items from the vending machine by typing its name.\n");
            }
            else
            {
                Console.WriteLine("\nBuy one of the items from the vending machine by typing its name.\n");
            }

            counter++;

            var itemChoice = Console.ReadLine();

            if (this.Purchase(user, bank, itemChoice, inventory, vendingMachine))
            {
                user.TypePrompts(user, bank, inventory, vendingMachine);
            }

            while (true)
            {
                Console.WriteLine("Buy one of the items from the vending machine by typing its name.\n");
                itemChoice = Console.ReadLine();

                if (this.Purchase(user, bank, itemChoice, inventory, vendingMachine))
                {
                    user.TypePrompts(user, bank, inventory, vendingMachine);
                }
            }
        }
    }
}