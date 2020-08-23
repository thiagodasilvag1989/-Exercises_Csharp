using Exe_198Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_198Interface.Services
{
    class ContractService
    {
        private IOnlinePaymentService _olinePaymentService;
        
        public ContractService(IOnlinePaymentService olinePaymentService)
        {
            _olinePaymentService = olinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQouta = contract.TotalValue / months;

            for(int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double attQuota = basicQouta + _olinePaymentService.Interest(basicQouta, i);
                double fullQuota = attQuota + _olinePaymentService.PaymentFee(attQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
