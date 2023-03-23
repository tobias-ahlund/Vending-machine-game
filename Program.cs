using System.Numerics;
using VirtualVendingMachine;

var user = new User("Petyr", 100);
var vendingMachine = new VendingMachine();
var bank = new Bank(user);
var inventory = new Inventory(user, bank);

bank.Deposit(user.Money);

vendingMachine.askShowItems();
inventory.askShowInventory();
bank.askShowBalance();

/* ----- */

Console.WriteLine("\nNow it’s time to go on a shopping spree. Buy one of the items from the vending machine by typing its name.");

vendingMachine.tryPurchase(user, bank, inventory, vendingMachine);

/* -----*/

void runTypePrompts()
{
    user.typePrompts(user, bank, inventory, vendingMachine);
}