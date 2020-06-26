﻿using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class BankAccountBadAmountTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        public void DepositThrowForBadAmounts(decimal badAmount)
        {
            var account = new BankAccount(null, null);

            Assert.Throws<BadAmountException>(() => account.Deposit(badAmount));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        public void WithdrawThrowsForBadAmounts(decimal badAmount)
        {
            var account = new BankAccount(null, null);

            Assert.Throws<BadAmountException>(() => account.Withdraw(badAmount));
        }
    }
}