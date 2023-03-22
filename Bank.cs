namespace VirtualVendingMachine
{
    public class Bank
    {
        private User User;
        public int Balance = 0;

        public Bank(User user)
        {
            User = user;
        }

        public void Deposit(int money)
        {
            Balance += money;
            money -= User.Money;

            Console.WriteLine($"\n-- {User.Name}'s balance --");
            Console.WriteLine($"{Balance} SEK");
        }

        public void Withdraw(int money)
        {
            if (money <= Balance)
            {
                Balance -= money;
                money += User.Money;
            }
        }
    }
}