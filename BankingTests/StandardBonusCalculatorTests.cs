﻿using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class StandardBonusCalculatorTests
    {
        [Theory]
        [InlineData(100, 9999, 0)]
        [InlineData(100, 10000, 10)]
        public void CanCalculateBonusesBeforeCutoff(decimal deposit, decimal balance, decimal expected)
        {
            ICalculateBonuses bonusCalculator = new StandardBonusCalculator();
            var bonus = bonusCalculator.GetDepositBonusFor(deposit, balance);

            Assert.Equal(expected, bonus);
        }

        [Theory]
        [InlineData(100, 9999, 0)]
        [InlineData(100, 10000, 5)]
        public void CanCalculateBonusesAfterCutoff(decimal deposit, decimal balance, decimal expected)
        {
            ICalculateBonuses bonusCalculator = new StandardBonusCalculator();
            var bonus = bonusCalculator.GetDepositBonusFor(deposit, balance);

            Assert.Equal(expected, bonus);
        }
    }
}