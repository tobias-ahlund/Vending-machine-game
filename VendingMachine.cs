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

        public void Purchase(User user, Bank bank, string itemChoice)
        {
            if (checkBalance(user, bank, itemChoice))
            {

            }

            if (checkAvailable(user, bank, itemChoice))
            {

            }
        }

        public bool checkBalance(User user, Bank bank, string itemChoice)
        {
            if (bank.Balance >= items[itemChoice])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkAvailable(User user, Bank bank, string itemChoice)
        {
            if (items.ContainsKey(itemChoice)) {
                Console.WriteLine("Item exists but you dont have enough money on your bank account.");
                return true;
            }

            return false;
        }
    }
}