namespace VirtualVendingMachine
{
    public class User
    { 
        public string Name { get; }
        public int Money { get; }

        public User(string name, int money)
        {
            Name = name;
            Money = money;

            Console.WriteLine($"{this.Name} is standing near the vending machine. Hungry or thirsty? {this.Name} is not quite sure.");
        }

        public bool userLeave()
        {
            return false;
        }
    }
}