﻿using Persistence.Read_Models;

namespace Domain.Service.Calculators
{
    public class FeeCalculator : BaseCalculator
    {
        private readonly decimal _feeRate = 0.01m;

        public override decimal CalculateFee(Transaction transaction)
        {
            return transaction.TransferAmount * _feeRate;
        }

        public decimal GetFeeRate()
        {
            return _feeRate;
        }
    }
}
