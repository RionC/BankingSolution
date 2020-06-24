using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class NewAccountTests
    {
        [Fact]
        public void NewAccountHaveCorrectBalance()
        {
            var account = new BankAccount();
            decimal balance = account.GetBalance();

            Assert.Equal(5000M, balance);
        }


    }
}
