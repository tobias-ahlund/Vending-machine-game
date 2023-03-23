namespace VirtualVendingMachine
{
    public class User
    {
        public string Name { get; set; }
        public int Money { get; set; }

        public User(string name, int money)
        {
            this.Name = name;
            this.Money = money;

            Console.WriteLine($"{this.Name} is standing near the vending machine. Hungry or thirsty? {this.Name} is not quite sure.");
        }

        public void UserLeave()
        {
            Console.WriteLine($"\nThe story has come to an end. {this.Name} stole snus and a Fantomen magazine from the vending machine as he/she left.");
            Environment.Exit(0);
        }

        int counter = 0;

        public void TypePrompts(User user, Bank bank, Inventory inventory, VendingMachine vendingMachine)
        {
            string option = null;

            if (counter < 1)
            {
                Console.WriteLine("\nType “content”, “inventory” or “balance” to get the information you need. Type “continue” to continue shopping. When the senseless shopping spree is over, type “leave”.\n");
            }
            else
            {
                Console.WriteLine("\nType “content” for vending machine content.");
                Console.WriteLine($"Type “inventory” for {this.Name}'s inventory.");
                Console.WriteLine("Type “balance” to check current balance.");
                Console.WriteLine("Type “continue” to continue shopping.");
                Console.WriteLine("Type “leave” to leave the vending machine and exit the game.\n");
            }

            counter++;

            while (option == null)
            {
                option = Console.ReadLine();

                if (option == "content")
                {
                    vendingMachine.ShowItems();
                    option = null;
                }

                if (option == "inventory")
                {
                    inventory.ShowInventory();
                    option = null;
                }

                if (option == "balance")
                {
                    bank.ShowBalance();
                    option = null;
                }

                if (option == "continue")
                {
                    vendingMachine.TryPurchase(user, bank, inventory, vendingMachine);
                    option = null;
                }

                if (option == "leave")
                {
                    UserLeave();
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
                Console.WriteLine("Type “leave” to leave the vending machine and exit the game.\n");
            }

        }
    }
}