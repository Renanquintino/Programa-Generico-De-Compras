using System;
using System.Collections.Generic;
using System.Text;

namespace PlenoCom.Services
{
    interface IPaymentInstallment
    {
        double TaxInstalment(double amount);
        double Interest(double amount, int months);

    }
}
