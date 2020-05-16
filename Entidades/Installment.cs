using Pleno.Com.Entidades;
using PlenoCom.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PlenoCom.Entidades
{

    class Installment
    {
        public DateTime DueDate { get; set; }

        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public Installment(ServiceContractPP serviceContractPP)
        {
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);

           
        }
    }
}
