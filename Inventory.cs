namespace VirtualVendingMachine
{
	public class Inventory
	{
		public User User;
		public Bank Bank;

		public List<string> items = new List<string>();

		public Inventory(User user, Bank bank)
		{
			this.User = user;
			this.Bank = bank;

			items.Add("Pocket lint");
			items.Add("Keys");
			items.Add("Phone");
		}

        public void AddToInventory(string itemChoice)
        {
			items.Add(itemChoice);

            Console.WriteLine("\n--------------------------------------------");
			Console.WriteLine($"{itemChoice} has been added to {User.Name}'s inventory.");
            Console.WriteLine("--------------------------------------------");
        }

		public void ShowInventory()
		{
            Console.WriteLine("\n-- User's pocket contents --");

            foreach (var item in this.items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
        }

		public void AskShowInventory()
		{
            string reveal = null;

            while (reveal == null)
            {
                Console.WriteLine("\nType “reveal” to reveal what's in your pockets.\n");
                reveal = Console.ReadLine();

                if (reveal == "reveal")
                {
                    this.ShowInventory();
                }

                if (reveal != "reveal")
                {
                    reveal = null;
                }
            }
        }
    }
}

