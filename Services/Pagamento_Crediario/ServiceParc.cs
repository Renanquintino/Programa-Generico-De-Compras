using Pleno.Com.Entidades;
using PlenoCom.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlenoCom.Services
{
    class ServiceParc
    {
        private IPaymentInstallment _paymentInstallment;
        public ServiceParc(IPaymentInstallment paymentInstallment)
        {
            _paymentInstallment = paymentInstallment;
        }
        public void ProcessContract(Contrato contract, int months)
        {
            double contabase = (contract.TotalValue / months);
            for (int i = 1; i <= months; i++)
            {
                DateTime data = contract.Date.AddMonths(i);
                double updatedQuota = contabase + _paymentInstallment.Interest(contabase, i);
                double fullQuota = updatedQuota + _paymentInstallment.TaxInstalment(updatedQuota);
                contract.AddInstallment(new Installment(data, fullQuota));

            }
        }
    }
}
