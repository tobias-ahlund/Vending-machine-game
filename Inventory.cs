namespace VirtualVendingMachine
{
	public class Inventory
	{
		public List<string> items = new List<string>();

		public Inventory()
		{
			items.Add("Pocket lint");
			items.Add("Keys");
			items.Add("Phone");
		}

		public void addItem(string item)
		{
			items.Add(item);
		}
	}
}

