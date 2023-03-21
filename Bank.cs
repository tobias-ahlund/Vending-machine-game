namespace VirtualVendingMachine
{
    public class Bank 
    {
        public int Balance = 0;

        public void Deposit(User user, int money)
        {
            Balance += money;
            money -= user.Money;
        }

        public void Withdraw(User user, int money)
        {
            if (money <= Balance)
            {
                Balance -= money;
                money += user.Money;
            }
        }
    }
}