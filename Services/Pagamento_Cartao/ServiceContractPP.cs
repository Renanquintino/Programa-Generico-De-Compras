using System;
using System.Collections.Generic;
using System.Text;
using Pleno.Com.Entidades;
using PlenoCom.Entidades;

namespace PlenoCom.Services
{
    class ServiceContractPP
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ServiceContractPP()
        {
        }

        public ServiceContractPP(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contrato contract, int months)
        {
            double contabase = (contract.TotalValue / months);
            for (int i = 1; i <= months; i++)
            {
                DateTime data = contract.Date.AddMonths(i);
                double updatedQuota = contabase + _onlinePaymentService.Interest(contabase, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(data, fullQuota));

            }
        }
    }
}
