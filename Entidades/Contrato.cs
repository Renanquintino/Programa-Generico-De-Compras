using System;
using System.Collections.Generic;
using System.ComponentModel;
using PlenoCom.Entidades;
using PlenoCom.Services;


namespace Pleno.Com.Entidades
{
    class Contrato
    {
        public int Number { get; set; }
        public Client client { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; }
        public DeliveryAdrress Delivery { get; set; }
        
        public Contrato()
        {
        }

        public Contrato(int number, Client client, DateTime date, double totalValue)
        {
            Number = number;
            this.client = client;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installment>();
        }
        public void AddInstallment(Installment installment)
        {
            Installment.Add(installment);
        }

        public override string ToString()
        {
            return
                "        CONTRATO      "
                             + "Numero do contrato:" + Number
                             + "VAlor do Contato: $" + TotalValue
                                + "\n"
                                  + "\n CLIENTE "
                                   + "\n CPF;  " + client.Id
                                     + "\n NOME: " + client.Nome
                                       + "\n DATA DE NASCIMENTO:  " + client.Birthday
                                     + "\n  TELEFONE: " + client.Telephone
                                  + "\n";
                          


        }

    }

}
