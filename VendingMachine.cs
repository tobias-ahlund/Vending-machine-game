using System;

namespace VirtualVendingMachine
{
    public class VendingMachine
    {
        public Dictionary<string, int> items = new Dictionary<string, int>();

        public VendingMachine()
        {
            items.Add("Pepsi", 30);
            items.Add("Snickers", 25);
            items.Add("Doritos", 20);
            items.Add("Pretzels", 20);
            items.Add("Chewing gum", 15);
        }

        public bool Purchase(User user, Bank bank, string itemChoice, Inventory inventory, VendingMachine vendingMachine)
        {
            if (!checkAvailable(user, bank, itemChoice))
            {
                return false;
            }

            if (!checkBalance(bank, itemChoice, vendingMachine))
            {
                Console.WriteLine($"\nThe vending machine has {itemChoice} but your balance is too low.\n");

                string back = null;


                while (back != "back")
                {
                    Console.WriteLine("Type “back” to go back.\n");
                    back = Console.ReadLine();

                    if (back == "back")
                    {
                        user.typePrompts(user, bank, inventory, vendingMachine);
                        back = "back";
                    }
                }
              
                return false;
            }

            inventory.addToInventory(itemChoice);
            return true;
        }

        public bool checkAvailable(User user, Bank bank, string itemChoice)
        {
            if (items.ContainsKey(itemChoice))
            {
                return true;
            }

            return false;
        }

        public bool checkBalance(Bank bank, string itemChoice, VendingMachine vendingMachine)
        {
            if (bank.Balance >= items[itemChoice])
            {
                bank.Balance -= items[itemChoice];
                return true;
            }

            return false;
        }

        public void showItems()
        {
            Console.WriteLine("\n-- Vending machine content --");

            foreach (var item in this.items)
            {
                Console.WriteLine($"{item.Key}, {item.Value} SEK");
            }

            Console.WriteLine("-----------------------------");
        }

        public void askShowItems()
        {
            string approach = null;

            while (approach == null)
            {
                Console.WriteLine("\nType “approach” to approach the vending machine and see its contents.\n");
                approach = Console.ReadLine();

                if (approach == "approach")
                {
                    this.showItems();
                }

                if (approach != "approach")
                {
                    approach = null;
                }
            }
        }

        public int counter = 0;

        public void tryPurchase(User user, Bank bank, Inventory inventory, VendingMachine vendingMachine)
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
                user.typePrompts(user, bank, inventory, vendingMachine);
            }

            while (true)
            {
                Console.WriteLine("Buy one of the items from the vending machine by typing its name.\n");
                itemChoice = Console.ReadLine();

                if (this.Purchase(user, bank, itemChoice, inventory, vendingMachine))
                {
                    user.typePrompts(user, bank, inventory, vendingMachine);
                }
            }
        }
    }
}