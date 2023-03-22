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

        public bool Purchase(User user, Bank bank, string itemChoice, Inventory inventory)
        {
            if (!checkAvailable(user, bank, itemChoice))
            {
                Console.WriteLine($"\nMake sure {itemChoice} exists and you have spelled it correctly.");
                return false;
            }

            if (!checkBalance(bank, itemChoice))
            {
                Console.WriteLine($"The vending machine has {itemChoice} but your balance is too low.");
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

        public bool checkBalance(Bank bank, string itemChoice)
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
        }
    }
}