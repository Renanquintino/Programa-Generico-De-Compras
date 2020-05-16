using System;
using System.Collections.Generic;
using System.Text;

namespace Pleno.Com.Entidades
{
    class DeliveryAdrress
    {
        public int NumberHouse { get; set; }
        public string Street { get; set; }

        public string Borhood { get; set; }

        public DeliveryAdrress()
        {
        }

        public DeliveryAdrress(string street, int numberHouse, string borhood)
        {
            Street = street;
            NumberHouse = numberHouse;

            Borhood = borhood;
        }

        public override string ToString()
        {
            return "      ENDEREÇO         "
                             + "\n RUA: " + Street
                           + "\n NUMERO: " + NumberHouse
                         + "\n BAIRRO: " + Borhood;





        }
    }
}

