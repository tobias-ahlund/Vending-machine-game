using System.Numerics;
using VirtualVendingMachine;

var user = new User("Petyr", 0);
var vendingMachine = new VendingMachine();
var bank = new Bank(user);
var inventory = new Inventory(user, bank);

bank.Deposit(user.Money);

vendingMachine.askShowItems();
inventory.askShowInventory();
bank.askShowBalance();

vendingMachine.tryPurchase(user, bank, inventory, vendingMachine);

