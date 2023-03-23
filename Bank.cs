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
            this.Balance += money;
            this.User.Money -= money;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"\n-- {this.User.Name}'s balance --");
            Console.WriteLine($"{this.Balance} SEK");
            Console.WriteLine("---------------------");
        }

        public void AskShowBalance()
        {
            string balance = null;

            while (balance == null)
            {
                Console.WriteLine($"\nType “balance” to open bank app on phone and check balance.\n");
                balance = Console.ReadLine();

                if (balance == "balance")
                {
                    this.ShowBalance();
                }

                if (balance != "balance")
                {
                    balance = null;
                }
            }
        }
    }
}