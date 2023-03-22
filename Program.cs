using VirtualVendingMachine;

var user = new User("Petyr", 100);

/* --- */

var bank = new Bank(user);

bank.Deposit(user.Money);

/* --- */

var vendingMachine = new VendingMachine();

vendingMachine.showItems();

/* --- */

var inventory = new Inventory(user, bank);

inventory.showInventory();

while (!user.userLeave())
{
    test();
    bool test()
    {
        Console.WriteLine("\nPlease choose one of the items from the vending machine. Type the product name below.");

        while (true)
        {
            var itemChoice = Console.ReadLine();

            if (vendingMachine.Purchase(user, bank, itemChoice, inventory))
            {
                test();
            }
        }
    }
}

