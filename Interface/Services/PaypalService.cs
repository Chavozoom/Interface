using System;

namespace Interface.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MontlhyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MontlhyInterest * months; 
        }
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
 
    }
}