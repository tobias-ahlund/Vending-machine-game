using VirtualVendingMachine;

// Start by choosing a name and money amount.
var user = new User("Petyr", 100);

Console.WriteLine($"Hello, {user.Name}.");

// Deposit the money in order to use them with the vending machine. You can also withdray money.
var bank = new Bank();

bank.Deposit(user, user.Money);

Console.WriteLine($"{user.Name}'s balance is {bank.Balance} SEK.");

// List all available items in the vending machine.
var vendingMachine = new VendingMachine();

Console.WriteLine("\n-- Vending machine content --");

foreach (var item in vendingMachine.items)
{
    Console.WriteLine($"{item.Key}, {item.Value} SEK");
}

// List everything in possesion of the user.
var inventory = new Inventory(user, bank);

inventory.showInventory();

Console.WriteLine("\nPlease choose one of the items from the vending machine. Type the product name below.");

string itemChoice = null;

while (true)
{
    itemChoice = Console.ReadLine();

    if (vendingMachine.Purchase(user, bank, itemChoice, inventory))
    {
        return;
    }
}