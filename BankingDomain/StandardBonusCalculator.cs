using System;

namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {
        ISystemTime _systemTime;

        public StandardBonusCalculator(ISystemTime systemTime)
        {
            _systemTime = systemTime;
        }

        decimal ICalculateBonuses.GetDepositBonusFor(decimal amountToDeposit, decimal currentBalance)
        {
            if (currentBalance >= 10000)
            {
                if (BeforeCutoff())
                {
                    return amountToDeposit * .1M;
                }
                else
                {
                    return amountToDeposit * .05M;
                }
            }
            else
            {
                return 0;
            }
        }

        protected virtual bool BeforeCutoff()
        {
            return _systemTime.GetCurrent().Hour < 17;
        }
    }
}