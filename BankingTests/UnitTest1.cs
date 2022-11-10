using BankyStuffLibrary;
using System.Security.Principal;

namespace BankingTests
{
    public class BasicTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact] public void Test2()
        {

            var account = new BankAccount("Sandra", 10000);
            // test for a negative balance.

            Assert.Throws<InvalidOperationException>(() => account.MakeWithdrawal(750, DateTime.Now, "attempt to overdraw"));
            
                
           

            //// test that the initial balances must be positive.
            //bankaccount invalidaccount;
            //try
            //{
            //    invalidaccount = new bankaccount("invalid", -55);
            //}
            //catch (argumentoutofrangeexception e)
            //{
            //    console.writeline("exception caught creating account with negative balance");
            //    console.writeline(e.tostring());
            //    return;
            //}
        }
    }
}