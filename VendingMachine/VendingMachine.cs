using System;

namespace VirtualVendingMachine
{
    public class VendingMachine
    {
        public Dictionary<string, int> items = new Dictionary<string, int>();

        public VendingMachine()
        {
            items.Add("Pepsi", 30);
            items.Add("Snickers", 25);
            items.Add("Doritos", 20);
            items.Add("Pretzels", 20);
            items.Add("Chewing gum", 15);
        }

        //public void Purchase(User user, Bank bank)
        //{
        //    if (checkBalance(user, bank))
        //    {

        //    }
        //}

        //public bool checkBalance(User user, Bank bank)
        //{
        //    if (bank.Balance >= items.Values[1])
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}