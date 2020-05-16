using System;
using System.Collections.Generic;
using System.Text;

namespace PlenoCom.Services
{
    class calcIntalment:IPaymentInstallment
    {
        private const double PorcentagemFee = 0.003;
        private const double juros = 0.03;

        public double Interest(double amount, int months)
        {
            return amount * juros * months;
        }
      
        public double TaxInstalment(double amount)
        {
            return amount * PorcentagemFee;
        }
    }
}
