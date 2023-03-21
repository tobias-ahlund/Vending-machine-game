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
        }      
    }
}