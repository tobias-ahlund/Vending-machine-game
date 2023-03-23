using System.Numerics;
using VirtualVendingMachine;

var user = new User("Petyr", 100);
var vendingMachine = new VendingMachine();
var bank = new Bank(user);
var inventory = new Inventory(user, bank);
bank.Deposit(user.Money);

/* ----- */

string approach = null;

while (approach == null)
{
    Console.WriteLine("Type “approach” to approach the vending machine and see its contents.");
    approach = Console.ReadLine();

    if (approach == "approach")
    {
        vendingMachine.showItems();
    }

    if (approach != "approach")
    {
        approach = null;
    }
}

/* ----- */

string reveal = null;

while (reveal == null)
{
    Console.WriteLine("\nType “reveal” to reveal what's in your pockets.");
    reveal = Console.ReadLine();

    if (reveal == "reveal")
    {
        inventory.showInventory();
    }

    if (reveal != "reveal")
    {
        reveal = null;
    }
}

/* ----- */

string balance = null;

while (balance == null)
{
    Console.WriteLine($"\nType “balance” to open bank app on phone and check balance.");
    balance = Console.ReadLine();

    if (balance == "balance")
    {
        bank.showBalance();
    }

    if (balance != "balance")
    {
        balance = null;
    }
}

/* ----- */

while (!user.userLeave())
{
    test();
    bool test()
    {
        Console.WriteLine("\nNow it’s time to go on a shopping spree. Buy one of the items from the vending machine by typing its name");

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

