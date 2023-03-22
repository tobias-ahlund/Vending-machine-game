namespace VirtualVendingMachine
{
	public class Inventory
	{
		private User User;
		private Bank Bank;

		public List<string> items = new List<string>();

		public Inventory(User user, Bank bank)
		{
			User = user;
			Bank = bank;

			items.Add("Pocket lint");
			items.Add("Keys");
			items.Add("Phone");
		}

        public void addToInventory(string itemChoice)
        {
			items.Add(itemChoice);

			Console.WriteLine($"\n{itemChoice} has been added to {User.Name}'s inventory.");
			Console.WriteLine($"{User.Name} has {Bank.Balance} SEK left.");

			showInventory();
		}

		public void showInventory()
		{
            Console.WriteLine("\n-- User pockets content --");

            foreach (var item in this.items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

