using Pleno.Com.Entidades;
using PlenoCom.Entidades;
using PlenoCom.Services;
using System;
using System.Globalization;


namespace Pleno.Com
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("              SEJA BEM VINDO AO PLENO.COM          ");

            Console.WriteLine();

            Console.WriteLine("             ENTRE COM OS DADOS DO CLIENTE         ");

            Console.WriteLine();

            Console.WriteLine("CPF");
            string cpf = Console.ReadLine();
            Console.WriteLine("Nome");
            string name = Console.ReadLine();
            Console.WriteLine("DATA DE NASCIMENTO");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("TELEFONE");
            string phone = Console.ReadLine();

            Client client = new Client(cpf, name, birthday, phone);

            Console.WriteLine();

            Console.WriteLine("Entre com os dados do contrato");
            Console.Write("Numero do contrato: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Data do contrato: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();

            
            Contrato contrato = new Contrato(number, client, date, value);

            Console.WriteLine("             Dados de Entrega           ");
            Console.Write("Rua:  ");
            string rua = Console.ReadLine();
            Console.WriteLine("Numero:  ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Bairro:  ");
            string bairro = Console.ReadLine();


            DeliveryAdrress delivery = new DeliveryAdrress(rua, n, bairro);

            Console.WriteLine("INFORME O TIPO DE COMPRA ");
            Console.WriteLine("1-COMPRA A VISTA ");
            Console.WriteLine("2-COMPRA NO CARTAO DE CREDITO 2% DE JUROS + 0.1% ao mes   ");
            Console.WriteLine("3-COMPRA  CREDIARIO 30% DE JUROS SOBRE O PRODUTO ");
            Console.WriteLine();    
            Console.WriteLine("INSIRA A OPÇÃO DESEJADA   ");
            int compra = int.Parse(Console.ReadLine());
            if (compra == 1)
            {
                Console.WriteLine("Insira o valor do desconto(ex: 0.1=10%),(0.01=1%)");
                double por = double.Parse(Console.ReadLine());
                Console.WriteLine(value);

                double porc = value * por;

                Console.WriteLine(porc);

                double desconto = value - porc;

                Console.WriteLine(desconto);
            }
            else if (compra == 2)
            {

                Console.Write("Entre com o numero de parcelas: ");
                int month = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ServiceContractPP paypol = new ServiceContractPP(new PayPolService());
                paypol.ProcessContract(contrato, month);

                Console.WriteLine();
                Console.WriteLine("Parcelamento");

                foreach (Installment installment in contrato.Installment)
                {
                    Console.WriteLine(installment.Amount);
                }
            }
            else
            {
                Console.Write("Entre com o numero de parcelas: ");
                int month = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ServiceParc cred = new ServiceParc(new calcIntalment());
                cred.ProcessContract(contrato, month);

                Console.WriteLine();
                Console.WriteLine("Parcelamento Crediario ");

                foreach (Installment installment in contrato.Installment)
                {
                    Console.WriteLine(installment);
                   
                }




               

            }

            Console.WriteLine(delivery);
        }
    }
}
