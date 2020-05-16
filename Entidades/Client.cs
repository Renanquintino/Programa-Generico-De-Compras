using System;
using System.Collections.Generic;
using System.Text;

namespace Pleno.Com.Entidades
{
    class Client
    {
        public string  Id { get; set; }
        public string Nome { get; set; }

        public DateTime Birthday { get; private set; }

        public string Telephone { get; set; }


        public Client(string id, string nome, DateTime birthday, string telephone)
        {
            Id = id;
            Nome = nome;
            Birthday = birthday;
            Telephone = telephone;
        }
       
        
        
    }
}
