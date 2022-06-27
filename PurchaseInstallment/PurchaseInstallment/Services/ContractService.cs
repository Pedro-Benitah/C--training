using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseInstallment.Entities;

namespace PurchaseInstallment.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for(int i = 1; i <= months; i++)
            {
                double updatedQuota = _onlinePaymentService.PaymentFee(basicQuota);
                double fullQuota = _onlinePaymentService.Interest(updatedQuota, i);
                DateTime date = contract.Date.AddMonths(i);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
