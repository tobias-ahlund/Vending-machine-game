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
        }

        public void showBalance()
        {
            Console.WriteLine($"\n-- {User.Name}'s balance --");
            Console.WriteLine($"{Balance} SEK");
            Console.WriteLine("---------------------");
        }

        public void askShowBalance()
        {
            string balance = null;

            while (balance == null)
            {
                Console.WriteLine($"\nType “balance” to open bank app on phone and check balance.\n");
                balance = Console.ReadLine();

                if (balance == "balance")
                {
                    this.showBalance();
                }

                if (balance != "balance")
                {
                    balance = null;
                }
            }
        }
    }
}