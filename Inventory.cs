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

			Console.WriteLine($"\n-- {itemChoice} has been added to {User.Name}'s inventory --");
		}

		public void showInventory()
		{
            Console.WriteLine("\n-- User pockets content --");

            foreach (var item in this.items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
        }

		public void askShowInventory()
		{
            string reveal = null;

            while (reveal == null)
            {
                Console.WriteLine("\nType “reveal” to reveal what's in your pockets.");
                reveal = Console.ReadLine();

                if (reveal == "reveal")
                {
                    this.showInventory();
                }

                if (reveal != "reveal")
                {
                    reveal = null;
                }
            }
        }
    }
}

