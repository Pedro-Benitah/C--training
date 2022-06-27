using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseInstallment.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount *= 1 + 0.02;
        }
        public double Interest(double amount, int months)
        {
            return amount *= 1 + (0.01 * months);
        }
    }
}
