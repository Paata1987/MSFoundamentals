using System;



namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var account = new BankAccount("Sandra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(5, DateTime.Now, "Rent payment");
            account.MakeWithdrawal(11, DateTime.Now, "Friend paid me back");
            account.MakeWithdrawal(120, DateTime.Now, "Hamax");
            account.MakeWithdrawal(5, DateTime.Now, "Coke");
            account.MakeWithdrawal(10, DateTime.Now, "Bigi LcMusic");
            account.MakeWithdrawal(12, DateTime.Now, "Coffee");



            Console.WriteLine(account.GetAccountHistory());







            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            //// Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}

        }
    }
}
