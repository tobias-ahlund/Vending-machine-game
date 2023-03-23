using System.Numerics;
using VirtualVendingMachine;

var user = new User("Petyr", 100);
var bank = new Bank(user);
var inventory = new Inventory(user, bank);
var vendingMachine = new VendingMachine(user, bank, inventory);

bank.Deposit(user.Money);

Console.WriteLine(user.Money);

vendingMachine.AskShowItems();
inventory.AskShowInventory();
bank.AskShowBalance();

vendingMachine.TryPurchase(user, bank, inventory, vendingMachine);

