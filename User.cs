namespace VirtualVendingMachine
{
    public class User
    { 
        public string Name { get; }
        public int Money { get; }

        public User(string name, int money)
        {
            Name = name;
            Money = money;

            Console.WriteLine($"{this.Name} is standing near the vending machine. Hungry or thirsty? {this.Name} is not quite sure.\n");
        }

        public bool userLeave()
        {
            return true;
        }

        public void typePrompts(User user, Bank bank, Inventory inventory, VendingMachine vendingMachine)
        {
            string option = null;

            Console.WriteLine("\nType “content”, “inventory” or “balance” to get the information you need. Type “continue” to continue shopping. When the senseless shopping spree is over, type “leave”.");

            while (option == null)
            {
                option = Console.ReadLine();

                if (option == "content")
                {
                    vendingMachine.showItems();
                    option = null;
                }

                if (option == "inventory")
                {
                    inventory.showInventory();
                    option = null;
                }

                if (option == "balance")
                {
                    bank.showBalance();
                    option = null;
                }

                if (option == "continue")
                {
                    vendingMachine.tryPurchase(user, bank, inventory, vendingMachine);
                    option = null;
                }

                if (option == "leave")
                {
                    Console.WriteLine($"\nThis story has come to an end. {this.Name} stole pretzels and Doritos from the machine as he/she left.");
                    return;
                }

                if (option != "approach" && option != "reveal" && option != "balance" && option != "continue" && option != "leave")
                {
                    option = null;
                }

                Console.WriteLine("\nType “content” for vending machine content.");
                Console.WriteLine($"Type “inventory” for {this.Name}'s inventory.");
                Console.WriteLine("Type “balance” to check current balance.");
                Console.WriteLine("Type “continue” to continue shopping.");
                Console.WriteLine("Type “leave” to leave the vending machine and exit the game.");
            }

        }
    }
}